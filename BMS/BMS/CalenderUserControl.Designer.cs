namespace BMS
{
    partial class CalenderUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalenderUserControl));
            this.PanelCalenderTop = new System.Windows.Forms.Panel();
            this.PictureCalender = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CalenderPanel = new System.Windows.Forms.Panel();
            this.PanelCalenderTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCalender)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCalenderTop
            // 
            this.PanelCalenderTop.Controls.Add(this.PictureCalender);
            this.PanelCalenderTop.Controls.Add(this.label5);
            this.PanelCalenderTop.Location = new System.Drawing.Point(0, 1);
            this.PanelCalenderTop.Name = "PanelCalenderTop";
            this.PanelCalenderTop.Size = new System.Drawing.Size(1150, 55);
            this.PanelCalenderTop.TabIndex = 11;
            this.PanelCalenderTop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCalenderTop_Paint);
            // 
            // PictureCalender
            // 
            this.PictureCalender.Image = ((System.Drawing.Image)(resources.GetObject("PictureCalender.Image")));
            this.PictureCalender.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureCalender.InitialImage")));
            this.PictureCalender.Location = new System.Drawing.Point(18, 19);
            this.PictureCalender.Name = "PictureCalender";
            this.PictureCalender.Size = new System.Drawing.Size(28, 22);
            this.PictureCalender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureCalender.TabIndex = 1;
            this.PictureCalender.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Calender";
            // 
            // CalenderPanel
            // 
            this.CalenderPanel.Location = new System.Drawing.Point(0, 56);
            this.CalenderPanel.Name = "CalenderPanel";
            this.CalenderPanel.Size = new System.Drawing.Size(1150, 670);
            this.CalenderPanel.TabIndex = 12;
            this.CalenderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CalenderPanel_Paint);
            // 
            // CalenderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelCalenderTop);
            this.Controls.Add(this.CalenderPanel);
            this.Name = "CalenderUserControl";
            this.Size = new System.Drawing.Size(1150, 726);
            this.PanelCalenderTop.ResumeLayout(false);
            this.PanelCalenderTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCalender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCalenderTop;
        private System.Windows.Forms.PictureBox PictureCalender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel CalenderPanel;
    }
}
