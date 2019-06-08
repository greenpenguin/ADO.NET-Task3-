namespace Epam.TalalaykinaEI.Task3_v._3_.Houses_Forms
{
    partial class GetHouseByID
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
            this.getHouseByIDButton = new System.Windows.Forms.Button();
            this.getHouseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "House ID";
            // 
            // houseIDTextBox
            // 
            this.houseIDTextBox.Location = new System.Drawing.Point(109, 21);
            this.houseIDTextBox.Name = "houseIDTextBox";
            this.houseIDTextBox.Size = new System.Drawing.Size(78, 22);
            this.houseIDTextBox.TabIndex = 1;
            this.houseIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.houseIDTextBox_KeyPress);
            // 
            // getHouseByIDButton
            // 
            this.getHouseByIDButton.Location = new System.Drawing.Point(228, 16);
            this.getHouseByIDButton.Name = "getHouseByIDButton";
            this.getHouseByIDButton.Size = new System.Drawing.Size(77, 32);
            this.getHouseByIDButton.TabIndex = 2;
            this.getHouseByIDButton.Text = "Search";
            this.getHouseByIDButton.UseVisualStyleBackColor = true;
            this.getHouseByIDButton.Click += new System.EventHandler(this.getHouseByIDButton_Click);
            // 
            // getHouseLabel
            // 
            this.getHouseLabel.AutoSize = true;
            this.getHouseLabel.Location = new System.Drawing.Point(17, 82);
            this.getHouseLabel.Name = "getHouseLabel";
            this.getHouseLabel.Size = new System.Drawing.Size(117, 17);
            this.getHouseLabel.TabIndex = 3;
            this.getHouseLabel.Text = "text will be here...";
            // 
            // GetHouseByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 134);
            this.Controls.Add(this.getHouseLabel);
            this.Controls.Add(this.getHouseByIDButton);
            this.Controls.Add(this.houseIDTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1104, 179);
            this.MinimumSize = new System.Drawing.Size(1104, 179);
            this.Name = "GetHouseByID";
            this.Text = "GetHouseByID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox houseIDTextBox;
        private System.Windows.Forms.Button getHouseByIDButton;
        private System.Windows.Forms.Label getHouseLabel;
    }
}