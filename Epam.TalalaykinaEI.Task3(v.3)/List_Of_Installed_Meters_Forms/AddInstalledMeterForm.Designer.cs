namespace Epam.TalalaykinaEI.Task3_v._3_.List_Of_Installed_Meters_Forms
{
    partial class AddInstalledMeterForm
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
            this.maskedDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addMeterButton = new System.Windows.Forms.Button();
            this.meterReadingTextBox = new System.Windows.Forms.TextBox();
            this.meterIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedDateTextBox
            // 
            this.maskedDateTextBox.Location = new System.Drawing.Point(155, 9);
            this.maskedDateTextBox.Mask = "00/00/0000 90:00";
            this.maskedDateTextBox.Name = "maskedDateTextBox";
            this.maskedDateTextBox.Size = new System.Drawing.Size(169, 22);
            this.maskedDateTextBox.TabIndex = 18;
            this.maskedDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // addMeterButton
            // 
            this.addMeterButton.Location = new System.Drawing.Point(94, 104);
            this.addMeterButton.Name = "addMeterButton";
            this.addMeterButton.Size = new System.Drawing.Size(149, 26);
            this.addMeterButton.TabIndex = 17;
            this.addMeterButton.Text = "Add";
            this.addMeterButton.UseVisualStyleBackColor = true;
            this.addMeterButton.Click += new System.EventHandler(this.addMeterButton_Click);
            // 
            // meterReadingTextBox
            // 
            this.meterReadingTextBox.Location = new System.Drawing.Point(155, 37);
            this.meterReadingTextBox.Name = "meterReadingTextBox";
            this.meterReadingTextBox.Size = new System.Drawing.Size(169, 22);
            this.meterReadingTextBox.TabIndex = 16;
            this.meterReadingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.meterReadingTextBox_KeyPress);
            // 
            // meterIDTextBox
            // 
            this.meterIDTextBox.Location = new System.Drawing.Point(155, 65);
            this.meterIDTextBox.Name = "meterIDTextBox";
            this.meterIDTextBox.Size = new System.Drawing.Size(169, 22);
            this.meterIDTextBox.TabIndex = 15;
            this.meterIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.meterIDTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Meter Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Meter ID";
            // 
            // AddInstalledMeterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 147);
            this.Controls.Add(this.maskedDateTextBox);
            this.Controls.Add(this.addMeterButton);
            this.Controls.Add(this.meterReadingTextBox);
            this.Controls.Add(this.meterIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(361, 192);
            this.MinimumSize = new System.Drawing.Size(361, 192);
            this.Name = "AddInstalledMeterForm";
            this.Text = "AddInstalledMeterForm";
            this.Load += new System.EventHandler(this.AddInstalledMeterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedDateTextBox;
        private System.Windows.Forms.Button addMeterButton;
        private System.Windows.Forms.TextBox meterReadingTextBox;
        private System.Windows.Forms.TextBox meterIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}