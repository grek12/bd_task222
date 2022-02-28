
using System.Data;

namespace DB_Task1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomersT = new System.Windows.Forms.DataGridView();
            this.idCsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneCsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new bd_task222.DataSet();
            this.OrdersT = new System.Windows.Forms.DataGridView();
            this.idCsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProvidersT = new System.Windows.Forms.DataGridView();
            this.idPrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commondityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephonePrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProvRemoveB = new System.Windows.Forms.Button();
            this.ProvUpdateB = new System.Windows.Forms.Button();
            this.ProvAddB = new System.Windows.Forms.Button();
            this.OrderRemoveB = new System.Windows.Forms.Button();
            this.OrderUpdateB = new System.Windows.Forms.Button();
            this.OrderAddB = new System.Windows.Forms.Button();
            this.OrderP = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.OrderCustTB = new System.Windows.Forms.ComboBox();
            this.OrderCancelB = new System.Windows.Forms.Button();
            this.OrderOkB = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OrderLimitTB = new System.Windows.Forms.TextBox();
            this.OrderNumTB = new System.Windows.Forms.TextBox();
            this.OrderComTB = new System.Windows.Forms.TextBox();
            this.ProvP = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.ProvPhoneTB = new System.Windows.Forms.TextBox();
            this.ProvCancelB = new System.Windows.Forms.Button();
            this.ProvOkB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ProvPriceTB = new System.Windows.Forms.TextBox();
            this.ProvAddressTB = new System.Windows.Forms.TextBox();
            this.ProvNameTB = new System.Windows.Forms.TextBox();
            this.ProvComTB = new System.Windows.Forms.TextBox();
            this.CustNameTB = new System.Windows.Forms.TextBox();
            this.CustAddressTB = new System.Windows.Forms.TextBox();
            this.CustBalanceTB = new System.Windows.Forms.TextBox();
            this.CustPhoneTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CustOkB = new System.Windows.Forms.Button();
            this.CustCancelB = new System.Windows.Forms.Button();
            this.CustP = new System.Windows.Forms.Panel();
            this.Cust_AddB = new System.Windows.Forms.Button();
            this.Cust_UpdateB = new System.Windows.Forms.Button();
            this.Cust_RemoveB = new System.Windows.Forms.Button();
            this.ToolP = new System.Windows.Forms.Panel();
            this.customersTableAdapter = new bd_task222.DataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter = new bd_task222.DataSetTableAdapters.OrdersTableAdapter();
            this.providersTableAdapter = new bd_task222.DataSetTableAdapters.ProvidersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvidersT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            this.OrderP.SuspendLayout();
            this.ProvP.SuspendLayout();
            this.CustP.SuspendLayout();
            this.ToolP.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersT
            // 
            this.CustomersT.AllowUserToAddRows = false;
            this.CustomersT.AllowUserToDeleteRows = false;
            this.CustomersT.AllowUserToResizeColumns = false;
            this.CustomersT.AllowUserToResizeRows = false;
            this.CustomersT.AutoGenerateColumns = false;
            this.CustomersT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CustomersT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCsDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.telephoneCsDataGridViewTextBoxColumn});
            this.CustomersT.DataSource = this.customersBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersT.DefaultCellStyle = dataGridViewCellStyle8;
            this.CustomersT.Location = new System.Drawing.Point(12, 48);
            this.CustomersT.MultiSelect = false;
            this.CustomersT.Name = "CustomersT";
            this.CustomersT.ReadOnly = true;
            this.CustomersT.RowHeadersVisible = false;
            this.CustomersT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersT.Size = new System.Drawing.Size(553, 331);
            this.CustomersT.TabIndex = 0;
            this.CustomersT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersT_CellContentClick);
            // 
            // idCsDataGridViewTextBoxColumn
            // 
            this.idCsDataGridViewTextBoxColumn.DataPropertyName = "IdCs";
            this.idCsDataGridViewTextBoxColumn.HeaderText = "IdCs";
            this.idCsDataGridViewTextBoxColumn.Name = "idCsDataGridViewTextBoxColumn";
            this.idCsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Family";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneCsDataGridViewTextBoxColumn
            // 
            this.telephoneCsDataGridViewTextBoxColumn.DataPropertyName = "TelephoneCs";
            this.telephoneCsDataGridViewTextBoxColumn.HeaderText = "TelephoneCs";
            this.telephoneCsDataGridViewTextBoxColumn.Name = "telephoneCsDataGridViewTextBoxColumn";
            this.telephoneCsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdersT
            // 
            this.OrdersT.AllowUserToAddRows = false;
            this.OrdersT.AllowUserToDeleteRows = false;
            this.OrdersT.AllowUserToResizeColumns = false;
            this.OrdersT.AllowUserToResizeRows = false;
            this.OrdersT.AutoGenerateColumns = false;
            this.OrdersT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.OrdersT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCsDataGridViewTextBoxColumn1,
            this.commodityDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.limitDataGridViewTextBoxColumn});
            this.OrdersT.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersT.DefaultCellStyle = dataGridViewCellStyle10;
            this.OrdersT.Location = new System.Drawing.Point(571, 48);
            this.OrdersT.MultiSelect = false;
            this.OrdersT.Name = "OrdersT";
            this.OrdersT.ReadOnly = true;
            this.OrdersT.RowHeadersVisible = false;
            this.OrdersT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersT.Size = new System.Drawing.Size(406, 331);
            this.OrdersT.TabIndex = 1;
            // 
            // idCsDataGridViewTextBoxColumn1
            // 
            this.idCsDataGridViewTextBoxColumn1.DataPropertyName = "IdCs";
            this.idCsDataGridViewTextBoxColumn1.HeaderText = "IdCs";
            this.idCsDataGridViewTextBoxColumn1.Name = "idCsDataGridViewTextBoxColumn1";
            this.idCsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // commodityDataGridViewTextBoxColumn
            // 
            this.commodityDataGridViewTextBoxColumn.DataPropertyName = "Commodity";
            this.commodityDataGridViewTextBoxColumn.HeaderText = "Commodity";
            this.commodityDataGridViewTextBoxColumn.Name = "commodityDataGridViewTextBoxColumn";
            this.commodityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // limitDataGridViewTextBoxColumn
            // 
            this.limitDataGridViewTextBoxColumn.DataPropertyName = "Limit";
            this.limitDataGridViewTextBoxColumn.HeaderText = "Limit";
            this.limitDataGridViewTextBoxColumn.Name = "limitDataGridViewTextBoxColumn";
            this.limitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.dataSet;
            // 
            // ProvidersT
            // 
            this.ProvidersT.AllowUserToAddRows = false;
            this.ProvidersT.AllowUserToDeleteRows = false;
            this.ProvidersT.AllowUserToResizeColumns = false;
            this.ProvidersT.AllowUserToResizeRows = false;
            this.ProvidersT.AutoGenerateColumns = false;
            this.ProvidersT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProvidersT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProvidersT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ProvidersT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProvidersT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPrDataGridViewTextBoxColumn,
            this.commondityDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn,
            this.telephonePrDataGridViewTextBoxColumn});
            this.ProvidersT.DataSource = this.providersBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProvidersT.DefaultCellStyle = dataGridViewCellStyle12;
            this.ProvidersT.Location = new System.Drawing.Point(983, 48);
            this.ProvidersT.MultiSelect = false;
            this.ProvidersT.Name = "ProvidersT";
            this.ProvidersT.ReadOnly = true;
            this.ProvidersT.RowHeadersVisible = false;
            this.ProvidersT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProvidersT.Size = new System.Drawing.Size(396, 331);
            this.ProvidersT.TabIndex = 2;
            // 
            // idPrDataGridViewTextBoxColumn
            // 
            this.idPrDataGridViewTextBoxColumn.DataPropertyName = "IdPr";
            this.idPrDataGridViewTextBoxColumn.HeaderText = "IdPr";
            this.idPrDataGridViewTextBoxColumn.Name = "idPrDataGridViewTextBoxColumn";
            this.idPrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commondityDataGridViewTextBoxColumn
            // 
            this.commondityDataGridViewTextBoxColumn.DataPropertyName = "Commondity";
            this.commondityDataGridViewTextBoxColumn.HeaderText = "Commondity";
            this.commondityDataGridViewTextBoxColumn.Name = "commondityDataGridViewTextBoxColumn";
            this.commondityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephonePrDataGridViewTextBoxColumn
            // 
            this.telephonePrDataGridViewTextBoxColumn.DataPropertyName = "TelephonePr";
            this.telephonePrDataGridViewTextBoxColumn.HeaderText = "TelephonePr";
            this.telephonePrDataGridViewTextBoxColumn.Name = "telephonePrDataGridViewTextBoxColumn";
            this.telephonePrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.dataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Клиенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(735, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Заказы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(1211, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Поставщики";
            // 
            // ProvRemoveB
            // 
            this.ProvRemoveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.ProvRemoveB.Location = new System.Drawing.Point(1274, 17);
            this.ProvRemoveB.Name = "ProvRemoveB";
            this.ProvRemoveB.Size = new System.Drawing.Size(117, 43);
            this.ProvRemoveB.TabIndex = 12;
            this.ProvRemoveB.Text = "Удалить";
            this.ProvRemoveB.UseVisualStyleBackColor = true;
            this.ProvRemoveB.Click += new System.EventHandler(this.ProvRemoveB_Click);
            // 
            // ProvUpdateB
            // 
            this.ProvUpdateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.ProvUpdateB.Location = new System.Drawing.Point(1140, 17);
            this.ProvUpdateB.Name = "ProvUpdateB";
            this.ProvUpdateB.Size = new System.Drawing.Size(126, 43);
            this.ProvUpdateB.TabIndex = 9;
            this.ProvUpdateB.Text = "Изменить";
            this.ProvUpdateB.UseVisualStyleBackColor = true;
            this.ProvUpdateB.Click += new System.EventHandler(this.ProvUpdateB_Click);
            // 
            // ProvAddB
            // 
            this.ProvAddB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.ProvAddB.Location = new System.Drawing.Point(1004, 17);
            this.ProvAddB.Name = "ProvAddB";
            this.ProvAddB.Size = new System.Drawing.Size(130, 43);
            this.ProvAddB.TabIndex = 6;
            this.ProvAddB.Text = "Добавить";
            this.ProvAddB.UseVisualStyleBackColor = true;
            this.ProvAddB.Click += new System.EventHandler(this.ProvAddB_Click);
            // 
            // OrderRemoveB
            // 
            this.OrderRemoveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.OrderRemoveB.Location = new System.Drawing.Point(848, 17);
            this.OrderRemoveB.Name = "OrderRemoveB";
            this.OrderRemoveB.Size = new System.Drawing.Size(117, 43);
            this.OrderRemoveB.TabIndex = 12;
            this.OrderRemoveB.Text = "Удалить";
            this.OrderRemoveB.UseVisualStyleBackColor = true;
            this.OrderRemoveB.Click += new System.EventHandler(this.OrderRemoveB_Click);
            // 
            // OrderUpdateB
            // 
            this.OrderUpdateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.OrderUpdateB.Location = new System.Drawing.Point(705, 17);
            this.OrderUpdateB.Name = "OrderUpdateB";
            this.OrderUpdateB.Size = new System.Drawing.Size(137, 43);
            this.OrderUpdateB.TabIndex = 9;
            this.OrderUpdateB.Text = "Изменить";
            this.OrderUpdateB.UseVisualStyleBackColor = true;
            this.OrderUpdateB.Click += new System.EventHandler(this.OrderUpdateB_Click);
            // 
            // OrderAddB
            // 
            this.OrderAddB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.OrderAddB.Location = new System.Drawing.Point(576, 17);
            this.OrderAddB.Name = "OrderAddB";
            this.OrderAddB.Size = new System.Drawing.Size(123, 43);
            this.OrderAddB.TabIndex = 6;
            this.OrderAddB.Text = "Добавить";
            this.OrderAddB.UseVisualStyleBackColor = true;
            this.OrderAddB.Click += new System.EventHandler(this.OrderAddB_Click);
            // 
            // OrderP
            // 
            this.OrderP.Controls.Add(this.label16);
            this.OrderP.Controls.Add(this.OrderCustTB);
            this.OrderP.Controls.Add(this.OrderCancelB);
            this.OrderP.Controls.Add(this.OrderOkB);
            this.OrderP.Controls.Add(this.label9);
            this.OrderP.Controls.Add(this.label10);
            this.OrderP.Controls.Add(this.label11);
            this.OrderP.Controls.Add(this.OrderLimitTB);
            this.OrderP.Controls.Add(this.OrderNumTB);
            this.OrderP.Controls.Add(this.OrderComTB);
            this.OrderP.Location = new System.Drawing.Point(558, 455);
            this.OrderP.Name = "OrderP";
            this.OrderP.Size = new System.Drawing.Size(433, 280);
            this.OrderP.TabIndex = 22;
            this.OrderP.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label16.Location = new System.Drawing.Point(8, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 26);
            this.label16.TabIndex = 23;
            this.label16.Text = "Заказ";
            // 
            // OrderCustTB
            // 
            this.OrderCustTB.DisplayMember = "ID";
            this.OrderCustTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.OrderCustTB.FormattingEnabled = true;
            this.OrderCustTB.Location = new System.Drawing.Point(144, 17);
            this.OrderCustTB.Name = "OrderCustTB";
            this.OrderCustTB.Size = new System.Drawing.Size(275, 28);
            this.OrderCustTB.TabIndex = 22;
            this.OrderCustTB.ValueMember = "ID";
            // 
            // OrderCancelB
            // 
            this.OrderCancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.OrderCancelB.Location = new System.Drawing.Point(67, 206);
            this.OrderCancelB.Name = "OrderCancelB";
            this.OrderCancelB.Size = new System.Drawing.Size(117, 43);
            this.OrderCancelB.TabIndex = 21;
            this.OrderCancelB.Text = "Cancel";
            this.OrderCancelB.UseVisualStyleBackColor = true;
            this.OrderCancelB.Click += new System.EventHandler(this.OrderCancelB_Click);
            // 
            // OrderOkB
            // 
            this.OrderOkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.OrderOkB.Location = new System.Drawing.Point(260, 206);
            this.OrderOkB.Name = "OrderOkB";
            this.OrderOkB.Size = new System.Drawing.Size(117, 43);
            this.OrderOkB.TabIndex = 20;
            this.OrderOkB.Text = "OK";
            this.OrderOkB.UseVisualStyleBackColor = true;
            this.OrderOkB.Click += new System.EventHandler(this.OrderOkB_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label9.Location = new System.Drawing.Point(8, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Лимит";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label10.Location = new System.Drawing.Point(8, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 26);
            this.label10.TabIndex = 5;
            this.label10.Text = "Номер";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label11.Location = new System.Drawing.Point(8, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 26);
            this.label11.TabIndex = 4;
            this.label11.Text = "Товар";
            // 
            // OrderLimitTB
            // 
            this.OrderLimitTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.OrderLimitTB.Location = new System.Drawing.Point(144, 144);
            this.OrderLimitTB.Name = "OrderLimitTB";
            this.OrderLimitTB.Size = new System.Drawing.Size(275, 29);
            this.OrderLimitTB.TabIndex = 2;
            // 
            // OrderNumTB
            // 
            this.OrderNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.OrderNumTB.Location = new System.Drawing.Point(144, 102);
            this.OrderNumTB.Name = "OrderNumTB";
            this.OrderNumTB.Size = new System.Drawing.Size(275, 29);
            this.OrderNumTB.TabIndex = 1;
            // 
            // OrderComTB
            // 
            this.OrderComTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.OrderComTB.Location = new System.Drawing.Point(144, 59);
            this.OrderComTB.Name = "OrderComTB";
            this.OrderComTB.Size = new System.Drawing.Size(275, 29);
            this.OrderComTB.TabIndex = 0;
            // 
            // ProvP
            // 
            this.ProvP.Controls.Add(this.label15);
            this.ProvP.Controls.Add(this.ProvPhoneTB);
            this.ProvP.Controls.Add(this.ProvCancelB);
            this.ProvP.Controls.Add(this.ProvOkB);
            this.ProvP.Controls.Add(this.label8);
            this.ProvP.Controls.Add(this.label12);
            this.ProvP.Controls.Add(this.label13);
            this.ProvP.Controls.Add(this.label14);
            this.ProvP.Controls.Add(this.ProvPriceTB);
            this.ProvP.Controls.Add(this.ProvAddressTB);
            this.ProvP.Controls.Add(this.ProvNameTB);
            this.ProvP.Controls.Add(this.ProvComTB);
            this.ProvP.Location = new System.Drawing.Point(1016, 455);
            this.ProvP.Name = "ProvP";
            this.ProvP.Size = new System.Drawing.Size(495, 280);
            this.ProvP.TabIndex = 22;
            this.ProvP.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label15.Location = new System.Drawing.Point(38, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 26);
            this.label15.TabIndex = 23;
            this.label15.Text = "Номер";
            // 
            // ProvPhoneTB
            // 
            this.ProvPhoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ProvPhoneTB.Location = new System.Drawing.Point(168, 152);
            this.ProvPhoneTB.Name = "ProvPhoneTB";
            this.ProvPhoneTB.Size = new System.Drawing.Size(293, 29);
            this.ProvPhoneTB.TabIndex = 22;
            // 
            // ProvCancelB
            // 
            this.ProvCancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.ProvCancelB.Location = new System.Drawing.Point(77, 206);
            this.ProvCancelB.Name = "ProvCancelB";
            this.ProvCancelB.Size = new System.Drawing.Size(117, 43);
            this.ProvCancelB.TabIndex = 21;
            this.ProvCancelB.Text = "Cancel";
            this.ProvCancelB.UseVisualStyleBackColor = true;
            this.ProvCancelB.Click += new System.EventHandler(this.ProvCancelB_Click);
            // 
            // ProvOkB
            // 
            this.ProvOkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.ProvOkB.Location = new System.Drawing.Point(270, 206);
            this.ProvOkB.Name = "ProvOkB";
            this.ProvOkB.Size = new System.Drawing.Size(117, 43);
            this.ProvOkB.TabIndex = 20;
            this.ProvOkB.Text = "OK";
            this.ProvOkB.UseVisualStyleBackColor = true;
            this.ProvOkB.Click += new System.EventHandler(this.ProvOkB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label8.Location = new System.Drawing.Point(38, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Прайс";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label12.Location = new System.Drawing.Point(38, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 26);
            this.label12.TabIndex = 6;
            this.label12.Text = "Название";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label13.Location = new System.Drawing.Point(38, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 26);
            this.label13.TabIndex = 5;
            this.label13.Text = "Адрес";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label14.Location = new System.Drawing.Point(38, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 26);
            this.label14.TabIndex = 4;
            this.label14.Text = "Товар";
            // 
            // ProvPriceTB
            // 
            this.ProvPriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ProvPriceTB.Location = new System.Drawing.Point(168, 117);
            this.ProvPriceTB.Name = "ProvPriceTB";
            this.ProvPriceTB.Size = new System.Drawing.Size(293, 29);
            this.ProvPriceTB.TabIndex = 3;
            // 
            // ProvAddressTB
            // 
            this.ProvAddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ProvAddressTB.Location = new System.Drawing.Point(168, 82);
            this.ProvAddressTB.Name = "ProvAddressTB";
            this.ProvAddressTB.Size = new System.Drawing.Size(293, 29);
            this.ProvAddressTB.TabIndex = 2;
            // 
            // ProvNameTB
            // 
            this.ProvNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ProvNameTB.Location = new System.Drawing.Point(168, 47);
            this.ProvNameTB.Name = "ProvNameTB";
            this.ProvNameTB.Size = new System.Drawing.Size(293, 29);
            this.ProvNameTB.TabIndex = 1;
            // 
            // ProvComTB
            // 
            this.ProvComTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ProvComTB.Location = new System.Drawing.Point(168, 12);
            this.ProvComTB.Name = "ProvComTB";
            this.ProvComTB.Size = new System.Drawing.Size(293, 29);
            this.ProvComTB.TabIndex = 0;
            // 
            // CustNameTB
            // 
            this.CustNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CustNameTB.Location = new System.Drawing.Point(183, 12);
            this.CustNameTB.Name = "CustNameTB";
            this.CustNameTB.Size = new System.Drawing.Size(293, 29);
            this.CustNameTB.TabIndex = 0;
            // 
            // CustAddressTB
            // 
            this.CustAddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CustAddressTB.Location = new System.Drawing.Point(183, 56);
            this.CustAddressTB.Name = "CustAddressTB";
            this.CustAddressTB.Size = new System.Drawing.Size(293, 29);
            this.CustAddressTB.TabIndex = 1;
            // 
            // CustBalanceTB
            // 
            this.CustBalanceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CustBalanceTB.Location = new System.Drawing.Point(183, 101);
            this.CustBalanceTB.Name = "CustBalanceTB";
            this.CustBalanceTB.Size = new System.Drawing.Size(293, 29);
            this.CustBalanceTB.TabIndex = 2;
            // 
            // CustPhoneTB
            // 
            this.CustPhoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CustPhoneTB.Location = new System.Drawing.Point(183, 149);
            this.CustPhoneTB.Name = "CustPhoneTB";
            this.CustPhoneTB.Size = new System.Drawing.Size(293, 29);
            this.CustPhoneTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(64, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(64, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.Location = new System.Drawing.Point(64, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Баланс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label7.Location = new System.Drawing.Point(64, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Телеофн";
            // 
            // CustOkB
            // 
            this.CustOkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.CustOkB.Location = new System.Drawing.Point(286, 206);
            this.CustOkB.Name = "CustOkB";
            this.CustOkB.Size = new System.Drawing.Size(117, 43);
            this.CustOkB.TabIndex = 20;
            this.CustOkB.Text = "OK";
            this.CustOkB.UseVisualStyleBackColor = true;
            this.CustOkB.Click += new System.EventHandler(this.CustOkB_Click);
            // 
            // CustCancelB
            // 
            this.CustCancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.CustCancelB.Location = new System.Drawing.Point(93, 206);
            this.CustCancelB.Name = "CustCancelB";
            this.CustCancelB.Size = new System.Drawing.Size(117, 43);
            this.CustCancelB.TabIndex = 21;
            this.CustCancelB.Text = "Cancel";
            this.CustCancelB.UseVisualStyleBackColor = true;
            this.CustCancelB.Click += new System.EventHandler(this.CustCancelB_Click);
            // 
            // CustP
            // 
            this.CustP.Controls.Add(this.CustCancelB);
            this.CustP.Controls.Add(this.CustOkB);
            this.CustP.Controls.Add(this.label7);
            this.CustP.Controls.Add(this.label6);
            this.CustP.Controls.Add(this.label5);
            this.CustP.Controls.Add(this.label4);
            this.CustP.Controls.Add(this.CustPhoneTB);
            this.CustP.Controls.Add(this.CustBalanceTB);
            this.CustP.Controls.Add(this.CustAddressTB);
            this.CustP.Controls.Add(this.CustNameTB);
            this.CustP.Location = new System.Drawing.Point(10, 455);
            this.CustP.Name = "CustP";
            this.CustP.Size = new System.Drawing.Size(514, 280);
            this.CustP.TabIndex = 19;
            this.CustP.Visible = false;
            // 
            // Cust_AddB
            // 
            this.Cust_AddB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Cust_AddB.Location = new System.Drawing.Point(56, 17);
            this.Cust_AddB.Name = "Cust_AddB";
            this.Cust_AddB.Size = new System.Drawing.Size(128, 43);
            this.Cust_AddB.TabIndex = 6;
            this.Cust_AddB.Text = "Добавить";
            this.Cust_AddB.UseVisualStyleBackColor = true;
            this.Cust_AddB.Click += new System.EventHandler(this.Cust_AddB_Click);
            // 
            // Cust_UpdateB
            // 
            this.Cust_UpdateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Cust_UpdateB.Location = new System.Drawing.Point(190, 17);
            this.Cust_UpdateB.Name = "Cust_UpdateB";
            this.Cust_UpdateB.Size = new System.Drawing.Size(126, 43);
            this.Cust_UpdateB.TabIndex = 9;
            this.Cust_UpdateB.Text = "Изменить";
            this.Cust_UpdateB.UseVisualStyleBackColor = true;
            this.Cust_UpdateB.Click += new System.EventHandler(this.Cust_UpdateB_Click);
            // 
            // Cust_RemoveB
            // 
            this.Cust_RemoveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Cust_RemoveB.Location = new System.Drawing.Point(322, 17);
            this.Cust_RemoveB.Name = "Cust_RemoveB";
            this.Cust_RemoveB.Size = new System.Drawing.Size(117, 43);
            this.Cust_RemoveB.TabIndex = 12;
            this.Cust_RemoveB.Text = "Удалить";
            this.Cust_RemoveB.UseVisualStyleBackColor = true;
            this.Cust_RemoveB.Click += new System.EventHandler(this.Cust_RemoveB_Click);
            // 
            // ToolP
            // 
            this.ToolP.Controls.Add(this.ProvRemoveB);
            this.ToolP.Controls.Add(this.Cust_RemoveB);
            this.ToolP.Controls.Add(this.ProvUpdateB);
            this.ToolP.Controls.Add(this.ProvAddB);
            this.ToolP.Controls.Add(this.Cust_UpdateB);
            this.ToolP.Controls.Add(this.OrderRemoveB);
            this.ToolP.Controls.Add(this.Cust_AddB);
            this.ToolP.Controls.Add(this.OrderUpdateB);
            this.ToolP.Controls.Add(this.OrderAddB);
            this.ToolP.Location = new System.Drawing.Point(12, 389);
            this.ToolP.Name = "ToolP";
            this.ToolP.Size = new System.Drawing.Size(1532, 66);
            this.ToolP.TabIndex = 20;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1370, 736);
            this.Controls.Add(this.ProvP);
            this.Controls.Add(this.OrderP);
            this.Controls.Add(this.ToolP);
            this.Controls.Add(this.CustP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProvidersT);
            this.Controls.Add(this.OrdersT);
            this.Controls.Add(this.CustomersT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvidersT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            this.OrderP.ResumeLayout(false);
            this.OrderP.PerformLayout();
            this.ProvP.ResumeLayout(false);
            this.ProvP.PerformLayout();
            this.CustP.ResumeLayout(false);
            this.CustP.PerformLayout();
            this.ToolP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersT;
        private System.Windows.Forms.DataGridView OrdersT;
        private System.Windows.Forms.DataGridView ProvidersT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ProvRemoveB;
        private System.Windows.Forms.Button ProvUpdateB;
        private System.Windows.Forms.Button ProvAddB;
        private System.Windows.Forms.Button OrderRemoveB;
        private System.Windows.Forms.Button OrderUpdateB;
        private System.Windows.Forms.Button OrderAddB;
        private System.Windows.Forms.Panel OrderP;
        private System.Windows.Forms.Button OrderCancelB;
        private System.Windows.Forms.Button OrderOkB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox OrderLimitTB;
        private System.Windows.Forms.TextBox OrderNumTB;
        private System.Windows.Forms.TextBox OrderComTB;
        private System.Windows.Forms.Panel ProvP;
        private System.Windows.Forms.Button ProvCancelB;
        private System.Windows.Forms.Button ProvOkB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ProvPriceTB;
        private System.Windows.Forms.TextBox ProvAddressTB;
        private System.Windows.Forms.TextBox ProvNameTB;
        private System.Windows.Forms.TextBox ProvComTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ProvPhoneTB;
        private System.Windows.Forms.TextBox CustNameTB;
        private System.Windows.Forms.TextBox CustAddressTB;
        private System.Windows.Forms.TextBox CustBalanceTB;
        private System.Windows.Forms.TextBox CustPhoneTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CustOkB;
        private System.Windows.Forms.Button CustCancelB;
        private System.Windows.Forms.Panel CustP;
        private System.Windows.Forms.Button Cust_AddB;
        private System.Windows.Forms.Button Cust_UpdateB;
        private System.Windows.Forms.Button Cust_RemoveB;
        private System.Windows.Forms.Panel ToolP;
        private System.Windows.Forms.ComboBox OrderCustTB;
        private System.Windows.Forms.Label label16;
        private bd_task222.DataSet dataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private bd_task222.DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneCsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private bd_task222.DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private bd_task222.DataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commondityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephonePrDataGridViewTextBoxColumn;
    }
}

