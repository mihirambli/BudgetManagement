namespace BMS
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.b2 = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dashboardUserControl1 = new BMS.DashboardUserControl();
            this.calenderUserControl1 = new BMS.CalenderUserControl();
            this.PanelLeft.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelLeft.Controls.Add(this.b2);
            this.PanelLeft.Controls.Add(this.PanelLogo);
            this.PanelLeft.Controls.Add(this.b1);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(200, 729);
            this.PanelLeft.TabIndex = 0;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.b2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.ForeColor = System.Drawing.Color.White;
            this.b2.Location = new System.Drawing.Point(-2, 185);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(200, 59);
            this.b2.TabIndex = 5;
            this.b2.Text = "Statistics";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.DarkOrange;
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Controls.Add(this.label1);
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 55);
            this.PanelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budget Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.b1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.Color.White;
            this.b1.Location = new System.Drawing.Point(-2, 119);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(200, 60);
            this.b1.TabIndex = 4;
            this.b1.Text = "Calender";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.DarkSlateGray;
            this.b0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b0.FlatAppearance.BorderSize = 0;
            this.b0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b0.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.ForeColor = System.Drawing.Color.White;
            this.b0.Location = new System.Drawing.Point(-2, 55);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(199, 71);
            this.b0.TabIndex = 3;
            this.b0.Text = "Dashboard";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // dashboardUserControl1
            // 
            this.dashboardUserControl1.Location = new System.Drawing.Point(193, 0);
            this.dashboardUserControl1.Name = "dashboardUserControl1";
            this.dashboardUserControl1.Size = new System.Drawing.Size(1150, 726);
            this.dashboardUserControl1.TabIndex = 4;
            // 
            // calenderUserControl1
            // 
            this.calenderUserControl1.Location = new System.Drawing.Point(193, 0);
            this.calenderUserControl1.Name = "calenderUserControl1";
            this.calenderUserControl1.Size = new System.Drawing.Size(1150, 726);
            this.calenderUserControl1.TabIndex = 5;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.calenderUserControl1);
            this.Controls.Add(this.dashboardUserControl1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.PanelLeft);
            this.Name = "home";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.home_Load);
            this.PanelLeft.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DashboardUserControl dashboardUserControl1;
        private CalenderUserControl calenderUserControl1;
    }
}

