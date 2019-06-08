namespace Epam.TalalaykinaEI.Task3_v._3_.List_Of_Debtor_Forms
{
    partial class AddDebtorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ownerIDTextBox = new System.Windows.Forms.TextBox();
            this.utilitieIDTextBox = new System.Windows.Forms.TextBox();
            this.owAmTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Owner ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Utilitie ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Owed Amount";
            // 
            // ownerIDTextBox
            // 
            this.ownerIDTextBox.Location = new System.Drawing.Point(147, 23);
            this.ownerIDTextBox.Name = "ownerIDTextBox";
            this.ownerIDTextBox.Size = new System.Drawing.Size(109, 22);
            this.ownerIDTextBox.TabIndex = 4;
            this.ownerIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ownerIDTextBox_KeyPress);
            // 
            // utilitieIDTextBox
            // 
            this.utilitieIDTextBox.Location = new System.Drawing.Point(147, 51);
            this.utilitieIDTextBox.Name = "utilitieIDTextBox";
            this.utilitieIDTextBox.Size = new System.Drawing.Size(109, 22);
            this.utilitieIDTextBox.TabIndex = 5;
            this.utilitieIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.utilitieIDTextBox_KeyPress);
            // 
            // owAmTextBox
            // 
            this.owAmTextBox.Location = new System.Drawing.Point(146, 79);
            this.owAmTextBox.Name = "owAmTextBox";
            this.owAmTextBox.Size = new System.Drawing.Size(110, 22);
            this.owAmTextBox.TabIndex = 6;
            this.owAmTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.owAmTextBox_KeyPress);
            // 
            // AddDebtorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 182);
            this.Controls.Add(this.owAmTextBox);
            this.Controls.Add(this.utilitieIDTextBox);
            this.Controls.Add(this.ownerIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(284, 227);
            this.MinimumSize = new System.Drawing.Size(284, 227);
            this.Name = "AddDebtorForm";
            this.Text = "AddDebtorForm";
            this.Load += new System.EventHandler(this.AddDebtorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ownerIDTextBox;
        private System.Windows.Forms.TextBox utilitieIDTextBox;
        private System.Windows.Forms.TextBox owAmTextBox;
    }
}