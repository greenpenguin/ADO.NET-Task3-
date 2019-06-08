namespace Epam.TalalaykinaEI.Task3_v._3_.List_Of_Debtor_Forms
{
    partial class GetAllDebtorsForm
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
            this.listOfDebtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_Of_DebtorTableAdapter = new Epam.TalalaykinaEI.Task3_v._3_.UTILITIES3DataSetTableAdapters.List_Of_DebtorTableAdapter();
            this.iDOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUtilitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfDebtorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOwnerDataGridViewTextBoxColumn,
            this.iDUtilitieDataGridViewTextBoxColumn,
            this.owedAmountDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.listOfDebtorBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(13, 15);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(862, 381);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // uTILITIES3DataSet
            // 
            this.uTILITIES3DataSet.DataSetName = "UTILITIES3DataSet";
            this.uTILITIES3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listOfDebtorBindingSource
            // 
            this.listOfDebtorBindingSource.DataMember = "List_Of_Debtor";
            this.listOfDebtorBindingSource.DataSource = this.uTILITIES3DataSet;
            // 
            // list_Of_DebtorTableAdapter
            // 
            this.list_Of_DebtorTableAdapter.ClearBeforeFill = true;
            // 
            // iDOwnerDataGridViewTextBoxColumn
            // 
            this.iDOwnerDataGridViewTextBoxColumn.DataPropertyName = "ID_Owner";
            this.iDOwnerDataGridViewTextBoxColumn.HeaderText = "ID_Owner";
            this.iDOwnerDataGridViewTextBoxColumn.Name = "iDOwnerDataGridViewTextBoxColumn";
            this.iDOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDUtilitieDataGridViewTextBoxColumn
            // 
            this.iDUtilitieDataGridViewTextBoxColumn.DataPropertyName = "ID_Utilitie";
            this.iDUtilitieDataGridViewTextBoxColumn.HeaderText = "ID_Utilitie";
            this.iDUtilitieDataGridViewTextBoxColumn.Name = "iDUtilitieDataGridViewTextBoxColumn";
            this.iDUtilitieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // owedAmountDataGridViewTextBoxColumn
            // 
            this.owedAmountDataGridViewTextBoxColumn.DataPropertyName = "Owed_Amount";
            this.owedAmountDataGridViewTextBoxColumn.HeaderText = "Owed_Amount";
            this.owedAmountDataGridViewTextBoxColumn.Name = "owedAmountDataGridViewTextBoxColumn";
            this.owedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GetAllDebtorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 403);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(902, 448);
            this.MinimumSize = new System.Drawing.Size(902, 448);
            this.Name = "GetAllDebtorsForm";
            this.Text = "GetAllDebtorsForm";
            this.Load += new System.EventHandler(this.GetAllDebtorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfDebtorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private UTILITIES3DataSet uTILITIES3DataSet;
        private System.Windows.Forms.BindingSource listOfDebtorBindingSource;
        private UTILITIES3DataSetTableAdapters.List_Of_DebtorTableAdapter list_Of_DebtorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUtilitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owedAmountDataGridViewTextBoxColumn;
    }
}