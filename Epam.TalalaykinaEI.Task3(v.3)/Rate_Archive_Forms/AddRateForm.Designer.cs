namespace Epam.TalalaykinaEI.Task3_v._3_.Rate_Archive_Forms
{
    partial class AddRateForm
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
            this.rateStartDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addRateButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rateStartDateTextBox
            // 
            this.rateStartDateTextBox.Location = new System.Drawing.Point(155, 12);
            this.rateStartDateTextBox.Mask = "00/00/0000 90:00";
            this.rateStartDateTextBox.Name = "rateStartDateTextBox";
            this.rateStartDateTextBox.Size = new System.Drawing.Size(169, 22);
            this.rateStartDateTextBox.TabIndex = 23;
            this.rateStartDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // addRateButton
            // 
            this.addRateButton.Location = new System.Drawing.Point(78, 68);
            this.addRateButton.Name = "addRateButton";
            this.addRateButton.Size = new System.Drawing.Size(149, 26);
            this.addRateButton.TabIndex = 22;
            this.addRateButton.Text = "Add";
            this.addRateButton.UseVisualStyleBackColor = true;
            this.addRateButton.Click += new System.EventHandler(this.addRateButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(155, 40);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(169, 22);
            this.priceTextBox.TabIndex = 21;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Rate Start Date";
            // 
            // AddRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 113);
            this.Controls.Add(this.rateStartDateTextBox);
            this.Controls.Add(this.addRateButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(355, 158);
            this.MinimumSize = new System.Drawing.Size(355, 158);
            this.Name = "AddRateForm";
            this.Text = "AddRateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox rateStartDateTextBox;
        private System.Windows.Forms.Button addRateButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}