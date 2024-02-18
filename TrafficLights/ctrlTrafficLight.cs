using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TrafficLight.Properties;

namespace TrafficLight
{
    public partial class ctrlTrafficLight : UserControl
    {          
        public enum enTrafficLights { Red , Green , Orange};
        public class TrafficLightEventArgs : EventArgs
        {
            public enTrafficLights CurrentLight { get; }
            public int LightDuration { get; }

            public TrafficLightEventArgs(enTrafficLights currentLight, int lightDuration)
            {
                CurrentLight = currentLight;
                LightDuration = lightDuration;
            }

        }


        private enTrafficLights _CurrentLight = enTrafficLights.Red;
        public enTrafficLights CurrentLight
        {
            get
            {
                return _CurrentLight;
            }

            set
            {
                _CurrentLight = value;

                switch(_CurrentLight)
                {
                    case enTrafficLights.Red:
                        _CurrentCountDownValue = RedTime;
                        lblCurrentCountDown.ForeColor = Color.Red;               
                        pbTrafficLight.Image = Resources.Red;                
                        break;

                    case enTrafficLights.Green:
                        _CurrentCountDownValue = GreenTime;
                        lblCurrentCountDown.ForeColor = Color.Green;
                        pbTrafficLight.Image = Resources.Green;                        
                        break;

                    case enTrafficLights.Orange:
                        _CurrentCountDownValue = OrangeTime;
                        lblCurrentCountDown.ForeColor = Color.Orange;
                        pbTrafficLight.Image = Resources.Orange;                        
                        break;
                }
            }
        }


        private int _CurrentCountDownValue;

        private Dictionary<enTrafficLights, Action> trafficLightOnEventHandlers;

        private Dictionary<enTrafficLights, Action> trafficLightOffEventHandlers;


        #region Traffic Lights Durations

        private int _RedTime = 15;
        private int _GreenTime = 10;
        private int _OrangeTime = 5;

        public int RedTime 
        { 
            set
            {
                _RedTime = value;
            }

            get
            {
                return _RedTime;
            }
        
        } 
        public int GreenTime
        {
            set
            {
                _GreenTime = value;
            }

            get
            {
                return _GreenTime;
            }

        }
        public int OrangeTime

        {
            set
            {
                _OrangeTime = value;
            }

            get
            {
                return _OrangeTime;
            }

        }

        #endregion

        #region Traffic Lights Events

        #region On Events
        public event EventHandler<TrafficLightEventArgs> RedLightOn;
        protected virtual void OnRedLightOn()
        {
            TrafficLightEventArgs e = new TrafficLightEventArgs(enTrafficLights.Red, _RedTime);
            CurrentLight = e.CurrentLight;

            RedLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> GreenLightOn;
        protected virtual void OnGreenLightOn()
        {
            TrafficLightEventArgs e = new TrafficLightEventArgs(enTrafficLights.Green, _GreenTime);
            CurrentLight = e.CurrentLight;

            GreenLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> OrangeLightOn;
        protected virtual void OnOrangeLightOn()
        {
            TrafficLightEventArgs e = new TrafficLightEventArgs(enTrafficLights.Orange, _OrangeTime);
            CurrentLight = e.CurrentLight;

            OrangeLightOn?.Invoke(this, e);
        }
        #endregion

        #region OFF Events
        public event EventHandler<TrafficLightEventArgs> RedLightOFF;
        protected virtual void OnRedLightOFF()
        {
            RedLightOFF?.Invoke(this, new TrafficLightEventArgs(enTrafficLights.Green, _GreenTime));
        }

        public event EventHandler<TrafficLightEventArgs> GreenLightOFF;
        protected virtual void OnGreenLightOFF()
        {
            GreenLightOFF?.Invoke(this, new TrafficLightEventArgs(enTrafficLights.Orange, _OrangeTime));
        }

        public event EventHandler<TrafficLightEventArgs> OrangeLightOFF;
        protected virtual void OnOrangeLightOFF()
        {
            OrangeLightOFF?.Invoke(this, new TrafficLightEventArgs(enTrafficLights.Red, _RedTime));
        }
        #endregion

        #endregion

        public ctrlTrafficLight()
        {
            InitializeComponent();

            trafficLightOnEventHandlers = new Dictionary<enTrafficLights, Action>
                {
                    { enTrafficLights.Red, OnGreenLightOn},
                    { enTrafficLights.Green, OnOrangeLightOn},
                    { enTrafficLights.Orange, OnRedLightOn}
                };

            trafficLightOffEventHandlers = new Dictionary<enTrafficLights, Action>
                {
                    { enTrafficLights.Red, OnRedLightOFF},
                    { enTrafficLights.Green, OnGreenLightOFF},
                    { enTrafficLights.Orange, OnOrangeLightOFF}
                };
        }

        public void Start()
        {
            _CurrentCountDownValue = GetTrafficLightDuration();
            TrafficLightTimer.Start();
        }

        public void Stop()
        {
            TrafficLightTimer.Stop();
        }

        public int GetTrafficLightDuration()
        {
            switch(_CurrentLight)
            {
                case enTrafficLights.Red:
                    return RedTime;

                case enTrafficLights.Orange:
                    return OrangeTime;

                case enTrafficLights.Green:
                    return GreenTime;

                default:
                    return RedTime;
            }
        }

        private void _ChangeCurrentTrafficLight()
        {
            if (trafficLightOnEventHandlers.TryGetValue(CurrentLight, out var nextTrafficLightOnEventHandler))
            {
                if (trafficLightOffEventHandlers.TryGetValue(CurrentLight, out var currentTrafficLightOffEventHandler))
                {
                    TrafficLightTimer.Stop();
                    currentTrafficLightOffEventHandler.Invoke();
                    TrafficLightTimer.Start();
                }

                nextTrafficLightOnEventHandler.Invoke();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentCountDown.Text = Convert.ToString(--_CurrentCountDownValue);

            if (_CurrentCountDownValue == 0)
                _ChangeCurrentTrafficLight();
        }

        private void lblTimer_ForeColorChanged(object sender, EventArgs e)
        {
            panel1.BorderColor = lblCurrentCountDown.ForeColor;
        }
    }
}
