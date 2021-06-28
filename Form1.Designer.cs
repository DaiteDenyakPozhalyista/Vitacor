namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgDoctors = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vetClinicDataSet = new WindowsFormsApp1.VetClinicDataSet();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.doctorsTableAdapter = new WindowsFormsApp1.VetClinicDataSetTableAdapters.DoctorsTableAdapter();
            this.dgOwners = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownersTableAdapter = new WindowsFormsApp1.VetClinicDataSetTableAdapters.OwnersTableAdapter();
            this.fKBeastsDoctorsDoctorIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beastsTableAdapter = new WindowsFormsApp1.VetClinicDataSetTableAdapters.BeastsTableAdapter();
            this.dgVaccines = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaccinesTableAdapter = new WindowsFormsApp1.VetClinicDataSetTableAdapters.VaccinesTableAdapter();
            this.fKServicesDoctorsDoctorIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new WindowsFormsApp1.VetClinicDataSetTableAdapters.ServicesTableAdapter();
            this.fKBeastsDoctorsDoctorIdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ownersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgBeasts = new System.Windows.Forms.DataGridView();
            this.ownersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vaccinesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.beastsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKBeastsDoctorsDoctorIdBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgServices = new System.Windows.Forms.DataGridView();
            this.doctorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.servicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.beastsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultsTableAdapter = new WindowsFormsApp1.VetClinicDataSetTableAdapters.ResultsTableAdapter();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.doctorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vaccinesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.beastIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOwners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBeastsDoctorsDoctorIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServicesDoctorsDoctorIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBeastsDoctorsDoctorIdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBeasts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beastsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBeastsDoctorsDoctorIdBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beastsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDoctors
            // 
            this.dgDoctors.AutoGenerateColumns = false;
            this.dgDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgDoctors.DataSource = this.doctorsBindingSource;
            this.dgDoctors.Location = new System.Drawing.Point(12, 43);
            this.dgDoctors.Name = "dgDoctors";
            this.dgDoctors.Size = new System.Drawing.Size(253, 135);
            this.dgDoctors.TabIndex = 0;
            this.dgDoctors.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDoctors_RowLeave);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.vetClinicDataSet;
            // 
            // vetClinicDataSet
            // 
            this.vetClinicDataSet.DataSetName = "VetClinicDataSet";
            this.vetClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // dgOwners
            // 
            this.dgOwners.AutoGenerateColumns = false;
            this.dgOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOwners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.dgOwners.DataSource = this.ownersBindingSource;
            this.dgOwners.Location = new System.Drawing.Point(12, 218);
            this.dgOwners.Name = "dgOwners";
            this.dgOwners.Size = new System.Drawing.Size(253, 150);
            this.dgOwners.TabIndex = 1;
            this.dgOwners.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOwners_RowLeave);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "Owners";
            this.ownersBindingSource.DataSource = this.vetClinicDataSet;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // fKBeastsDoctorsDoctorIdBindingSource
            // 
            this.fKBeastsDoctorsDoctorIdBindingSource.DataMember = "FK_Beasts_Doctors_DoctorId";
            this.fKBeastsDoctorsDoctorIdBindingSource.DataSource = this.doctorsBindingSource;
            // 
            // beastsTableAdapter
            // 
            this.beastsTableAdapter.ClearBeforeFill = true;
            // 
            // dgVaccines
            // 
            this.dgVaccines.AutoGenerateColumns = false;
            this.dgVaccines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn3});
            this.dgVaccines.DataSource = this.vaccinesBindingSource;
            this.dgVaccines.Location = new System.Drawing.Point(358, 218);
            this.dgVaccines.Name = "dgVaccines";
            this.dgVaccines.Size = new System.Drawing.Size(247, 150);
            this.dgVaccines.TabIndex = 3;
            this.dgVaccines.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVaccines_RowLeave);
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            // 
            // vaccinesBindingSource
            // 
            this.vaccinesBindingSource.DataMember = "Vaccines";
            this.vaccinesBindingSource.DataSource = this.vetClinicDataSet;
            // 
            // vaccinesTableAdapter
            // 
            this.vaccinesTableAdapter.ClearBeforeFill = true;
            // 
            // fKServicesDoctorsDoctorIdBindingSource
            // 
            this.fKServicesDoctorsDoctorIdBindingSource.DataMember = "FK_Services_Doctors_DoctorId";
            this.fKServicesDoctorsDoctorIdBindingSource.DataSource = this.doctorsBindingSource;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // fKBeastsDoctorsDoctorIdBindingSource1
            // 
            this.fKBeastsDoctorsDoctorIdBindingSource1.DataMember = "FK_Beasts_Doctors_DoctorId";
            this.fKBeastsDoctorsDoctorIdBindingSource1.DataSource = this.doctorsBindingSource;
            // 
            // ownersBindingSource1
            // 
            this.ownersBindingSource1.DataMember = "Owners";
            this.ownersBindingSource1.DataSource = this.vetClinicDataSet;
            // 
            // dgBeasts
            // 
            this.dgBeasts.AutoGenerateColumns = false;
            this.dgBeasts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBeasts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.ownerIdDataGridViewTextBoxColumn,
            this.doctorIdDataGridViewTextBoxColumn,
            this.vaccinesIdDataGridViewTextBoxColumn});
            this.dgBeasts.DataSource = this.beastsBindingSource;
            this.dgBeasts.Location = new System.Drawing.Point(358, 43);
            this.dgBeasts.Name = "dgBeasts";
            this.dgBeasts.Size = new System.Drawing.Size(546, 150);
            this.dgBeasts.TabIndex = 5;
            this.dgBeasts.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBeasts_RowLeave);
            // 
            // ownersBindingSource2
            // 
            this.ownersBindingSource2.DataMember = "Owners";
            this.ownersBindingSource2.DataSource = this.vetClinicDataSet;
            // 
            // doctorsBindingSource1
            // 
            this.doctorsBindingSource1.DataMember = "Doctors";
            this.doctorsBindingSource1.DataSource = this.vetClinicDataSet;
            // 
            // vaccinesBindingSource1
            // 
            this.vaccinesBindingSource1.DataMember = "Vaccines";
            this.vaccinesBindingSource1.DataSource = this.vetClinicDataSet;
            // 
            // beastsBindingSource
            // 
            this.beastsBindingSource.DataMember = "Beasts";
            this.beastsBindingSource.DataSource = this.vetClinicDataSet;
            // 
            // fKBeastsDoctorsDoctorIdBindingSource2
            // 
            this.fKBeastsDoctorsDoctorIdBindingSource2.DataMember = "FK_Beasts_Doctors_DoctorId";
            this.fKBeastsDoctorsDoctorIdBindingSource2.DataSource = this.doctorsBindingSource;
            // 
            // dgServices
            // 
            this.dgServices.AutoGenerateColumns = false;
            this.dgServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.nameDataGridViewTextBoxColumn4,
            this.costDataGridViewTextBoxColumn,
            this.doctorIdDataGridViewTextBoxColumn1});
            this.dgServices.DataSource = this.servicesBindingSource;
            this.dgServices.Location = new System.Drawing.Point(629, 218);
            this.dgServices.Name = "dgServices";
            this.dgServices.Size = new System.Drawing.Size(445, 150);
            this.dgServices.TabIndex = 6;
            this.dgServices.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgServices_RowLeave);
            // 
            // doctorsBindingSource2
            // 
            this.doctorsBindingSource2.DataMember = "Doctors";
            this.doctorsBindingSource2.DataSource = this.vetClinicDataSet;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.vetClinicDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doctors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Owners";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vaccines";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Beasts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Services";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Operation";
            // 
            // dgResult
            // 
            this.dgResult.AutoGenerateColumns = false;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn5,
            this.servicesIdDataGridViewTextBoxColumn,
            this.beastIdDataGridViewTextBoxColumn});
            this.dgResult.DataSource = this.resultsBindingSource;
            this.dgResult.Location = new System.Drawing.Point(12, 387);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(349, 150);
            this.dgResult.TabIndex = 13;
            this.dgResult.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResult_RowLeave);
            // 
            // servicesBindingSource1
            // 
            this.servicesBindingSource1.DataMember = "Services";
            this.servicesBindingSource1.DataSource = this.vetClinicDataSet;
            // 
            // beastsBindingSource1
            // 
            this.beastsBindingSource1.DataMember = "Beasts";
            this.beastsBindingSource1.DataSource = this.vetClinicDataSet;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "Results";
            this.resultsBindingSource.DataSource = this.vetClinicDataSet;
            // 
            // resultsTableAdapter
            // 
            this.resultsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            this.ownerIdDataGridViewTextBoxColumn.DataPropertyName = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.DataSource = this.ownersBindingSource2;
            this.ownerIdDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            this.ownerIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ownerIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ownerIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // doctorIdDataGridViewTextBoxColumn
            // 
            this.doctorIdDataGridViewTextBoxColumn.DataPropertyName = "DoctorId";
            this.doctorIdDataGridViewTextBoxColumn.DataSource = this.doctorsBindingSource1;
            this.doctorIdDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorIdDataGridViewTextBoxColumn.Name = "doctorIdDataGridViewTextBoxColumn";
            this.doctorIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.doctorIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // vaccinesIdDataGridViewTextBoxColumn
            // 
            this.vaccinesIdDataGridViewTextBoxColumn.DataPropertyName = "VaccinesId";
            this.vaccinesIdDataGridViewTextBoxColumn.DataSource = this.vaccinesBindingSource1;
            this.vaccinesIdDataGridViewTextBoxColumn.HeaderText = "Vaccines";
            this.vaccinesIdDataGridViewTextBoxColumn.Name = "vaccinesIdDataGridViewTextBoxColumn";
            this.vaccinesIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vaccinesIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vaccinesIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn4
            // 
            this.nameDataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn4.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // doctorIdDataGridViewTextBoxColumn1
            // 
            this.doctorIdDataGridViewTextBoxColumn1.DataPropertyName = "DoctorId";
            this.doctorIdDataGridViewTextBoxColumn1.DataSource = this.doctorsBindingSource2;
            this.doctorIdDataGridViewTextBoxColumn1.HeaderText = "Doctor";
            this.doctorIdDataGridViewTextBoxColumn1.Name = "doctorIdDataGridViewTextBoxColumn1";
            this.doctorIdDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorIdDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.doctorIdDataGridViewTextBoxColumn1.ValueMember = "Id";
            // 
            // idDataGridViewTextBoxColumn5
            // 
            this.idDataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn5.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn5.Name = "idDataGridViewTextBoxColumn5";
            this.idDataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // servicesIdDataGridViewTextBoxColumn
            // 
            this.servicesIdDataGridViewTextBoxColumn.DataPropertyName = "ServicesId";
            this.servicesIdDataGridViewTextBoxColumn.DataSource = this.servicesBindingSource1;
            this.servicesIdDataGridViewTextBoxColumn.HeaderText = "Services";
            this.servicesIdDataGridViewTextBoxColumn.Name = "servicesIdDataGridViewTextBoxColumn";
            this.servicesIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.servicesIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.servicesIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // beastIdDataGridViewTextBoxColumn
            // 
            this.beastIdDataGridViewTextBoxColumn.DataPropertyName = "BeastId";
            this.beastIdDataGridViewTextBoxColumn.DataSource = this.beastsBindingSource1;
            this.beastIdDataGridViewTextBoxColumn.HeaderText = "Beast";
            this.beastIdDataGridViewTextBoxColumn.Name = "beastIdDataGridViewTextBoxColumn";
            this.beastIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.beastIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.beastIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 561);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgServices);
            this.Controls.Add(this.dgBeasts);
            this.Controls.Add(this.dgVaccines);
            this.Controls.Add(this.dgOwners);
            this.Controls.Add(this.dgDoctors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOwners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBeastsDoctorsDoctorIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServicesDoctorsDoctorIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBeastsDoctorsDoctorIdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBeasts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beastsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBeastsDoctorsDoctorIdBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beastsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDoctors;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private VetClinicDataSet vetClinicDataSet;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private VetClinicDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgOwners;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private VetClinicDataSetTableAdapters.OwnersTableAdapter ownersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource fKBeastsDoctorsDoctorIdBindingSource;
        private VetClinicDataSetTableAdapters.BeastsTableAdapter beastsTableAdapter;
        private System.Windows.Forms.DataGridView dgVaccines;
        private System.Windows.Forms.BindingSource vaccinesBindingSource;
        private VetClinicDataSetTableAdapters.VaccinesTableAdapter vaccinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource fKServicesDoctorsDoctorIdBindingSource;
        private VetClinicDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource fKBeastsDoctorsDoctorIdBindingSource1;
        private System.Windows.Forms.BindingSource ownersBindingSource1;
        private System.Windows.Forms.DataGridView dgBeasts;
        private System.Windows.Forms.BindingSource ownersBindingSource2;
        private System.Windows.Forms.BindingSource doctorsBindingSource1;
        private System.Windows.Forms.BindingSource vaccinesBindingSource1;
        private System.Windows.Forms.BindingSource beastsBindingSource;
        private System.Windows.Forms.BindingSource fKBeastsDoctorsDoctorIdBindingSource2;
        private System.Windows.Forms.DataGridView dgServices;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private VetClinicDataSetTableAdapters.ResultsTableAdapter resultsTableAdapter;
        private System.Windows.Forms.BindingSource doctorsBindingSource2;
        private System.Windows.Forms.BindingSource servicesBindingSource1;
        private System.Windows.Forms.BindingSource beastsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn ownerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn doctorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vaccinesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn doctorIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn servicesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn beastIdDataGridViewTextBoxColumn;
    }
}

