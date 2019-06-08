namespace Epam.TalalaykinaEI.Task3_v._3_.Houses_Forms
{
    partial class RemoveHouseByID
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
            this.label1 = new System.Windows.Forms.Label();
            this.houseIDTextBox = new System.Windows.Forms.TextBox();
            this.removeHouseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "House ID";
            // 
            // houseIDTextBox
            // 
            this.houseIDTextBox.Location = new System.Drawing.Point(84, 12);
            this.houseIDTextBox.Name = "houseIDTextBox";
            this.houseIDTextBox.Size = new System.Drawing.Size(163, 22);
            this.houseIDTextBox.TabIndex = 1;
            this.houseIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.houseIDTextBox_KeyPress);
            // 
            // removeHouseButton
            // 
            this.removeHouseButton.Location = new System.Drawing.Point(84, 40);
            this.removeHouseButton.Name = "removeHouseButton";
            this.removeHouseButton.Size = new System.Drawing.Size(101, 24);
            this.removeHouseButton.TabIndex = 2;
            this.removeHouseButton.Text = "Delete";
            this.removeHouseButton.UseVisualStyleBackColor = true;
            this.removeHouseButton.Click += new System.EventHandler(this.removeHouseButton_Click);
            // 
            // RemoveHouseByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 79);
            this.Controls.Add(this.removeHouseButton);
            this.Controls.Add(this.houseIDTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(283, 124);
            this.MinimumSize = new System.Drawing.Size(283, 124);
            this.Name = "RemoveHouseByID";
            this.Text = "RemoveHouseByID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox houseIDTextBox;
        private System.Windows.Forms.Button removeHouseButton;
    }
}