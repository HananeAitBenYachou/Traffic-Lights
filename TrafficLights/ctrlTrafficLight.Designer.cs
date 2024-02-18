namespace TrafficLight
{
    partial class ctrlTrafficLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbTrafficLight = new System.Windows.Forms.PictureBox();
            this.lblCurrentCountDown = new System.Windows.Forms.Label();
            this.TrafficLightTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTrafficLight
            // 
            this.pbTrafficLight.BackColor = System.Drawing.Color.White;
            this.pbTrafficLight.Image = global::TrafficLight.Properties.Resources.Red;
            this.pbTrafficLight.Location = new System.Drawing.Point(47, 28);
            this.pbTrafficLight.Name = "pbTrafficLight";
            this.pbTrafficLight.Size = new System.Drawing.Size(125, 222);
            this.pbTrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrafficLight.TabIndex = 0;
            this.pbTrafficLight.TabStop = false;
            // 
            // lblCurrentCountDown
            // 
            this.lblCurrentCountDown.AutoSize = true;
            this.lblCurrentCountDown.BackColor = System.Drawing.Color.White;
            this.lblCurrentCountDown.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Bold);
            this.lblCurrentCountDown.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentCountDown.Location = new System.Drawing.Point(89, 253);
            this.lblCurrentCountDown.Name = "lblCurrentCountDown";
            this.lblCurrentCountDown.Size = new System.Drawing.Size(33, 34);
            this.lblCurrentCountDown.TabIndex = 1;
            this.lblCurrentCountDown.Text = "??";
            this.lblCurrentCountDown.ForeColorChanged += new System.EventHandler(this.lblTimer_ForeColorChanged);
            // 
            // TrafficLightTimer
            // 
            this.TrafficLightTimer.Interval = 1000;
            this.TrafficLightTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderColor = System.Drawing.Color.Red;
            this.panel1.BorderRadius = 1;
            this.panel1.BorderThickness = 3;
            this.panel1.Controls.Add(this.lblCurrentCountDown);
            this.panel1.Controls.Add(this.pbTrafficLight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 300);
            this.panel1.TabIndex = 2;
            // 
            // ctrlTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctrlTrafficLight";
            this.Size = new System.Drawing.Size(209, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrafficLight;
        private System.Windows.Forms.Label lblCurrentCountDown;
        private System.Windows.Forms.Timer TrafficLightTimer;
        private Guna.UI2.WinForms.Guna2GradientPanel panel1;
    }
}
