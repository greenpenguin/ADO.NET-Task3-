namespace Epam.TalalaykinaEI.Task3_v._3_.Houses_Forms
{
    partial class AddHouseForm
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
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addHouseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(12, 29);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(230, 22);
            this.addressTextBox.TabIndex = 1;
            // 
            // addHouseButton
            // 
            this.addHouseButton.Location = new System.Drawing.Point(62, 57);
            this.addHouseButton.Name = "addHouseButton";
            this.addHouseButton.Size = new System.Drawing.Size(127, 24);
            this.addHouseButton.TabIndex = 2;
            this.addHouseButton.Text = "Add";
            this.addHouseButton.UseVisualStyleBackColor = true;
            this.addHouseButton.Click += new System.EventHandler(this.addHouseButton_Click);
            // 
            // AddHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 96);
            this.Controls.Add(this.addHouseButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 141);
            this.MinimumSize = new System.Drawing.Size(300, 141);
            this.Name = "AddHouseForm";
            this.Text = "AddHouseForm";
            this.Load += new System.EventHandler(this.AddHouseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button addHouseButton;
    }
}