namespace Epam.TalalaykinaEI.Task3_v._3_.Account_Forms
{
    partial class GetAllAccountsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.uTILITIES3DataSet = new Epam.TalalaykinaEI.Task3_v._3_.UTILITIES3DataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new Epam.TalalaykinaEI.Task3_v._3_.UTILITIES3DataSetTableAdapters.AccountTableAdapter();
            this.iDAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUtilitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.needToPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAccountDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.iDUtilitieDataGridViewTextBoxColumn,
            this.accountDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.paidAmountDataGridViewTextBoxColumn,
            this.isPaidDataGridViewTextBoxColumn,
            this.needToPayDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.accountBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(8, 10);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(870, 384);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uTILITIES3DataSet
            // 
            this.uTILITIES3DataSet.DataSetName = "UTILITIES3DataSet";
            this.uTILITIES3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.uTILITIES3DataSet;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // iDAccountDataGridViewTextBoxColumn
            // 
            this.iDAccountDataGridViewTextBoxColumn.DataPropertyName = "ID_Account";
            this.iDAccountDataGridViewTextBoxColumn.HeaderText = "ID_Account";
            this.iDAccountDataGridViewTextBoxColumn.Name = "iDAccountDataGridViewTextBoxColumn";
            this.iDAccountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "Invoice_Number";
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "Invoice_Number";
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            this.invoiceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDUtilitieDataGridViewTextBoxColumn
            // 
            this.iDUtilitieDataGridViewTextBoxColumn.DataPropertyName = "ID_Utilitie";
            this.iDUtilitieDataGridViewTextBoxColumn.HeaderText = "ID_Utilitie";
            this.iDUtilitieDataGridViewTextBoxColumn.Name = "iDUtilitieDataGridViewTextBoxColumn";
            this.iDUtilitieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountDateDataGridViewTextBoxColumn
            // 
            this.accountDateDataGridViewTextBoxColumn.DataPropertyName = "Account_Date";
            this.accountDateDataGridViewTextBoxColumn.HeaderText = "Account_Date";
            this.accountDateDataGridViewTextBoxColumn.Name = "accountDateDataGridViewTextBoxColumn";
            this.accountDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidAmountDataGridViewTextBoxColumn
            // 
            this.paidAmountDataGridViewTextBoxColumn.DataPropertyName = "Paid_Amount";
            this.paidAmountDataGridViewTextBoxColumn.HeaderText = "Paid_Amount";
            this.paidAmountDataGridViewTextBoxColumn.Name = "paidAmountDataGridViewTextBoxColumn";
            this.paidAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isPaidDataGridViewTextBoxColumn
            // 
            this.isPaidDataGridViewTextBoxColumn.DataPropertyName = "Is_Paid";
            this.isPaidDataGridViewTextBoxColumn.HeaderText = "Is_Paid";
            this.isPaidDataGridViewTextBoxColumn.Name = "isPaidDataGridViewTextBoxColumn";
            this.isPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // needToPayDataGridViewTextBoxColumn
            // 
            this.needToPayDataGridViewTextBoxColumn.DataPropertyName = "Need_To_Pay";
            this.needToPayDataGridViewTextBoxColumn.HeaderText = "Need_To_Pay";
            this.needToPayDataGridViewTextBoxColumn.Name = "needToPayDataGridViewTextBoxColumn";
            this.needToPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GetAllAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 403);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(902, 448);
            this.MinimumSize = new System.Drawing.Size(902, 448);
            this.Name = "GetAllAccountsForm";
            this.Text = "GetAllAccountsForm";
            this.Load += new System.EventHandler(this.GetAllAccountsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private UTILITIES3DataSet uTILITIES3DataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private UTILITIES3DataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUtilitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn needToPayDataGridViewTextBoxColumn;
    }
}