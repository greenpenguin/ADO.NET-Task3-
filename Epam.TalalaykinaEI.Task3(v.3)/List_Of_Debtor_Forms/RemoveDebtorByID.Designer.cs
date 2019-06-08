namespace Epam.TalalaykinaEI.Task3_v._3_.List_Of_Debtor_Forms
{
    partial class RemoveDebtorByID
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
            this.removeHouseButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeHouseButton
            // 
            this.removeHouseButton.Location = new System.Drawing.Point(70, 34);
            this.removeHouseButton.Name = "removeHouseButton";
            this.removeHouseButton.Size = new System.Drawing.Size(101, 24);
            this.removeHouseButton.TabIndex = 5;
            this.removeHouseButton.Text = "Delete";
            this.removeHouseButton.UseVisualStyleBackColor = true;
            this.removeHouseButton.Click += new System.EventHandler(this.removeHouseButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(84, 6);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(163, 22);
            this.IDTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Debtor ID";
            // 
            // RemoveDebtorByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 74);
            this.Controls.Add(this.removeHouseButton);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(271, 119);
            this.MinimumSize = new System.Drawing.Size(271, 119);
            this.Name = "RemoveDebtorByID";
            this.Text = "RemoveDebtorByID";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RemoveDebtorByID_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeHouseButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
    }
}