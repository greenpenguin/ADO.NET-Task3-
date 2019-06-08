namespace Epam.TalalaykinaEI.Task3_v._3_.Apartment_Forms
{
    partial class GetAllApartmentsForm
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
            this.apartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentTableAdapter = new Epam.TalalaykinaEI.Task3_v._3_.UTILITIES3DataSetTableAdapters.ApartmentTableAdapter();
            this.iDApartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDHouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentSquareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPrescribedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentBindingSource)).BeginInit();
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
            this.iDApartmentDataGridViewTextBoxColumn,
            this.apartmentNumberDataGridViewTextBoxColumn,
            this.iDHouseDataGridViewTextBoxColumn,
            this.apartmentSquareDataGridViewTextBoxColumn,
            this.iDOwnerDataGridViewTextBoxColumn,
            this.numberOfPrescribedDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.apartmentBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1084, 378);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // uTILITIES3DataSet
            // 
            this.uTILITIES3DataSet.DataSetName = "UTILITIES3DataSet";
            this.uTILITIES3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apartmentBindingSource
            // 
            this.apartmentBindingSource.DataMember = "Apartment";
            this.apartmentBindingSource.DataSource = this.uTILITIES3DataSet;
            // 
            // apartmentTableAdapter
            // 
            this.apartmentTableAdapter.ClearBeforeFill = true;
            // 
            // iDApartmentDataGridViewTextBoxColumn
            // 
            this.iDApartmentDataGridViewTextBoxColumn.DataPropertyName = "ID_Apartment";
            this.iDApartmentDataGridViewTextBoxColumn.HeaderText = "ID_Apartment";
            this.iDApartmentDataGridViewTextBoxColumn.Name = "iDApartmentDataGridViewTextBoxColumn";
            this.iDApartmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apartmentNumberDataGridViewTextBoxColumn
            // 
            this.apartmentNumberDataGridViewTextBoxColumn.DataPropertyName = "Apartment_Number";
            this.apartmentNumberDataGridViewTextBoxColumn.HeaderText = "Apartment_Number";
            this.apartmentNumberDataGridViewTextBoxColumn.Name = "apartmentNumberDataGridViewTextBoxColumn";
            this.apartmentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDHouseDataGridViewTextBoxColumn
            // 
            this.iDHouseDataGridViewTextBoxColumn.DataPropertyName = "ID_House";
            this.iDHouseDataGridViewTextBoxColumn.HeaderText = "ID_House";
            this.iDHouseDataGridViewTextBoxColumn.Name = "iDHouseDataGridViewTextBoxColumn";
            this.iDHouseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apartmentSquareDataGridViewTextBoxColumn
            // 
            this.apartmentSquareDataGridViewTextBoxColumn.DataPropertyName = "Apartment_Square";
            this.apartmentSquareDataGridViewTextBoxColumn.HeaderText = "Apartment_Square";
            this.apartmentSquareDataGridViewTextBoxColumn.Name = "apartmentSquareDataGridViewTextBoxColumn";
            this.apartmentSquareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDOwnerDataGridViewTextBoxColumn
            // 
            this.iDOwnerDataGridViewTextBoxColumn.DataPropertyName = "ID_Owner";
            this.iDOwnerDataGridViewTextBoxColumn.HeaderText = "ID_Owner";
            this.iDOwnerDataGridViewTextBoxColumn.Name = "iDOwnerDataGridViewTextBoxColumn";
            this.iDOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfPrescribedDataGridViewTextBoxColumn
            // 
            this.numberOfPrescribedDataGridViewTextBoxColumn.DataPropertyName = "Number_Of_Prescribed";
            this.numberOfPrescribedDataGridViewTextBoxColumn.HeaderText = "Number_Of_Prescribed";
            this.numberOfPrescribedDataGridViewTextBoxColumn.Name = "numberOfPrescribedDataGridViewTextBoxColumn";
            this.numberOfPrescribedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GetAllApartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 403);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(1126, 448);
            this.MinimumSize = new System.Drawing.Size(1126, 448);
            this.Name = "GetAllApartmentsForm";
            this.Text = "GetAllApartmentsForm";
            this.Load += new System.EventHandler(this.GetAllApartmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private UTILITIES3DataSet uTILITIES3DataSet;
        private System.Windows.Forms.BindingSource apartmentBindingSource;
        private UTILITIES3DataSetTableAdapters.ApartmentTableAdapter apartmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDApartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentSquareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPrescribedDataGridViewTextBoxColumn;
    }
}