namespace Epam.TalalaykinaEI.Task3_v._3_.Utilitie_Forms
{
    partial class GetAllUtilitiesForm
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
            this.utilitieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilitieTableAdapter = new Epam.TalalaykinaEI.Task3_v._3_.UTILITIES3DataSetTableAdapters.UtilitieTableAdapter();
            this.iDUtilitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilitieTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilitieBindingSource)).BeginInit();
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
            this.iDUtilitieDataGridViewTextBoxColumn,
            this.utilitieTypeDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.iDRateDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.utilitieBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(860, 379);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uTILITIES3DataSet
            // 
            this.uTILITIES3DataSet.DataSetName = "UTILITIES3DataSet";
            this.uTILITIES3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilitieBindingSource
            // 
            this.utilitieBindingSource.DataMember = "Utilitie";
            this.utilitieBindingSource.DataSource = this.uTILITIES3DataSet;
            // 
            // utilitieTableAdapter
            // 
            this.utilitieTableAdapter.ClearBeforeFill = true;
            // 
            // iDUtilitieDataGridViewTextBoxColumn
            // 
            this.iDUtilitieDataGridViewTextBoxColumn.DataPropertyName = "ID_Utilitie";
            this.iDUtilitieDataGridViewTextBoxColumn.HeaderText = "ID_Utilitie";
            this.iDUtilitieDataGridViewTextBoxColumn.Name = "iDUtilitieDataGridViewTextBoxColumn";
            this.iDUtilitieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utilitieTypeDataGridViewTextBoxColumn
            // 
            this.utilitieTypeDataGridViewTextBoxColumn.DataPropertyName = "Utilitie_Type";
            this.utilitieTypeDataGridViewTextBoxColumn.HeaderText = "Utilitie_Type";
            this.utilitieTypeDataGridViewTextBoxColumn.Name = "utilitieTypeDataGridViewTextBoxColumn";
            this.utilitieTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDRateDataGridViewTextBoxColumn
            // 
            this.iDRateDataGridViewTextBoxColumn.DataPropertyName = "ID_Rate";
            this.iDRateDataGridViewTextBoxColumn.HeaderText = "ID_Rate";
            this.iDRateDataGridViewTextBoxColumn.Name = "iDRateDataGridViewTextBoxColumn";
            this.iDRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GetAllUtilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 403);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(902, 448);
            this.MinimumSize = new System.Drawing.Size(902, 448);
            this.Name = "GetAllUtilitiesForm";
            this.Text = "GetAllUtilitiesForm";
            this.Load += new System.EventHandler(this.GetAllUtilitiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilitieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private UTILITIES3DataSet uTILITIES3DataSet;
        private System.Windows.Forms.BindingSource utilitieBindingSource;
        private UTILITIES3DataSetTableAdapters.UtilitieTableAdapter utilitieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUtilitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilitieTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRateDataGridViewTextBoxColumn;
    }
}