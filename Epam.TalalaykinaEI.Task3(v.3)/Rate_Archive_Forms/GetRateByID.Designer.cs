namespace Epam.TalalaykinaEI.Task3_v._3_.Rate_Archive_Forms
{
    partial class GetRateByID
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
            this.searchButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(240, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(68, 27);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(18, 72);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(117, 17);
            this.textLabel.TabIndex = 6;
            this.textLabel.Text = "text will be here...";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(97, 22);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(117, 22);
            this.IDtextBox.TabIndex = 5;
            this.IDtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDtextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rate ID";
            // 
            // GetRateByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 134);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1104, 179);
            this.MinimumSize = new System.Drawing.Size(1104, 179);
            this.Name = "GetRateByID";
            this.Text = "GetRateByID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label1;
    }
}