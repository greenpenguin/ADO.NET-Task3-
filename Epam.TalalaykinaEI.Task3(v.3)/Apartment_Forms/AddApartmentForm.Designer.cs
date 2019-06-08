namespace Epam.TalalaykinaEI.Task3_v._3_.Apartment_Forms
{
    partial class AddApartmentForm
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
            this.apartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.houseIDTextBox = new System.Windows.Forms.TextBox();
            this.apSqTextBox = new System.Windows.Forms.TextBox();
            this.ownerIDTextBox = new System.Windows.Forms.TextBox();
            this.numOfPrescrtextBox = new System.Windows.Forms.TextBox();
            this.addApartmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apartment Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "House ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apartment Square";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Owner ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of prescribed";
            // 
            // apartmentNumberTextBox
            // 
            this.apartmentNumberTextBox.Location = new System.Drawing.Point(187, 22);
            this.apartmentNumberTextBox.Name = "apartmentNumberTextBox";
            this.apartmentNumberTextBox.Size = new System.Drawing.Size(135, 22);
            this.apartmentNumberTextBox.TabIndex = 5;
            this.apartmentNumberTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.apartmentNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apartmentNumberTextBox_KeyPress);
            // 
            // houseIDTextBox
            // 
            this.houseIDTextBox.Location = new System.Drawing.Point(187, 50);
            this.houseIDTextBox.Name = "houseIDTextBox";
            this.houseIDTextBox.Size = new System.Drawing.Size(135, 22);
            this.houseIDTextBox.TabIndex = 6;
            this.houseIDTextBox.TextChanged += new System.EventHandler(this.houseIDTextBox_TextChanged);
            this.houseIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.houseIDTextBox_KeyPress);
            // 
            // apSqTextBox
            // 
            this.apSqTextBox.Location = new System.Drawing.Point(187, 78);
            this.apSqTextBox.Name = "apSqTextBox";
            this.apSqTextBox.Size = new System.Drawing.Size(137, 22);
            this.apSqTextBox.TabIndex = 7;
            this.apSqTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apSqTextBox_KeyPress);
            // 
            // ownerIDTextBox
            // 
            this.ownerIDTextBox.Location = new System.Drawing.Point(187, 106);
            this.ownerIDTextBox.Name = "ownerIDTextBox";
            this.ownerIDTextBox.Size = new System.Drawing.Size(137, 22);
            this.ownerIDTextBox.TabIndex = 8;
            this.ownerIDTextBox.TextChanged += new System.EventHandler(this.label2_Click);
            this.ownerIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ownerIDTextBox_KeyPress);
            // 
            // numOfPrescrtextBox
            // 
            this.numOfPrescrtextBox.Location = new System.Drawing.Point(187, 134);
            this.numOfPrescrtextBox.Name = "numOfPrescrtextBox";
            this.numOfPrescrtextBox.Size = new System.Drawing.Size(135, 22);
            this.numOfPrescrtextBox.TabIndex = 9;
            this.numOfPrescrtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOfPrescrtextBox_KeyPress);
            // 
            // addApartmentButton
            // 
            this.addApartmentButton.Location = new System.Drawing.Point(115, 181);
            this.addApartmentButton.Name = "addApartmentButton";
            this.addApartmentButton.Size = new System.Drawing.Size(124, 29);
            this.addApartmentButton.TabIndex = 10;
            this.addApartmentButton.Text = "Add";
            this.addApartmentButton.UseVisualStyleBackColor = true;
            this.addApartmentButton.Click += new System.EventHandler(this.addApartmentButton_Click);
            // 
            // AddApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 221);
            this.Controls.Add(this.addApartmentButton);
            this.Controls.Add(this.numOfPrescrtextBox);
            this.Controls.Add(this.ownerIDTextBox);
            this.Controls.Add(this.apSqTextBox);
            this.Controls.Add(this.houseIDTextBox);
            this.Controls.Add(this.apartmentNumberTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(377, 266);
            this.MinimumSize = new System.Drawing.Size(377, 266);
            this.Name = "AddApartmentForm";
            this.Text = "AddApartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox apartmentNumberTextBox;
        private System.Windows.Forms.TextBox houseIDTextBox;
        private System.Windows.Forms.TextBox apSqTextBox;
        private System.Windows.Forms.TextBox ownerIDTextBox;
        private System.Windows.Forms.TextBox numOfPrescrtextBox;
        private System.Windows.Forms.Button addApartmentButton;
    }
}