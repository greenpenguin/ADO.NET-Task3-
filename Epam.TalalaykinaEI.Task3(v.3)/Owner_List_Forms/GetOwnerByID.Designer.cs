namespace Epam.TalalaykinaEI.Task3_v._3_
{
    partial class GetOwnerByID
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
            this.ownerIDLabel = new System.Windows.Forms.Label();
            this.getOwnerLabel = new System.Windows.Forms.Label();
            this.ownerIDTextBox = new System.Windows.Forms.TextBox();
            this.ownerIDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ownerIDLabel
            // 
            this.ownerIDLabel.AutoSize = true;
            this.ownerIDLabel.Location = new System.Drawing.Point(13, 13);
            this.ownerIDLabel.Name = "ownerIDLabel";
            this.ownerIDLabel.Size = new System.Drawing.Size(66, 17);
            this.ownerIDLabel.TabIndex = 0;
            this.ownerIDLabel.Text = "Owner ID";
            // 
            // getOwnerLabel
            // 
            this.getOwnerLabel.AutoSize = true;
            this.getOwnerLabel.Location = new System.Drawing.Point(13, 62);
            this.getOwnerLabel.Name = "getOwnerLabel";
            this.getOwnerLabel.Size = new System.Drawing.Size(117, 17);
            this.getOwnerLabel.TabIndex = 1;
            this.getOwnerLabel.Text = "text will be here...";
            // 
            // ownerIDTextBox
            // 
            this.ownerIDTextBox.Location = new System.Drawing.Point(85, 13);
            this.ownerIDTextBox.Name = "ownerIDTextBox";
            this.ownerIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.ownerIDTextBox.TabIndex = 3;
            this.ownerIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ownerIDTextBox_KeyPress);
            // 
            // ownerIDButton
            // 
            this.ownerIDButton.Location = new System.Drawing.Point(191, 13);
            this.ownerIDButton.Name = "ownerIDButton";
            this.ownerIDButton.Size = new System.Drawing.Size(75, 23);
            this.ownerIDButton.TabIndex = 4;
            this.ownerIDButton.Text = "Search";
            this.ownerIDButton.UseVisualStyleBackColor = true;
            this.ownerIDButton.Click += new System.EventHandler(this.ownerIDButton_Click);
            // 
            // GetOwnerByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 134);
            this.Controls.Add(this.ownerIDButton);
            this.Controls.Add(this.ownerIDTextBox);
            this.Controls.Add(this.getOwnerLabel);
            this.Controls.Add(this.ownerIDLabel);
            this.MaximumSize = new System.Drawing.Size(1104, 179);
            this.MinimumSize = new System.Drawing.Size(1104, 179);
            this.Name = "GetOwnerByID";
            this.Text = "Get Owner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ownerIDLabel;
        private System.Windows.Forms.Label getOwnerLabel;
        private System.Windows.Forms.TextBox ownerIDTextBox;
        private System.Windows.Forms.Button ownerIDButton;
    }
}