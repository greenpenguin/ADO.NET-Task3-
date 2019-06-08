namespace Epam.TalalaykinaEI.Task3_v._3_
{
    partial class AddOwnerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.addOwnerButton = new System.Windows.Forms.Button();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(414, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(12, 80);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(414, 22);
            this.secondNameTextBox.TabIndex = 1;
            this.secondNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.secondNameTextBox_KeyDown);
            this.secondNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondNameTextBox_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(15, 60);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(97, 17);
            this.secondNameLabel.TabIndex = 4;
            this.secondNameLabel.Text = "Second Name";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(15, 120);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneNumberLabel.TabIndex = 5;
            this.phoneNumberLabel.Text = "Phone Number";
            this.phoneNumberLabel.Click += new System.EventHandler(this.phoneNumberLabel_Click);
            // 
            // addOwnerButton
            // 
            this.addOwnerButton.Location = new System.Drawing.Point(164, 171);
            this.addOwnerButton.Name = "addOwnerButton";
            this.addOwnerButton.Size = new System.Drawing.Size(75, 23);
            this.addOwnerButton.TabIndex = 6;
            this.addOwnerButton.Text = "Add";
            this.addOwnerButton.UseVisualStyleBackColor = true;
            this.addOwnerButton.Click += new System.EventHandler(this.addOwnerButton_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(15, 140);
            this.phoneNumberTextBox.Mask = "(999) 000-0000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(411, 22);
            this.phoneNumberTextBox.TabIndex = 7;
            // 
            // AddOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 212);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.addOwnerButton);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.MaximumSize = new System.Drawing.Size(460, 257);
            this.MinimumSize = new System.Drawing.Size(460, 257);
            this.Name = "AddOwnerForm";
            this.Text = "Add Owner";
            this.Load += new System.EventHandler(this.AddOwnerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Button addOwnerButton;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
    }
}

