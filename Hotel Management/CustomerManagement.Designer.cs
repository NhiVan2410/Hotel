namespace Hotel_Management
{
    partial class CustomerManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagridviewlistcustomer = new System.Windows.Forms.DataGridView();
            this.iDCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataDataSet1 = new Hotel_Management.HotelDataDataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataDataSet = new Hotel_Management.HotelDataDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtidcustomer = new System.Windows.Forms.TextBox();
            this.txtnationcustomer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.combogendercustomer = new System.Windows.Forms.ComboBox();
            this.txtcardidcustomer = new System.Windows.Forms.TextBox();
            this.txtphonecustomer = new System.Windows.Forms.TextBox();
            this.txtnamecustomer = new System.Windows.Forms.TextBox();
            this.dobpicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.btndeletecustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdatecustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddcustomer = new Guna.UI2.WinForms.Guna2Button();
            this.customerTableAdapter = new Hotel_Management.HotelDataDataSetTableAdapters.CustomerTableAdapter();
            this.customerTableAdapter1 = new Hotel_Management.HotelDataDataSet1TableAdapters.CustomerTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewlistcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.guna2Button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(32, 82);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(188, 27);
            this.txtsearch.TabIndex = 36;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Hotel_Management.Properties.Resources._9004762_search_find_zoom_magnifier_icon;
            this.guna2Button1.Location = new System.Drawing.Point(256, 78);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(162, 36);
            this.guna2Button1.TabIndex = 35;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 32;
            this.label5.Text = "Search by :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagridviewlistcustomer);
            this.groupBox2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(533, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(931, 694);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Customer";
            // 
            // datagridviewlistcustomer
            // 
            this.datagridviewlistcustomer.AutoGenerateColumns = false;
            this.datagridviewlistcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewlistcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewlistcustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCustomerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.IDcard,
            this.genderDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn});
            this.datagridviewlistcustomer.DataSource = this.customerBindingSource1;
            this.datagridviewlistcustomer.Location = new System.Drawing.Point(8, 29);
            this.datagridviewlistcustomer.Name = "datagridviewlistcustomer";
            this.datagridviewlistcustomer.RowTemplate.Height = 35;
            this.datagridviewlistcustomer.Size = new System.Drawing.Size(917, 659);
            this.datagridviewlistcustomer.TabIndex = 0;
            this.datagridviewlistcustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridviewlistcustomer_RowHeaderMouseClick_1);
            // 
            // iDCustomerDataGridViewTextBoxColumn
            // 
            this.iDCustomerDataGridViewTextBoxColumn.DataPropertyName = "ID_Customer";
            this.iDCustomerDataGridViewTextBoxColumn.HeaderText = "ID Customer";
            this.iDCustomerDataGridViewTextBoxColumn.Name = "iDCustomerDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // IDcard
            // 
            this.IDcard.DataPropertyName = "IDcard";
            this.IDcard.HeaderText = "ID Card";
            this.IDcard.Name = "IDcard";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.hotelDataDataSet1;
            // 
            // hotelDataDataSet1
            // 
            this.hotelDataDataSet1.DataSetName = "HotelDataDataSet1";
            this.hotelDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.hotelDataDataSet;
            // 
            // hotelDataDataSet
            // 
            this.hotelDataDataSet.DataSetName = "HotelDataDataSet";
            this.hotelDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtidcustomer);
            this.groupBox3.Controls.Add(this.txtnationcustomer);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.combogendercustomer);
            this.groupBox3.Controls.Add(this.txtcardidcustomer);
            this.groupBox3.Controls.Add(this.txtphonecustomer);
            this.groupBox3.Controls.Add(this.txtnamecustomer);
            this.groupBox3.Controls.Add(this.dobpicker);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(50, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 353);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Info";
            // 
            // txtidcustomer
            // 
            this.txtidcustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidcustomer.Location = new System.Drawing.Point(30, 76);
            this.txtidcustomer.Name = "txtidcustomer";
            this.txtidcustomer.Size = new System.Drawing.Size(162, 27);
            this.txtidcustomer.TabIndex = 45;
            // 
            // txtnationcustomer
            // 
            this.txtnationcustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnationcustomer.Location = new System.Drawing.Point(250, 225);
            this.txtnationcustomer.Name = "txtnationcustomer";
            this.txtnationcustomer.Size = new System.Drawing.Size(168, 27);
            this.txtnationcustomer.TabIndex = 44;
            this.txtnationcustomer.TextChanged += new System.EventHandler(this.txtnationcustomer_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(252, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 24);
            this.label10.TabIndex = 43;
            this.label10.Text = "Nationality :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 24);
            this.label9.TabIndex = 42;
            this.label9.Text = "Gender :";
            // 
            // combogendercustomer
            // 
            this.combogendercustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combogendercustomer.FormattingEnabled = true;
            this.combogendercustomer.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.combogendercustomer.Location = new System.Drawing.Point(30, 300);
            this.combogendercustomer.Name = "combogendercustomer";
            this.combogendercustomer.Size = new System.Drawing.Size(164, 28);
            this.combogendercustomer.TabIndex = 41;
            // 
            // txtcardidcustomer
            // 
            this.txtcardidcustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcardidcustomer.Location = new System.Drawing.Point(30, 225);
            this.txtcardidcustomer.Name = "txtcardidcustomer";
            this.txtcardidcustomer.Size = new System.Drawing.Size(162, 27);
            this.txtcardidcustomer.TabIndex = 39;
            this.txtcardidcustomer.TextChanged += new System.EventHandler(this.txtcardidcustomer_TextChanged);
            // 
            // txtphonecustomer
            // 
            this.txtphonecustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphonecustomer.Location = new System.Drawing.Point(250, 147);
            this.txtphonecustomer.Name = "txtphonecustomer";
            this.txtphonecustomer.Size = new System.Drawing.Size(168, 27);
            this.txtphonecustomer.TabIndex = 38;
            this.txtphonecustomer.TextChanged += new System.EventHandler(this.txtphonecustomer_TextChanged);
            // 
            // txtnamecustomer
            // 
            this.txtnamecustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamecustomer.Location = new System.Drawing.Point(30, 147);
            this.txtnamecustomer.Name = "txtnamecustomer";
            this.txtnamecustomer.Size = new System.Drawing.Size(162, 27);
            this.txtnamecustomer.TabIndex = 37;
            this.txtnamecustomer.TextChanged += new System.EventHandler(this.txtnamecustomer_TextChanged);
            // 
            // dobpicker
            // 
            this.dobpicker.Checked = true;
            this.dobpicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dobpicker.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobpicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dobpicker.Location = new System.Drawing.Point(250, 75);
            this.dobpicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dobpicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dobpicker.Name = "dobpicker";
            this.dobpicker.Size = new System.Drawing.Size(168, 28);
            this.dobpicker.TabIndex = 7;
            this.dobpicker.Value = new System.DateTime(2024, 5, 17, 9, 45, 37, 234);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Phone Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Birthdate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = " ID Card :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Customer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(43, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 39);
            this.label2.TabIndex = 24;
            this.label2.Text = "Manager Customer";
            // 
            // btnclose
            // 
            this.btnclose.BorderRadius = 15;
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnclose.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(304, 666);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(162, 36);
            this.btnclose.TabIndex = 40;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btndeletecustomer
            // 
            this.btndeletecustomer.BorderRadius = 15;
            this.btndeletecustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndeletecustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndeletecustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndeletecustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndeletecustomer.FillColor = System.Drawing.Color.OrangeRed;
            this.btndeletecustomer.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletecustomer.ForeColor = System.Drawing.Color.Black;
            this.btndeletecustomer.Image = global::Hotel_Management.Properties.Resources.bin_484611;
            this.btndeletecustomer.Location = new System.Drawing.Point(90, 666);
            this.btndeletecustomer.Name = "btndeletecustomer";
            this.btndeletecustomer.Size = new System.Drawing.Size(162, 36);
            this.btndeletecustomer.TabIndex = 39;
            this.btndeletecustomer.Text = "Delete";
            this.btndeletecustomer.Click += new System.EventHandler(this.btndeletecustomer_Click);
            // 
            // btnupdatecustomer
            // 
            this.btnupdatecustomer.BorderRadius = 15;
            this.btnupdatecustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupdatecustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupdatecustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdatecustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupdatecustomer.FillColor = System.Drawing.Color.PaleGoldenrod;
            this.btnupdatecustomer.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatecustomer.ForeColor = System.Drawing.Color.Black;
            this.btnupdatecustomer.Image = global::Hotel_Management.Properties.Resources.save_4223793;
            this.btnupdatecustomer.Location = new System.Drawing.Point(304, 610);
            this.btnupdatecustomer.Name = "btnupdatecustomer";
            this.btnupdatecustomer.Size = new System.Drawing.Size(162, 36);
            this.btnupdatecustomer.TabIndex = 38;
            this.btnupdatecustomer.Text = "Update";
            this.btnupdatecustomer.Click += new System.EventHandler(this.btnupdatecustomer_Click);
            // 
            // btnaddcustomer
            // 
            this.btnaddcustomer.BorderRadius = 15;
            this.btnaddcustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddcustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddcustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddcustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddcustomer.FillColor = System.Drawing.Color.LightGreen;
            this.btnaddcustomer.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcustomer.ForeColor = System.Drawing.Color.Black;
            this.btnaddcustomer.Image = global::Hotel_Management.Properties.Resources.add_5372888;
            this.btnaddcustomer.Location = new System.Drawing.Point(90, 610);
            this.btnaddcustomer.Name = "btnaddcustomer";
            this.btnaddcustomer.Size = new System.Drawing.Size(162, 36);
            this.btnaddcustomer.TabIndex = 37;
            this.btnaddcustomer.Text = "Add";
            this.btnaddcustomer.Click += new System.EventHandler(this.btnaddcustomer_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 730);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndeletecustomer);
            this.Controls.Add(this.btnupdatecustomer);
            this.Controls.Add(this.btnaddcustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewlistcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dobpicker;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combogendercustomer;
        private System.Windows.Forms.TextBox txtcardidcustomer;
        private System.Windows.Forms.TextBox txtphonecustomer;
        private System.Windows.Forms.TextBox txtnamecustomer;
        private System.Windows.Forms.TextBox txtnationcustomer;
        private Guna.UI2.WinForms.Guna2Button btnaddcustomer;
        private Guna.UI2.WinForms.Guna2Button btnupdatecustomer;
        private Guna.UI2.WinForms.Guna2Button btndeletecustomer;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.TextBox txtidcustomer;
        private HotelDataDataSet hotelDataDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private HotelDataDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridView datagridviewlistcustomer;
        private HotelDataDataSet1 hotelDataDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private HotelDataDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
    }
}