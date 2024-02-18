using System;
using System.Windows.Forms;
using static TrafficLight.ctrlTrafficLight;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTrafficLight1.Start();
        }


        private void ctrlTrafficLight1_OnGreenLightOn(object sender, TrafficLightEventArgs e)
        {
            MessageBox.Show($"{e.CurrentLight} is on!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ctrlTrafficLight1_OnOrangeLightOn(object sender, TrafficLightEventArgs e)
        {
            MessageBox.Show($"{e.CurrentLight} is on!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ctrlTrafficLight1_OnRedLightOn(object sender, TrafficLightEventArgs e)
        {
            MessageBox.Show($"{e.CurrentLight} is on!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ctrlTrafficLight1_RedLightOFF(object sender, TrafficLightEventArgs e)
        {
            MessageBox.Show($"{e.CurrentLight} will be on right now !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ctrlTrafficLight1_GreenLightOFF(object sender, TrafficLightEventArgs e)
        {
            MessageBox.Show($"{e.CurrentLight} will be on right now !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ctrlTrafficLight1_OrangeLightOFF(object sender, TrafficLightEventArgs e)
        {
            MessageBox.Show($"{e.CurrentLight} will be on right now !","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
