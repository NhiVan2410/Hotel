namespace Hotel_Management
{
    partial class EmployeeManagement
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagridviewlistemployee = new System.Windows.Forms.DataGridView();
            this.iDEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataDataSet5 = new Hotel_Management.HotelDataDataSet5();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaddressemployee = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboroleemployee = new System.Windows.Forms.ComboBox();
            this.combogenderemployee = new System.Windows.Forms.ComboBox();
            this.txtnameEmployee = new System.Windows.Forms.TextBox();
            this.txtphoneemployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dobpicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtidemployee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpasswordemployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusernameemployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.btndeletecustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdatecustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddcustomer = new Guna.UI2.WinForms.Guna2Button();
            this.hotelDataDataSet4 = new Hotel_Management.HotelDataDataSet4();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Hotel_Management.HotelDataDataSet4TableAdapters.EmployeeTableAdapter();
            this.employeeTableAdapter1 = new Hotel_Management.HotelDataDataSet5TableAdapters.EmployeeTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewlistemployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagridviewlistemployee);
            this.groupBox2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(611, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 702);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Employee";
            // 
            // datagridviewlistemployee
            // 
            this.datagridviewlistemployee.AutoGenerateColumns = false;
            this.datagridviewlistemployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewlistemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewlistemployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmployeeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.Username,
            this.Password});
            this.datagridviewlistemployee.DataSource = this.employeeBindingSource1;
            this.datagridviewlistemployee.Location = new System.Drawing.Point(4, 29);
            this.datagridviewlistemployee.Name = "datagridviewlistemployee";
            this.datagridviewlistemployee.RowTemplate.Height = 35;
            this.datagridviewlistemployee.Size = new System.Drawing.Size(966, 667);
            this.datagridviewlistemployee.TabIndex = 0;
            this.datagridviewlistemployee.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridviewlistemployee_RowHeaderMouseClick_1);
            // 
            // iDEmployeeDataGridViewTextBoxColumn
            // 
            this.iDEmployeeDataGridViewTextBoxColumn.DataPropertyName = "ID_Employee";
            this.iDEmployeeDataGridViewTextBoxColumn.HeaderText = "ID Employee";
            this.iDEmployeeDataGridViewTextBoxColumn.Name = "iDEmployeeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.hotelDataDataSet5;
            // 
            // hotelDataDataSet5
            // 
            this.hotelDataDataSet5.DataSetName = "HotelDataDataSet5";
            this.hotelDataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(40, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 39);
            this.label2.TabIndex = 25;
            this.label2.Text = "Manager Employee";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.guna2Button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 192);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(42, 82);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(162, 27);
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
            this.guna2Button1.Location = new System.Drawing.Point(42, 126);
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
            this.label5.Size = new System.Drawing.Size(71, 26);
            this.label5.TabIndex = 32;
            this.label5.Text = "Search :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtaddressemployee);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboroleemployee);
            this.groupBox3.Controls.Add(this.combogenderemployee);
            this.groupBox3.Controls.Add(this.txtnameEmployee);
            this.groupBox3.Controls.Add(this.txtphoneemployee);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dobpicker);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(316, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 519);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 24);
            this.label8.TabIndex = 54;
            this.label8.Text = "Role :";
            // 
            // txtaddressemployee
            // 
            this.txtaddressemployee.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddressemployee.Location = new System.Drawing.Point(39, 404);
            this.txtaddressemployee.Multiline = true;
            this.txtaddressemployee.Name = "txtaddressemployee";
            this.txtaddressemployee.Size = new System.Drawing.Size(204, 91);
            this.txtaddressemployee.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 24);
            this.label10.TabIndex = 51;
            this.label10.Text = "Address :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 24);
            this.label9.TabIndex = 46;
            this.label9.Text = "Gender :";
            // 
            // comboroleemployee
            // 
            this.comboroleemployee.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboroleemployee.FormattingEnabled = true;
            this.comboroleemployee.Items.AddRange(new object[] {
            "Manager",
            "Receipter",
            "Labor"});
            this.comboroleemployee.Location = new System.Drawing.Point(39, 336);
            this.comboroleemployee.Name = "comboroleemployee";
            this.comboroleemployee.Size = new System.Drawing.Size(204, 28);
            this.comboroleemployee.TabIndex = 53;
            // 
            // combogenderemployee
            // 
            this.combogenderemployee.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combogenderemployee.FormattingEnabled = true;
            this.combogenderemployee.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.combogenderemployee.Location = new System.Drawing.Point(41, 143);
            this.combogenderemployee.Name = "combogenderemployee";
            this.combogenderemployee.Size = new System.Drawing.Size(204, 28);
            this.combogenderemployee.TabIndex = 45;
            // 
            // txtnameEmployee
            // 
            this.txtnameEmployee.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameEmployee.Location = new System.Drawing.Point(41, 81);
            this.txtnameEmployee.Name = "txtnameEmployee";
            this.txtnameEmployee.Size = new System.Drawing.Size(204, 27);
            this.txtnameEmployee.TabIndex = 44;
            this.txtnameEmployee.TextChanged += new System.EventHandler(this.txtnameEmployee_TextChanged);
            // 
            // txtphoneemployee
            // 
            this.txtphoneemployee.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneemployee.Location = new System.Drawing.Point(41, 272);
            this.txtphoneemployee.Name = "txtphoneemployee";
            this.txtphoneemployee.Size = new System.Drawing.Size(204, 27);
            this.txtphoneemployee.TabIndex = 50;
            this.txtphoneemployee.TextChanged += new System.EventHandler(this.txtphonecustomer_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Name :";
            // 
            // dobpicker
            // 
            this.dobpicker.Checked = true;
            this.dobpicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dobpicker.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobpicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dobpicker.Location = new System.Drawing.Point(41, 206);
            this.dobpicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dobpicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dobpicker.Name = "dobpicker";
            this.dobpicker.Size = new System.Drawing.Size(204, 28);
            this.dobpicker.TabIndex = 49;
            this.dobpicker.Value = new System.DateTime(2024, 5, 17, 9, 45, 37, 234);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "Phone Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Birthdate :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtidemployee);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtpasswordemployee);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtusernameemployee);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(43, 292);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 312);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account Employee";
            // 
            // txtidemployee
            // 
            this.txtidemployee.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidemployee.Location = new System.Drawing.Point(42, 96);
            this.txtidemployee.Name = "txtidemployee";
            this.txtidemployee.Size = new System.Drawing.Size(162, 27);
            this.txtidemployee.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 24);
            this.label11.TabIndex = 55;
            this.label11.Text = "ID :";
            // 
            // txtpasswordemployee
            // 
            this.txtpasswordemployee.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswordemployee.Location = new System.Drawing.Point(42, 221);
            this.txtpasswordemployee.Name = "txtpasswordemployee";
            this.txtpasswordemployee.Size = new System.Drawing.Size(162, 27);
            this.txtpasswordemployee.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Password :";
            // 
            // txtusernameemployee
            // 
            this.txtusernameemployee.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusernameemployee.Location = new System.Drawing.Point(42, 160);
            this.txtusernameemployee.Name = "txtusernameemployee";
            this.txtusernameemployee.Size = new System.Drawing.Size(162, 27);
            this.txtusernameemployee.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "User Name :";
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
            this.btnclose.Location = new System.Drawing.Point(357, 688);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(162, 36);
            this.btnclose.TabIndex = 45;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.guna2Button2_Click);
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
            this.btndeletecustomer.Location = new System.Drawing.Point(108, 688);
            this.btndeletecustomer.Name = "btndeletecustomer";
            this.btndeletecustomer.Size = new System.Drawing.Size(162, 36);
            this.btndeletecustomer.TabIndex = 43;
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
            this.btnupdatecustomer.Location = new System.Drawing.Point(357, 632);
            this.btnupdatecustomer.Name = "btnupdatecustomer";
            this.btnupdatecustomer.Size = new System.Drawing.Size(162, 36);
            this.btnupdatecustomer.TabIndex = 42;
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
            this.btnaddcustomer.Location = new System.Drawing.Point(108, 632);
            this.btnaddcustomer.Name = "btnaddcustomer";
            this.btnaddcustomer.Size = new System.Drawing.Size(162, 36);
            this.btnaddcustomer.TabIndex = 41;
            this.btnaddcustomer.Text = "Add";
            this.btnaddcustomer.Click += new System.EventHandler(this.btnaddcustomer_Click);
            // 
            // hotelDataDataSet4
            // 
            this.hotelDataDataSet4.DataSetName = "HotelDataDataSet4";
            this.hotelDataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.hotelDataDataSet4;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 736);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndeletecustomer);
            this.Controls.Add(this.btnupdatecustomer);
            this.Controls.Add(this.btnaddcustomer);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewlistemployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combogenderemployee;
        private System.Windows.Forms.TextBox txtnameEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaddressemployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtphoneemployee;
        private Guna.UI2.WinForms.Guna2DateTimePicker dobpicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpasswordemployee;
        private System.Windows.Forms.ComboBox comboroleemployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusernameemployee;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btndeletecustomer;
        private Guna.UI2.WinForms.Guna2Button btnupdatecustomer;
        private Guna.UI2.WinForms.Guna2Button btnaddcustomer;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.DataGridView datagridviewlistemployee;
        private HotelDataDataSet4 hotelDataDataSet4;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private HotelDataDataSet4TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox txtidemployee;
        private System.Windows.Forms.Label label11;
        private HotelDataDataSet5 hotelDataDataSet5;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private HotelDataDataSet5TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}