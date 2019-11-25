namespace BMS
{
    partial class UpdateDialogue
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
            this.TextboxUpdateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxUpdateExpense = new System.Windows.Forms.TextBox();
            this.TextboxUpdateSpent = new System.Windows.Forms.TextBox();
            this.ButtonUpdateOk = new System.Windows.Forms.Button();
            this.ButtonUpdateCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextboxUpdateName
            // 
            this.TextboxUpdateName.Location = new System.Drawing.Point(172, 27);
            this.TextboxUpdateName.Name = "TextboxUpdateName";
            this.TextboxUpdateName.Size = new System.Drawing.Size(146, 20);
            this.TextboxUpdateName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Spent";
            // 
            // TextboxUpdateExpense
            // 
            this.TextboxUpdateExpense.Location = new System.Drawing.Point(172, 57);
            this.TextboxUpdateExpense.Name = "TextboxUpdateExpense";
            this.TextboxUpdateExpense.Size = new System.Drawing.Size(146, 20);
            this.TextboxUpdateExpense.TabIndex = 12;
            // 
            // TextboxUpdateSpent
            // 
            this.TextboxUpdateSpent.Location = new System.Drawing.Point(172, 83);
            this.TextboxUpdateSpent.Name = "TextboxUpdateSpent";
            this.TextboxUpdateSpent.Size = new System.Drawing.Size(146, 20);
            this.TextboxUpdateSpent.TabIndex = 13;
            // 
            // ButtonUpdateOk
            // 
            this.ButtonUpdateOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonUpdateOk.Location = new System.Drawing.Point(257, 125);
            this.ButtonUpdateOk.Name = "ButtonUpdateOk";
            this.ButtonUpdateOk.Size = new System.Drawing.Size(61, 34);
            this.ButtonUpdateOk.TabIndex = 14;
            this.ButtonUpdateOk.Text = "OK";
            this.ButtonUpdateOk.UseVisualStyleBackColor = true;
            // 
            // ButtonUpdateCancel
            // 
            this.ButtonUpdateCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonUpdateCancel.Location = new System.Drawing.Point(194, 125);
            this.ButtonUpdateCancel.Name = "ButtonUpdateCancel";
            this.ButtonUpdateCancel.Size = new System.Drawing.Size(57, 33);
            this.ButtonUpdateCancel.TabIndex = 15;
            this.ButtonUpdateCancel.Text = "Cancel";
            this.ButtonUpdateCancel.UseVisualStyleBackColor = true;
            // 
            // UpdateDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 171);
            this.Controls.Add(this.ButtonUpdateCancel);
            this.Controls.Add(this.ButtonUpdateOk);
            this.Controls.Add(this.TextboxUpdateSpent);
            this.Controls.Add(this.TextboxUpdateExpense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxUpdateName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDialogue";
            this.Text = "UpdateDialogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxUpdateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxUpdateExpense;
        private System.Windows.Forms.TextBox TextboxUpdateSpent;
        private System.Windows.Forms.Button ButtonUpdateOk;
        private System.Windows.Forms.Button ButtonUpdateCancel;
    }
}