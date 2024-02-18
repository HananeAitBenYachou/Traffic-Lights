using static TrafficLight.ctrlTrafficLight;

namespace TrafficLight
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlTrafficLight1 = new TrafficLight.ctrlTrafficLight();
            this.SuspendLayout();
            // 
            // ctrlTrafficLight1
            // 
            this.ctrlTrafficLight1.CurrentLight = TrafficLight.ctrlTrafficLight.enTrafficLights.Red;
            this.ctrlTrafficLight1.GreenTime = 10;
            this.ctrlTrafficLight1.Location = new System.Drawing.Point(77, 77);
            this.ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            this.ctrlTrafficLight1.OrangeTime = 5;
            this.ctrlTrafficLight1.RedTime = 15;
            this.ctrlTrafficLight1.Size = new System.Drawing.Size(210, 301);
            this.ctrlTrafficLight1.TabIndex = 0;
            this.ctrlTrafficLight1.RedLightOn += new System.EventHandler<TrafficLight.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_OnRedLightOn);
            this.ctrlTrafficLight1.GreenLightOn += new System.EventHandler<TrafficLight.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_OnGreenLightOn);
            this.ctrlTrafficLight1.OrangeLightOn += new System.EventHandler<TrafficLight.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_OnOrangeLightOn);
            this.ctrlTrafficLight1.RedLightOFF += new System.EventHandler<TrafficLight.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_RedLightOFF);
            this.ctrlTrafficLight1.GreenLightOFF += new System.EventHandler<TrafficLight.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_GreenLightOFF);
            this.ctrlTrafficLight1.OrangeLightOFF += new System.EventHandler<TrafficLight.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_OrangeLightOFF);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 472);
            this.Controls.Add(this.ctrlTrafficLight1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
    }
}

