namespace Epam.TalalaykinaEI.Task3_v._3_.Invoice_Forms
{
    partial class AddInvoiceForm
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
            this.addAccountButton = new System.Windows.Forms.Button();
            this.paidAmountTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.ownerIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.overpaymentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedDateTextBox
            // 
            this.maskedDateTextBox.Location = new System.Drawing.Point(160, 59);
            this.maskedDateTextBox.Mask = "00/00/0000 90:00";
            this.maskedDateTextBox.Name = "maskedDateTextBox";
            this.maskedDateTextBox.Size = new System.Drawing.Size(169, 22);
            this.maskedDateTextBox.TabIndex = 20;
            this.maskedDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(95, 212);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(149, 26);
            this.addAccountButton.TabIndex = 19;
            this.addAccountButton.Text = "Add";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // paidAmountTextBox
            // 
            this.paidAmountTextBox.Location = new System.Drawing.Point(160, 145);
            this.paidAmountTextBox.Name = "paidAmountTextBox";
            this.paidAmountTextBox.Size = new System.Drawing.Size(169, 22);
            this.paidAmountTextBox.TabIndex = 18;
            this.paidAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paidAmountTextBox_KeyPress);
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(160, 107);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(169, 22);
            this.totalAmountTextBox.TabIndex = 17;
            this.totalAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalAmountTextBox_KeyPress);
            // 
            // ownerIDTextBox
            // 
            this.ownerIDTextBox.Location = new System.Drawing.Point(160, 14);
            this.ownerIDTextBox.Name = "ownerIDTextBox";
            this.ownerIDTextBox.Size = new System.Drawing.Size(169, 22);
            this.ownerIDTextBox.TabIndex = 16;
            this.ownerIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ownerIDTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Paid Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Invoice Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Owner ID";
            // 
            // overpaymentLabel
            // 
            this.overpaymentLabel.AutoSize = true;
            this.overpaymentLabel.Location = new System.Drawing.Point(17, 179);
            this.overpaymentLabel.Name = "overpaymentLabel";
            this.overpaymentLabel.Size = new System.Drawing.Size(0, 17);
            this.overpaymentLabel.TabIndex = 21;
            // 
            // AddInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 246);
            this.Controls.Add(this.overpaymentLabel);
            this.Controls.Add(this.maskedDateTextBox);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.paidAmountTextBox);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.ownerIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(366, 291);
            this.MinimumSize = new System.Drawing.Size(366, 291);
            this.Name = "AddInvoiceForm";
            this.Text = "AddInvoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedDateTextBox;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.TextBox paidAmountTextBox;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.TextBox ownerIDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label overpaymentLabel;
    }
}