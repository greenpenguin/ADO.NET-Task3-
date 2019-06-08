namespace Epam.TalalaykinaEI.Task3_v._3_.Invoice_Forms
{
    partial class GetAllInvoicesForm
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
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new Epam.TalalaykinaEI.Task3_v._3_.UTILITIES3DataSetTableAdapters.InvoiceTableAdapter();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
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
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.iDOwnerDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.paidAmountDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.invoiceBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(7, 11);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(865, 383);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // uTILITIES3DataSet
            // 
            this.uTILITIES3DataSet.DataSetName = "UTILITIES3DataSet";
            this.uTILITIES3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.uTILITIES3DataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "Invoice_Number";
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "Invoice_Number";
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            this.invoiceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDOwnerDataGridViewTextBoxColumn
            // 
            this.iDOwnerDataGridViewTextBoxColumn.DataPropertyName = "ID_Owner";
            this.iDOwnerDataGridViewTextBoxColumn.HeaderText = "ID_Owner";
            this.iDOwnerDataGridViewTextBoxColumn.Name = "iDOwnerDataGridViewTextBoxColumn";
            this.iDOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "Invoice_Date";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "Invoice_Date";
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // GetAllInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 403);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(902, 448);
            this.MinimumSize = new System.Drawing.Size(902, 448);
            this.Name = "GetAllInvoicesForm";
            this.Text = "GetAllInvoicesForm";
            this.Load += new System.EventHandler(this.GetAllInvoicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private UTILITIES3DataSet uTILITIES3DataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private UTILITIES3DataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAmountDataGridViewTextBoxColumn;
    }
}