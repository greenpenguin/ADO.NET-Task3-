namespace Epam.TalalaykinaEI.Task3_v._3_.UserForms
{
    partial class InvoiceInformationForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.paidAmLabel = new System.Windows.Forms.Label();
            this.totalAmLabel = new System.Windows.Forms.Label();
            this.invoiceLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.accountIDComboBox = new System.Windows.Forms.ComboBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.needToPayLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paid amount";
            // 
            // paidAmLabel
            // 
            this.paidAmLabel.AutoSize = true;
            this.paidAmLabel.Location = new System.Drawing.Point(150, 87);
            this.paidAmLabel.Name = "paidAmLabel";
            this.paidAmLabel.Size = new System.Drawing.Size(46, 17);
            this.paidAmLabel.TabIndex = 5;
            this.paidAmLabel.Text = "label4";
            // 
            // totalAmLabel
            // 
            this.totalAmLabel.AutoSize = true;
            this.totalAmLabel.Location = new System.Drawing.Point(150, 54);
            this.totalAmLabel.Name = "totalAmLabel";
            this.totalAmLabel.Size = new System.Drawing.Size(46, 17);
            this.totalAmLabel.TabIndex = 4;
            this.totalAmLabel.Text = "label5";
            // 
            // invoiceLabel
            // 
            this.invoiceLabel.AutoSize = true;
            this.invoiceLabel.Location = new System.Drawing.Point(150, 20);
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Size = new System.Drawing.Size(46, 17);
            this.invoiceLabel.TabIndex = 3;
            this.invoiceLabel.Text = "label6";
            this.invoiceLabel.Click += new System.EventHandler(this.invoiceLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Accounts ID";
            // 
            // accountIDComboBox
            // 
            this.accountIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountIDComboBox.FormattingEnabled = true;
            this.accountIDComboBox.Location = new System.Drawing.Point(153, 159);
            this.accountIDComboBox.Name = "accountIDComboBox";
            this.accountIDComboBox.Size = new System.Drawing.Size(220, 24);
            this.accountIDComboBox.TabIndex = 7;
            this.accountIDComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(153, 189);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(220, 22);
            this.infoButton.TabIndex = 8;
            this.infoButton.Text = "More information";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // needToPayLabel
            // 
            this.needToPayLabel.AutoSize = true;
            this.needToPayLabel.Location = new System.Drawing.Point(150, 123);
            this.needToPayLabel.Name = "needToPayLabel";
            this.needToPayLabel.Size = new System.Drawing.Size(46, 17);
            this.needToPayLabel.TabIndex = 10;
            this.needToPayLabel.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Need to pay";
            // 
            // InvoiceInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 223);
            this.Controls.Add(this.needToPayLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.accountIDComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.paidAmLabel);
            this.Controls.Add(this.totalAmLabel);
            this.Controls.Add(this.invoiceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(406, 268);
            this.MinimumSize = new System.Drawing.Size(406, 268);
            this.Name = "InvoiceInformationForm";
            this.Text = "InvoiceInformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label paidAmLabel;
        private System.Windows.Forms.Label totalAmLabel;
        private System.Windows.Forms.Label invoiceLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox accountIDComboBox;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label needToPayLabel;
        private System.Windows.Forms.Label label9;
    }
}