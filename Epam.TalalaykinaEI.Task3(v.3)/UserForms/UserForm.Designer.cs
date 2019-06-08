namespace Epam.TalalaykinaEI.Task3_v._3_
{
    partial class UserForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.apartmentComboBox = new System.Windows.Forms.ComboBox();
            this.invoicesComboBox = new System.Windows.Forms.ComboBox();
            this.debtComboBox = new System.Windows.Forms.ComboBox();
            this.apAddButton = new System.Windows.Forms.Button();
            this.invButton = new System.Windows.Forms.Button();
            this.debtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Your apartments addresses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Second Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Debt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Invoice numbers";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(244, 21);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(46, 17);
            this.IDLabel.TabIndex = 6;
            this.IDLabel.Text = "label7";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(244, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 17);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "label8";
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.Location = new System.Drawing.Point(244, 83);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(54, 17);
            this.sNameLabel.TabIndex = 8;
            this.sNameLabel.Text = "label10";
            // 
            // apartmentComboBox
            // 
            this.apartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apartmentComboBox.FormattingEnabled = true;
            this.apartmentComboBox.Location = new System.Drawing.Point(247, 117);
            this.apartmentComboBox.Name = "apartmentComboBox";
            this.apartmentComboBox.Size = new System.Drawing.Size(412, 24);
            this.apartmentComboBox.TabIndex = 9;
            this.apartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.apartmentComboBox_SelectedIndexChanged);
            // 
            // invoicesComboBox
            // 
            this.invoicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invoicesComboBox.FormattingEnabled = true;
            this.invoicesComboBox.Location = new System.Drawing.Point(247, 159);
            this.invoicesComboBox.Name = "invoicesComboBox";
            this.invoicesComboBox.Size = new System.Drawing.Size(412, 24);
            this.invoicesComboBox.TabIndex = 10;
            this.invoicesComboBox.SelectedIndexChanged += new System.EventHandler(this.invoicesComboBox_SelectedIndexChanged);
            // 
            // debtComboBox
            // 
            this.debtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.debtComboBox.FormattingEnabled = true;
            this.debtComboBox.Location = new System.Drawing.Point(247, 196);
            this.debtComboBox.Name = "debtComboBox";
            this.debtComboBox.Size = new System.Drawing.Size(412, 24);
            this.debtComboBox.TabIndex = 11;
            this.debtComboBox.SelectedIndexChanged += new System.EventHandler(this.debtComboBox_SelectedIndexChanged);
            // 
            // apAddButton
            // 
            this.apAddButton.Location = new System.Drawing.Point(673, 117);
            this.apAddButton.Name = "apAddButton";
            this.apAddButton.Size = new System.Drawing.Size(130, 24);
            this.apAddButton.TabIndex = 12;
            this.apAddButton.Text = "More information";
            this.apAddButton.UseVisualStyleBackColor = true;
            this.apAddButton.Click += new System.EventHandler(this.apAddButton_Click);
            // 
            // invButton
            // 
            this.invButton.Location = new System.Drawing.Point(673, 159);
            this.invButton.Name = "invButton";
            this.invButton.Size = new System.Drawing.Size(130, 24);
            this.invButton.TabIndex = 13;
            this.invButton.Text = "More information";
            this.invButton.UseVisualStyleBackColor = true;
            this.invButton.Click += new System.EventHandler(this.invButton_Click);
            // 
            // debtButton
            // 
            this.debtButton.Location = new System.Drawing.Point(673, 195);
            this.debtButton.Name = "debtButton";
            this.debtButton.Size = new System.Drawing.Size(130, 24);
            this.debtButton.TabIndex = 14;
            this.debtButton.Text = "More information";
            this.debtButton.UseVisualStyleBackColor = true;
            this.debtButton.Click += new System.EventHandler(this.debtButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 243);
            this.Controls.Add(this.debtButton);
            this.Controls.Add(this.invButton);
            this.Controls.Add(this.apAddButton);
            this.Controls.Add(this.debtComboBox);
            this.Controls.Add(this.invoicesComboBox);
            this.Controls.Add(this.apartmentComboBox);
            this.Controls.Add(this.sNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(844, 288);
            this.MinimumSize = new System.Drawing.Size(844, 288);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.ComboBox apartmentComboBox;
        private System.Windows.Forms.ComboBox invoicesComboBox;
        private System.Windows.Forms.ComboBox debtComboBox;
        private System.Windows.Forms.Button apAddButton;
        private System.Windows.Forms.Button invButton;
        private System.Windows.Forms.Button debtButton;
    }
}