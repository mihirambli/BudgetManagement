namespace BMS
{
    partial class AddDialogue
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
            this.ButtonAddOk = new System.Windows.Forms.Button();
            this.ButtonAddCancel = new System.Windows.Forms.Button();
            this.TextboxAddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxAddExpense = new System.Windows.Forms.TextBox();
            this.TextboxAddSpent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonAddOk
            // 
            this.ButtonAddOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonAddOk.Location = new System.Drawing.Point(255, 125);
            this.ButtonAddOk.Name = "ButtonAddOk";
            this.ButtonAddOk.Size = new System.Drawing.Size(61, 34);
            this.ButtonAddOk.TabIndex = 0;
            this.ButtonAddOk.Text = "OK";
            this.ButtonAddOk.UseVisualStyleBackColor = true;
            this.ButtonAddOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonAddCancel
            // 
            this.ButtonAddCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAddCancel.Location = new System.Drawing.Point(192, 125);
            this.ButtonAddCancel.Name = "ButtonAddCancel";
            this.ButtonAddCancel.Size = new System.Drawing.Size(57, 33);
            this.ButtonAddCancel.TabIndex = 1;
            this.ButtonAddCancel.Text = "Cancel";
            this.ButtonAddCancel.UseVisualStyleBackColor = true;
            // 
            // TextboxAddName
            // 
            this.TextboxAddName.Location = new System.Drawing.Point(170, 24);
            this.TextboxAddName.Name = "TextboxAddName";
            this.TextboxAddName.Size = new System.Drawing.Size(146, 20);
            this.TextboxAddName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Spent";
            // 
            // TextboxAddExpense
            // 
            this.TextboxAddExpense.Location = new System.Drawing.Point(170, 54);
            this.TextboxAddExpense.Name = "TextboxAddExpense";
            this.TextboxAddExpense.Size = new System.Drawing.Size(146, 20);
            this.TextboxAddExpense.TabIndex = 6;
            // 
            // TextboxAddSpent
            // 
            this.TextboxAddSpent.Location = new System.Drawing.Point(170, 80);
            this.TextboxAddSpent.Name = "TextboxAddSpent";
            this.TextboxAddSpent.Size = new System.Drawing.Size(146, 20);
            this.TextboxAddSpent.TabIndex = 7;
            // 
            // AddDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 171);
            this.Controls.Add(this.TextboxAddSpent);
            this.Controls.Add(this.TextboxAddExpense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxAddName);
            this.Controls.Add(this.ButtonAddCancel);
            this.Controls.Add(this.ButtonAddOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDialogue";
            this.Text = "AddDialogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddOk;
        private System.Windows.Forms.Button ButtonAddCancel;
        private System.Windows.Forms.TextBox TextboxAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxAddExpense;
        private System.Windows.Forms.TextBox TextboxAddSpent;
    }
}