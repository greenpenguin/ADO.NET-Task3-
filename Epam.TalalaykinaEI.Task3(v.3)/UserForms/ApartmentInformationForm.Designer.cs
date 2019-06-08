namespace Epam.TalalaykinaEI.Task3_v._3_.UserForms
{
    partial class ApartmentInformationForm
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
            this.appAreaLabel = new System.Windows.Forms.Label();
            this.numOfPrscrLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apartment area";
            // 
            // appAreaLabel
            // 
            this.appAreaLabel.AutoSize = true;
            this.appAreaLabel.Location = new System.Drawing.Point(207, 16);
            this.appAreaLabel.Name = "appAreaLabel";
            this.appAreaLabel.Size = new System.Drawing.Size(46, 17);
            this.appAreaLabel.TabIndex = 1;
            this.appAreaLabel.Text = "label2";
            // 
            // numOfPrscrLabel
            // 
            this.numOfPrscrLabel.AutoSize = true;
            this.numOfPrscrLabel.Location = new System.Drawing.Point(207, 57);
            this.numOfPrscrLabel.Name = "numOfPrscrLabel";
            this.numOfPrscrLabel.Size = new System.Drawing.Size(46, 17);
            this.numOfPrscrLabel.TabIndex = 3;
            this.numOfPrscrLabel.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of prescribed";
            // 
            // ApartmentInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 90);
            this.Controls.Add(this.numOfPrscrLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appAreaLabel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(350, 135);
            this.MinimumSize = new System.Drawing.Size(350, 135);
            this.Name = "ApartmentInformationForm";
            this.Text = "ApartmentInformationForm";
            this.Load += new System.EventHandler(this.ApartmentInformationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label appAreaLabel;
        private System.Windows.Forms.Label numOfPrscrLabel;
        private System.Windows.Forms.Label label4;
    }
}