namespace Epam.TalalaykinaEI.Task3_v._3_.Account_Forms
{
    partial class AddAccountForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.utilitieIDTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.paidAmountTextBox = new System.Windows.Forms.TextBox();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.maskedDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.overpaymentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utilitie ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Paid Amount";
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(164, 20);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(169, 22);
            this.invoiceNumberTextBox.TabIndex = 5;
            this.invoiceNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.invoiceNumberTextBox_KeyPress);
            // 
            // utilitieIDTextBox
            // 
            this.utilitieIDTextBox.Location = new System.Drawing.Point(164, 58);
            this.utilitieIDTextBox.Name = "utilitieIDTextBox";
            this.utilitieIDTextBox.Size = new System.Drawing.Size(169, 22);
            this.utilitieIDTextBox.TabIndex = 6;
            this.utilitieIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.utilitieIDTextBox_KeyPress);
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(164, 151);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(169, 22);
            this.totalAmountTextBox.TabIndex = 8;
            this.totalAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalAmountTextBox_KeyPress);
            // 
            // paidAmountTextBox
            // 
            this.paidAmountTextBox.Location = new System.Drawing.Point(164, 189);
            this.paidAmountTextBox.Name = "paidAmountTextBox";
            this.paidAmountTextBox.Size = new System.Drawing.Size(169, 22);
            this.paidAmountTextBox.TabIndex = 9;
            this.paidAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paidAmountTextBox_KeyPress);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(103, 272);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(149, 26);
            this.addAccountButton.TabIndex = 10;
            this.addAccountButton.Text = "Add";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // maskedDateTextBox
            // 
            this.maskedDateTextBox.Location = new System.Drawing.Point(164, 103);
            this.maskedDateTextBox.Mask = "00/00/0000 90:00";
            this.maskedDateTextBox.Name = "maskedDateTextBox";
            this.maskedDateTextBox.Size = new System.Drawing.Size(169, 22);
            this.maskedDateTextBox.TabIndex = 11;
            this.maskedDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // overpaymentLabel
            // 
            this.overpaymentLabel.AutoSize = true;
            this.overpaymentLabel.Location = new System.Drawing.Point(19, 233);
            this.overpaymentLabel.Name = "overpaymentLabel";
            this.overpaymentLabel.Size = new System.Drawing.Size(0, 17);
            this.overpaymentLabel.TabIndex = 12;
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 310);
            this.Controls.Add(this.overpaymentLabel);
            this.Controls.Add(this.maskedDateTextBox);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.paidAmountTextBox);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.utilitieIDTextBox);
            this.Controls.Add(this.invoiceNumberTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(382, 355);
            this.MinimumSize = new System.Drawing.Size(382, 355);
            this.Name = "AddAccountForm";
            this.Text = "AddAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.TextBox utilitieIDTextBox;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.TextBox paidAmountTextBox;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.MaskedTextBox maskedDateTextBox;
        private System.Windows.Forms.Label overpaymentLabel;
    }
}