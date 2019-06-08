namespace Epam.TalalaykinaEI.Task3_v._3_.List_Of_Installed_Meters_Forms
{
    partial class GetAllInstalledMetersForm
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
            this.listOfInstalledMetersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_Of_Installed_MetersTableAdapter = new Epam.TalalaykinaEI.Task3_v._3_.UTILITIES3DataSetTableAdapters.List_Of_Installed_MetersTableAdapter();
            this.recordNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterReadingForTodayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfInstalledMetersBindingSource)).BeginInit();
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
            this.recordNumberDataGridViewTextBoxColumn,
            this.iDMeterDataGridViewTextBoxColumn,
            this.todayDateDataGridViewTextBoxColumn,
            this.meterReadingForTodayDateDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.listOfInstalledMetersBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(11, 14);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(944, 377);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // uTILITIES3DataSet
            // 
            this.uTILITIES3DataSet.DataSetName = "UTILITIES3DataSet";
            this.uTILITIES3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listOfInstalledMetersBindingSource
            // 
            this.listOfInstalledMetersBindingSource.DataMember = "List_Of_Installed_Meters";
            this.listOfInstalledMetersBindingSource.DataSource = this.uTILITIES3DataSet;
            // 
            // list_Of_Installed_MetersTableAdapter
            // 
            this.list_Of_Installed_MetersTableAdapter.ClearBeforeFill = true;
            // 
            // recordNumberDataGridViewTextBoxColumn
            // 
            this.recordNumberDataGridViewTextBoxColumn.DataPropertyName = "Record_Number";
            this.recordNumberDataGridViewTextBoxColumn.HeaderText = "Record_Number";
            this.recordNumberDataGridViewTextBoxColumn.Name = "recordNumberDataGridViewTextBoxColumn";
            this.recordNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDMeterDataGridViewTextBoxColumn
            // 
            this.iDMeterDataGridViewTextBoxColumn.DataPropertyName = "ID_Meter";
            this.iDMeterDataGridViewTextBoxColumn.HeaderText = "ID_Meter";
            this.iDMeterDataGridViewTextBoxColumn.Name = "iDMeterDataGridViewTextBoxColumn";
            this.iDMeterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // todayDateDataGridViewTextBoxColumn
            // 
            this.todayDateDataGridViewTextBoxColumn.DataPropertyName = "Today_Date";
            this.todayDateDataGridViewTextBoxColumn.HeaderText = "Today_Date";
            this.todayDateDataGridViewTextBoxColumn.Name = "todayDateDataGridViewTextBoxColumn";
            this.todayDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meterReadingForTodayDateDataGridViewTextBoxColumn
            // 
            this.meterReadingForTodayDateDataGridViewTextBoxColumn.DataPropertyName = "Meter_Reading_For_Today_Date";
            this.meterReadingForTodayDateDataGridViewTextBoxColumn.HeaderText = "Meter_Reading_For_Today_Date";
            this.meterReadingForTodayDateDataGridViewTextBoxColumn.Name = "meterReadingForTodayDateDataGridViewTextBoxColumn";
            this.meterReadingForTodayDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GetAllInstalledMetersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 403);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(985, 448);
            this.MinimumSize = new System.Drawing.Size(985, 448);
            this.Name = "GetAllInstalledMetersForm";
            this.Text = "GetAllInstalledMetersForm";
            this.Load += new System.EventHandler(this.GetAllInstalledMetersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfInstalledMetersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private UTILITIES3DataSet uTILITIES3DataSet;
        private System.Windows.Forms.BindingSource listOfInstalledMetersBindingSource;
        private UTILITIES3DataSetTableAdapters.List_Of_Installed_MetersTableAdapter list_Of_Installed_MetersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn todayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterReadingForTodayDateDataGridViewTextBoxColumn;
    }
}