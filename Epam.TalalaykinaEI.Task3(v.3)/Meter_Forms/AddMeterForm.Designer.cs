namespace Epam.TalalaykinaEI.Task3_v._3_.Meter_Forms
{
    partial class AddMeterForm
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
            this.InstallationDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addMeterButton = new System.Windows.Forms.Button();
            this.utilitieIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NextCheckDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstallationDateTextBox
            // 
            this.InstallationDateTextBox.Location = new System.Drawing.Point(149, 12);
            this.InstallationDateTextBox.Mask = "00/00/0000 90:00";
            this.InstallationDateTextBox.Name = "InstallationDateTextBox";
            this.InstallationDateTextBox.Size = new System.Drawing.Size(169, 22);
            this.InstallationDateTextBox.TabIndex = 23;
            this.InstallationDateTextBox.ValidatingType = typeof(System.DateTime);
            this.InstallationDateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InstallationDateTextBox_KeyPress);
            // 
            // addMeterButton
            // 
            this.addMeterButton.Location = new System.Drawing.Point(88, 107);
            this.addMeterButton.Name = "addMeterButton";
            this.addMeterButton.Size = new System.Drawing.Size(149, 26);
            this.addMeterButton.TabIndex = 22;
            this.addMeterButton.Text = "Add";
            this.addMeterButton.UseVisualStyleBackColor = true;
            this.addMeterButton.Click += new System.EventHandler(this.addMeterButton_Click);
            // 
            // utilitieIDTextBox
            // 
            this.utilitieIDTextBox.Location = new System.Drawing.Point(149, 68);
            this.utilitieIDTextBox.Name = "utilitieIDTextBox";
            this.utilitieIDTextBox.Size = new System.Drawing.Size(169, 22);
            this.utilitieIDTextBox.TabIndex = 21;
            this.utilitieIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.utilitieIDTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Installation Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Utilitie ID";
            // 
            // NextCheckDateTextBox
            // 
            this.NextCheckDateTextBox.Location = new System.Drawing.Point(149, 40);
            this.NextCheckDateTextBox.Mask = "00/00/0000 90:00";
            this.NextCheckDateTextBox.Name = "NextCheckDateTextBox";
            this.NextCheckDateTextBox.Size = new System.Drawing.Size(169, 22);
            this.NextCheckDateTextBox.TabIndex = 25;
            this.NextCheckDateTextBox.ValidatingType = typeof(System.DateTime);
            this.NextCheckDateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NextCheckDateTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Next Check Date";
            // 
            // AddMeterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 159);
            this.Controls.Add(this.NextCheckDateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InstallationDateTextBox);
            this.Controls.Add(this.addMeterButton);
            this.Controls.Add(this.utilitieIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(348, 204);
            this.MinimumSize = new System.Drawing.Size(348, 204);
            this.Name = "AddMeterForm";
            this.Text = "AddMeterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox InstallationDateTextBox;
        private System.Windows.Forms.Button addMeterButton;
        private System.Windows.Forms.TextBox utilitieIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox NextCheckDateTextBox;
        private System.Windows.Forms.Label label1;
    }
}