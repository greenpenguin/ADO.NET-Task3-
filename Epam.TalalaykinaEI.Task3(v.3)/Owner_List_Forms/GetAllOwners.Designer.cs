namespace Epam.TalalaykinaEI.Task3_v._3_
{
    partial class GetAllOwners
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
            this.iDOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uTILITIES3DataSet = new Epam.TalalaykinaEI.Task3_v._3_.UTILITIES3DataSet();
            this.owner_ListTableAdapter = new Epam.TalalaykinaEI.Task3_v._3_.UTILITIES3DataSetTableAdapters.Owner_ListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOwnerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.ownerListBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(843, 378);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDOwnerDataGridViewTextBoxColumn
            // 
            this.iDOwnerDataGridViewTextBoxColumn.DataPropertyName = "ID_Owner";
            this.iDOwnerDataGridViewTextBoxColumn.HeaderText = "ID_Owner";
            this.iDOwnerDataGridViewTextBoxColumn.Name = "iDOwnerDataGridViewTextBoxColumn";
            this.iDOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "Second_Name";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "Second_Name";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // ownerListBindingSource
            // 
            this.ownerListBindingSource.DataMember = "Owner_List";
            this.ownerListBindingSource.DataSource = this.uTILITIES3DataSet;
            // 
            // uTILITIES3DataSet
            // 
            this.uTILITIES3DataSet.DataSetName = "UTILITIES3DataSet";
            this.uTILITIES3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // owner_ListTableAdapter
            // 
            this.owner_ListTableAdapter.ClearBeforeFill = true;
            // 
            // GetAllOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 403);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(902, 448);
            this.MinimumSize = new System.Drawing.Size(902, 448);
            this.Name = "GetAllOwners";
            this.Text = "Get All Owners";
            this.Load += new System.EventHandler(this.GetAllOwners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTILITIES3DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private UTILITIES3DataSet uTILITIES3DataSet;
        private System.Windows.Forms.BindingSource ownerListBindingSource;
        private UTILITIES3DataSetTableAdapters.Owner_ListTableAdapter owner_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
    }
}