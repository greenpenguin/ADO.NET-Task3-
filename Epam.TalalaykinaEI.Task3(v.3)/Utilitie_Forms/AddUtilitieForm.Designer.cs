namespace Epam.TalalaykinaEI.Task3_v._3_.Utilitie_Forms
{
    partial class AddUtilitieForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rateIDTextBox = new System.Windows.Forms.TextBox();
            this.addRateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Heating",
            "Gas",
            "Electricity",
            "Hot water supply",
            "Cold water supply",
            "Water disposal"});
            this.comboBox1.Location = new System.Drawing.Point(22, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose utilitie type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate ID";
            // 
            // rateIDTextBox
            // 
            this.rateIDTextBox.Location = new System.Drawing.Point(24, 102);
            this.rateIDTextBox.Name = "rateIDTextBox";
            this.rateIDTextBox.Size = new System.Drawing.Size(205, 22);
            this.rateIDTextBox.TabIndex = 3;
            this.rateIDTextBox.TextChanged += new System.EventHandler(this.rateIDTextBox_TextChanged);
            this.rateIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateIDTextBox_KeyPress);
            // 
            // addRateButton
            // 
            this.addRateButton.Location = new System.Drawing.Point(65, 130);
            this.addRateButton.Name = "addRateButton";
            this.addRateButton.Size = new System.Drawing.Size(105, 33);
            this.addRateButton.TabIndex = 4;
            this.addRateButton.Text = "Add";
            this.addRateButton.UseVisualStyleBackColor = true;
            this.addRateButton.Click += new System.EventHandler(this.addRateButton_Click);
            // 
            // AddUtilitieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 185);
            this.Controls.Add(this.addRateButton);
            this.Controls.Add(this.rateIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddUtilitieForm";
            this.Text = "AddUtilitieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rateIDTextBox;
        private System.Windows.Forms.Button addRateButton;
    }
}