namespace Epam.TalalaykinaEI.Task3_v._3_.UserForms
{
    partial class DebtInfoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.owAmLabel = new System.Windows.Forms.Label();
            this.uTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilitie type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Owed amount";
            // 
            // owAmLabel
            // 
            this.owAmLabel.AutoSize = true;
            this.owAmLabel.Location = new System.Drawing.Point(134, 57);
            this.owAmLabel.Name = "owAmLabel";
            this.owAmLabel.Size = new System.Drawing.Size(46, 17);
            this.owAmLabel.TabIndex = 3;
            this.owAmLabel.Text = "label3";
            // 
            // uTypeLabel
            // 
            this.uTypeLabel.AutoSize = true;
            this.uTypeLabel.Location = new System.Drawing.Point(134, 19);
            this.uTypeLabel.Name = "uTypeLabel";
            this.uTypeLabel.Size = new System.Drawing.Size(46, 17);
            this.uTypeLabel.TabIndex = 2;
            this.uTypeLabel.Text = "label4";
            // 
            // DebtInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 106);
            this.Controls.Add(this.owAmLabel);
            this.Controls.Add(this.uTypeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(322, 151);
            this.MinimumSize = new System.Drawing.Size(322, 151);
            this.Name = "DebtInfoForm";
            this.Text = "DebtInfoForm";
            this.Load += new System.EventHandler(this.DebtInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label owAmLabel;
        private System.Windows.Forms.Label uTypeLabel;
    }
}