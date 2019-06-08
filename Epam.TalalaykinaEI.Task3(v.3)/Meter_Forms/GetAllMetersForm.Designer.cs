namespace Epam.TalalaykinaEI.Task3_v._3_.Meter_Forms
{
    partial class GetAllMetersForm
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
            this.meterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meterTableAdapter = new Epam.TalalaykinaEI.Task3_v._3_.UTILITIES3DataSetTableAdapters.MeterTableAdapter();
            this.iDMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextCheckDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUtilitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meterBindingSource)).BeginInit();
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
            this.iDMeterDataGridViewTextBoxColumn,
            this.installationDateDataGridViewTextBoxColumn,
            this.nextCheckDateDataGridViewTextBoxColumn,
            this.iDUtilitieDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.meterBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(15, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(853, 371);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uTILITIES3DataSet
            // 
            this.uTILITIES3DataSet.DataSetName = "UTILITIES3DataSet";
            this.uTILITIES3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meterBindingSource
            // 
            this.meterBindingSource.DataMember = "Meter";
            this.meterBindingSource.DataSource = this.uTILITIES3DataSet;
            // 
            // meterTableAdapter
            // 
            this.meterTableAdapter.ClearBeforeFill = true;
            // 
            // iDMeterDataGridViewTextBoxColumn
            // 
            this.iDMeterDataGridViewTextBoxColumn.DataPropertyName = "ID_Meter";
            this.iDMeterDataGridViewTextBoxColumn.HeaderText = "ID_Meter";
            this.iDMeterDataGridViewTextBoxColumn.Name = "iDMeterDataGridViewTextBoxColumn";
            this.iDMeterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // installationDateDataGridViewTextBoxColumn
            // 
            this.installationDateDataGridViewTextBoxColumn.DataPropertyName = "Installation_Date";
            this.installationDateDataGridViewTextBoxColumn.HeaderText = "Installation_Date";
            this.installationDateDataGridViewTextBoxColumn.Name = "installationDateDataGridViewTextBoxColumn";
            this.installationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextCheckDateDataGridViewTextBoxColumn
            // 
            this.nextCheckDateDataGridViewTextBoxColumn.DataPropertyName = "Next_Check_Date";
            this.nextCheckDateDataGridViewTextBoxColumn.HeaderText = "Next_Check_Date";
            this.nextCheckDateDataGridViewTextBoxColumn.Name = "nextCheckDateDataGridViewTextBoxColumn";
            this.nextCheckDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDUtilitieDataGridViewTextBoxColumn
            // 
            this.iDUtilitieDataGridViewTextBoxColumn.DataPropertyName = "ID_Utilitie";
            this.iDUtilitieDataGridViewTextBoxColumn.HeaderText = "ID_Utilitie";
            this.iDUtilitieDataGridViewTextBoxColumn.Name = "iDUtilitieDataGridViewTextBoxColumn";
            this.iDUtilitieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GetAllMetersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 403);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(902, 448);
            this.MinimumSize = new System.Drawing.Size(902, 448);
            this.Name = "GetAllMetersForm";
            this.Text = "GetAllMetersForm";
            this.Load += new System.EventHandler(this.GetAllMetersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private UTILITIES3DataSet uTILITIES3DataSet;
        private System.Windows.Forms.BindingSource meterBindingSource;
        private UTILITIES3DataSetTableAdapters.MeterTableAdapter meterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextCheckDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUtilitieDataGridViewTextBoxColumn;
    }
}