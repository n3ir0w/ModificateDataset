namespace Organization
{
    partial class Show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show));
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.organizationDataSet = new Organization.OrganizationDataSet();
            this.договорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договорTableAdapter = new Organization.OrganizationDataSetTableAdapters.ДоговорTableAdapter();
            this.tableAdapterManager = new Organization.OrganizationDataSetTableAdapters.TableAdapterManager();
            this.заказчикTableAdapter = new Organization.OrganizationDataSetTableAdapters.ЗаказчикTableAdapter();
            this.исполнительTableAdapter = new Organization.OrganizationDataSetTableAdapters.ИсполнительTableAdapter();
            this.проектTableAdapter = new Organization.OrganizationDataSetTableAdapters.ПроектTableAdapter();
            this.руководительTableAdapter = new Organization.OrganizationDataSetTableAdapters.РуководительTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.заказчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.исполнительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.проектBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.руководительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договорDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исполнительDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.проектDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.руководительDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.organizationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.руководительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.руководительDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 61);
            this.button5.TabIndex = 18;
            this.button5.Text = "Выход из аккаунта";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(887, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 61);
            this.button4.TabIndex = 17;
            this.button4.Text = "Выход из программы";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // organizationDataSet
            // 
            this.organizationDataSet.DataSetName = "OrganizationDataSet";
            this.organizationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договорBindingSource
            // 
            this.договорBindingSource.DataMember = "Договор";
            this.договорBindingSource.DataSource = this.organizationDataSet;
            // 
            // договорTableAdapter
            // 
            this.договорTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Organization.OrganizationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторизацияTableAdapter = null;
            this.tableAdapterManager.ДоговорTableAdapter = this.договорTableAdapter;
            this.tableAdapterManager.ЗаказчикTableAdapter = this.заказчикTableAdapter;
            this.tableAdapterManager.ИсполнительTableAdapter = this.исполнительTableAdapter;
            this.tableAdapterManager.ПроектTableAdapter = this.проектTableAdapter;
            this.tableAdapterManager.РуководительTableAdapter = this.руководительTableAdapter;
            // 
            // заказчикTableAdapter
            // 
            this.заказчикTableAdapter.ClearBeforeFill = true;
            // 
            // исполнительTableAdapter
            // 
            this.исполнительTableAdapter.ClearBeforeFill = true;
            // 
            // проектTableAdapter
            // 
            this.проектTableAdapter.ClearBeforeFill = true;
            // 
            // руководительTableAdapter
            // 
            this.руководительTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 61);
            this.button1.TabIndex = 20;
            this.button1.Text = "Договор";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 61);
            this.button2.TabIndex = 21;
            this.button2.Text = "Заказчик";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 61);
            this.button3.TabIndex = 22;
            this.button3.Text = "Исполнитель";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(12, 299);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 61);
            this.button6.TabIndex = 23;
            this.button6.Text = "Проект";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(12, 366);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(142, 61);
            this.button7.TabIndex = 24;
            this.button7.Text = "Руководитель";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(401, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "ПРОСМОТР ДАННЫХ";
            // 
            // заказчикBindingSource
            // 
            this.заказчикBindingSource.DataMember = "Заказчик";
            this.заказчикBindingSource.DataSource = this.organizationDataSet;
            // 
            // исполнительBindingSource
            // 
            this.исполнительBindingSource.DataMember = "Исполнитель";
            this.исполнительBindingSource.DataSource = this.organizationDataSet;
            // 
            // проектBindingSource
            // 
            this.проектBindingSource.DataMember = "Проект";
            this.проектBindingSource.DataSource = this.organizationDataSet;
            // 
            // руководительBindingSource
            // 
            this.руководительBindingSource.DataMember = "Руководитель";
            this.руководительBindingSource.DataSource = this.organizationDataSet;
            // 
            // договорDataGridView
            // 
            this.договорDataGridView.AllowUserToAddRows = false;
            this.договорDataGridView.AllowUserToDeleteRows = false;
            this.договорDataGridView.AutoGenerateColumns = false;
            this.договорDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.договорDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.договорDataGridView.DataSource = this.договорBindingSource;
            this.договорDataGridView.Location = new System.Drawing.Point(177, 98);
            this.договорDataGridView.Name = "договорDataGridView";
            this.договорDataGridView.ReadOnly = true;
            this.договорDataGridView.Size = new System.Drawing.Size(823, 329);
            this.договорDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "НомерДоговора";
            this.dataGridViewTextBoxColumn1.HeaderText = "НомерДоговора";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "НомерЗаказчика";
            this.dataGridViewTextBoxColumn2.HeaderText = "НомерЗаказчика";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "НомерРуководителя";
            this.dataGridViewTextBoxColumn3.HeaderText = "НомерРуководителя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "НомерПроекта";
            this.dataGridViewTextBoxColumn4.HeaderText = "НомерПроекта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ДатаНачала";
            this.dataGridViewTextBoxColumn5.HeaderText = "ДатаНачала";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ДатаОкончания";
            this.dataGridViewTextBoxColumn6.HeaderText = "ДатаОкончания";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Обязательства";
            this.dataGridViewTextBoxColumn7.HeaderText = "Обязательства";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn8.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // заказчикDataGridView
            // 
            this.заказчикDataGridView.AllowUserToAddRows = false;
            this.заказчикDataGridView.AllowUserToDeleteRows = false;
            this.заказчикDataGridView.AutoGenerateColumns = false;
            this.заказчикDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заказчикDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.заказчикDataGridView.DataSource = this.заказчикBindingSource;
            this.заказчикDataGridView.Location = new System.Drawing.Point(177, 98);
            this.заказчикDataGridView.Name = "заказчикDataGridView";
            this.заказчикDataGridView.ReadOnly = true;
            this.заказчикDataGridView.Size = new System.Drawing.Size(823, 329);
            this.заказчикDataGridView.TabIndex = 25;
            this.заказчикDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "НомерЗаказчика";
            this.dataGridViewTextBoxColumn9.HeaderText = "НомерЗаказчика";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn10.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn11.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn12.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // исполнительDataGridView
            // 
            this.исполнительDataGridView.AllowUserToAddRows = false;
            this.исполнительDataGridView.AllowUserToDeleteRows = false;
            this.исполнительDataGridView.AutoGenerateColumns = false;
            this.исполнительDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.исполнительDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.исполнительDataGridView.DataSource = this.исполнительBindingSource;
            this.исполнительDataGridView.Location = new System.Drawing.Point(177, 98);
            this.исполнительDataGridView.Name = "исполнительDataGridView";
            this.исполнительDataGridView.ReadOnly = true;
            this.исполнительDataGridView.Size = new System.Drawing.Size(823, 329);
            this.исполнительDataGridView.TabIndex = 25;
            this.исполнительDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "НомерИсполнителя";
            this.dataGridViewTextBoxColumn13.HeaderText = "НомерИсполнителя";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Роль";
            this.dataGridViewTextBoxColumn14.HeaderText = "Роль";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn15.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn16.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn17.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // проектDataGridView
            // 
            this.проектDataGridView.AllowUserToAddRows = false;
            this.проектDataGridView.AllowUserToDeleteRows = false;
            this.проектDataGridView.AutoGenerateColumns = false;
            this.проектDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.проектDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.проектDataGridView.DataSource = this.проектBindingSource;
            this.проектDataGridView.Location = new System.Drawing.Point(177, 98);
            this.проектDataGridView.Name = "проектDataGridView";
            this.проектDataGridView.ReadOnly = true;
            this.проектDataGridView.Size = new System.Drawing.Size(823, 329);
            this.проектDataGridView.TabIndex = 25;
            this.проектDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "НомерПроекта";
            this.dataGridViewTextBoxColumn18.HeaderText = "НомерПроекта";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "НомерИсполнителя";
            this.dataGridViewTextBoxColumn19.HeaderText = "НомерИсполнителя";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Оборудование";
            this.dataGridViewTextBoxColumn20.HeaderText = "Оборудование";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // руководительDataGridView
            // 
            this.руководительDataGridView.AllowUserToAddRows = false;
            this.руководительDataGridView.AllowUserToDeleteRows = false;
            this.руководительDataGridView.AutoGenerateColumns = false;
            this.руководительDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.руководительDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.руководительDataGridView.DataSource = this.руководительBindingSource;
            this.руководительDataGridView.Location = new System.Drawing.Point(177, 98);
            this.руководительDataGridView.Name = "руководительDataGridView";
            this.руководительDataGridView.ReadOnly = true;
            this.руководительDataGridView.Size = new System.Drawing.Size(823, 329);
            this.руководительDataGridView.TabIndex = 25;
            this.руководительDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "НомерРуководителя";
            this.dataGridViewTextBoxColumn21.HeaderText = "НомерРуководителя";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Роль";
            this.dataGridViewTextBoxColumn22.HeaderText = "Роль";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn23.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn24.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn25.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(768, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 61);
            this.backButton.TabIndex = 40;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.руководительDataGridView);
            this.Controls.Add(this.проектDataGridView);
            this.Controls.Add(this.исполнительDataGridView);
            this.Controls.Add(this.заказчикDataGridView);
            this.Controls.Add(this.договорDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show";
            this.Load += new System.EventHandler(this.Show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.organizationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.руководительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.руководительDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private OrganizationDataSet organizationDataSet;
        private System.Windows.Forms.BindingSource договорBindingSource;
        private OrganizationDataSetTableAdapters.ДоговорTableAdapter договорTableAdapter;
        private OrganizationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private OrganizationDataSetTableAdapters.ЗаказчикTableAdapter заказчикTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource заказчикBindingSource;
        private OrganizationDataSetTableAdapters.ИсполнительTableAdapter исполнительTableAdapter;
        private System.Windows.Forms.BindingSource исполнительBindingSource;
        private OrganizationDataSetTableAdapters.ПроектTableAdapter проектTableAdapter;
        private System.Windows.Forms.BindingSource проектBindingSource;
        private OrganizationDataSetTableAdapters.РуководительTableAdapter руководительTableAdapter;
        private System.Windows.Forms.BindingSource руководительBindingSource;
        private System.Windows.Forms.DataGridView договорDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView заказчикDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView исполнительDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridView проектDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridView руководительDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.Button backButton;
    }
}