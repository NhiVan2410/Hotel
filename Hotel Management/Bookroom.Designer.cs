namespace Hotel_Management
{
    partial class Bookroom
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
            this.txtidbookroom = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dobpicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dobpicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboroomname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttyperoom = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtpriceroom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtstateroom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidroom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtidcustomer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnationcustomer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcardidcustomer = new System.Windows.Forms.TextBox();
            this.txtphonecustomer = new System.Windows.Forms.TextBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomKindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timecheckinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timecheckoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBookRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookRoomViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataDataSet6 = new Hotel_Management.HotelDataDataSet6();
            this.btndeleteroom = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddcustomer = new Guna.UI2.WinForms.Guna2Button();
            this.bookRoomViewTableAdapter = new Hotel_Management.HotelDataDataSet6TableAdapters.BookRoomViewTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookRoomViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.guna2Button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 138);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching Customer Info";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(42, 70);
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
            this.guna2Button1.Location = new System.Drawing.Point(247, 67);
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
            this.label5.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Name/Card ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtidbookroom);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.dobpicker1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dobpicker);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboroomname);
            this.groupBox2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 192);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room";
            // 
            // txtidbookroom
            // 
            this.txtidbookroom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidbookroom.Location = new System.Drawing.Point(40, 130);
            this.txtidbookroom.Name = "txtidbookroom";
            this.txtidbookroom.Size = new System.Drawing.Size(164, 27);
            this.txtidbookroom.TabIndex = 65;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(47, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 24);
            this.label17.TabIndex = 66;
            this.label17.Text = "ID Book Room :";
            // 
            // dobpicker1
            // 
            this.dobpicker1.Checked = true;
            this.dobpicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dobpicker1.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobpicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dobpicker1.Location = new System.Drawing.Point(236, 130);
            this.dobpicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dobpicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dobpicker1.Name = "dobpicker1";
            this.dobpicker1.Size = new System.Drawing.Size(190, 28);
            this.dobpicker1.TabIndex = 58;
            this.dobpicker1.Value = new System.DateTime(2024, 5, 17, 9, 45, 37, 234);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "Pay Date:";
            // 
            // dobpicker
            // 
            this.dobpicker.Checked = true;
            this.dobpicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dobpicker.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobpicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dobpicker.Location = new System.Drawing.Point(236, 64);
            this.dobpicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dobpicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dobpicker.Name = "dobpicker";
            this.dobpicker.Size = new System.Drawing.Size(190, 28);
            this.dobpicker.TabIndex = 56;
            this.dobpicker.Value = new System.DateTime(2024, 5, 17, 9, 45, 37, 234);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Received Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Room Name :";
            // 
            // comboroomname
            // 
            this.comboroomname.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboroomname.FormattingEnabled = true;
            this.comboroomname.Items.AddRange(new object[] {
            "Single Room",
            "Double Room ",
            "Deluxe Room "});
            this.comboroomname.Location = new System.Drawing.Point(40, 64);
            this.comboroomname.Name = "comboroomname";
            this.comboroomname.Size = new System.Drawing.Size(164, 28);
            this.comboroomname.TabIndex = 53;
            this.comboroomname.SelectedIndexChanged += new System.EventHandler(this.comboroomname_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(60, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 39);
            this.label2.TabIndex = 38;
            this.label2.Text = "Book Room";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttyperoom);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtpriceroom);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtstateroom);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtidroom);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(531, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 346);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room Info";
            // 
            // txttyperoom
            // 
            this.txttyperoom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttyperoom.Location = new System.Drawing.Point(45, 210);
            this.txttyperoom.Name = "txttyperoom";
            this.txttyperoom.Size = new System.Drawing.Size(182, 27);
            this.txttyperoom.TabIndex = 64;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(49, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 24);
            this.label16.TabIndex = 63;
            this.label16.Text = "Kind of Room :";
            // 
            // txtpriceroom
            // 
            this.txtpriceroom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpriceroom.Location = new System.Drawing.Point(45, 278);
            this.txtpriceroom.Name = "txtpriceroom";
            this.txtpriceroom.Size = new System.Drawing.Size(182, 27);
            this.txtpriceroom.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 59;
            this.label8.Text = "Price :";
            // 
            // txtstateroom
            // 
            this.txtstateroom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstateroom.Location = new System.Drawing.Point(45, 139);
            this.txtstateroom.Name = "txtstateroom";
            this.txtstateroom.Size = new System.Drawing.Size(182, 27);
            this.txtstateroom.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "State :";
            // 
            // txtidroom
            // 
            this.txtidroom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidroom.Location = new System.Drawing.Point(45, 74);
            this.txtidroom.Name = "txtidroom";
            this.txtidroom.Size = new System.Drawing.Size(182, 27);
            this.txtidroom.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "ID Room :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtidcustomer);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtnationcustomer);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtcardidcustomer);
            this.groupBox4.Controls.Add(this.txtphonecustomer);
            this.groupBox4.Controls.Add(this.txtcustomername);
            this.groupBox4.Controls.Add(this.guna2DateTimePicker2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(43, 459);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 297);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer Info";
            // 
            // txtidcustomer
            // 
            this.txtidcustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidcustomer.Location = new System.Drawing.Point(34, 231);
            this.txtidcustomer.Name = "txtidcustomer";
            this.txtidcustomer.Size = new System.Drawing.Size(168, 27);
            this.txtidcustomer.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = " ID Customer :";
            // 
            // txtnationcustomer
            // 
            this.txtnationcustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnationcustomer.Location = new System.Drawing.Point(250, 230);
            this.txtnationcustomer.Name = "txtnationcustomer";
            this.txtnationcustomer.Size = new System.Drawing.Size(168, 27);
            this.txtnationcustomer.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(252, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 24);
            this.label10.TabIndex = 43;
            this.label10.Text = "Nationality :";
            // 
            // txtcardidcustomer
            // 
            this.txtcardidcustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcardidcustomer.Location = new System.Drawing.Point(34, 154);
            this.txtcardidcustomer.Name = "txtcardidcustomer";
            this.txtcardidcustomer.Size = new System.Drawing.Size(162, 27);
            this.txtcardidcustomer.TabIndex = 39;
            // 
            // txtphonecustomer
            // 
            this.txtphonecustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphonecustomer.Location = new System.Drawing.Point(247, 154);
            this.txtphonecustomer.Name = "txtphonecustomer";
            this.txtphonecustomer.Size = new System.Drawing.Size(168, 27);
            this.txtphonecustomer.TabIndex = 38;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername.Location = new System.Drawing.Point(34, 76);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(162, 27);
            this.txtcustomername.TabIndex = 37;
            this.txtcustomername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(250, 75);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(168, 28);
            this.guna2DateTimePicker2.TabIndex = 7;
            this.guna2DateTimePicker2.Value = new System.DateTime(2024, 5, 17, 9, 45, 37, 234);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(247, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "Phone Number :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(250, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "Birthdate :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 24);
            this.label13.TabIndex = 3;
            this.label13.Text = " ID Card :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 24);
            this.label14.TabIndex = 2;
            this.label14.Text = "Name :";
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
            this.btnclose.Location = new System.Drawing.Point(596, 680);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(162, 36);
            this.btnclose.TabIndex = 63;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(832, 32);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(912, 724);
            this.groupBox5.TabIndex = 64;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Booking List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 55;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRoomDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.iDcardDataGridViewTextBoxColumn,
            this.roomKindDataGridViewTextBoxColumn,
            this.timecheckinDataGridViewTextBoxColumn,
            this.timecheckoutDataGridViewTextBoxColumn,
            this.iDCustomerDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.roomStateDataGridViewTextBoxColumn,
            this.iDBookRoomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookRoomViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 55;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(897, 694);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDRoomDataGridViewTextBoxColumn
            // 
            this.iDRoomDataGridViewTextBoxColumn.DataPropertyName = "ID_Room";
            this.iDRoomDataGridViewTextBoxColumn.HeaderText = "IDRoom";
            this.iDRoomDataGridViewTextBoxColumn.Name = "iDRoomDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // iDcardDataGridViewTextBoxColumn
            // 
            this.iDcardDataGridViewTextBoxColumn.DataPropertyName = "IDcard";
            this.iDcardDataGridViewTextBoxColumn.HeaderText = "IDcard";
            this.iDcardDataGridViewTextBoxColumn.Name = "iDcardDataGridViewTextBoxColumn";
            // 
            // roomKindDataGridViewTextBoxColumn
            // 
            this.roomKindDataGridViewTextBoxColumn.DataPropertyName = "RoomKind";
            this.roomKindDataGridViewTextBoxColumn.HeaderText = "RoomKind";
            this.roomKindDataGridViewTextBoxColumn.Name = "roomKindDataGridViewTextBoxColumn";
            // 
            // timecheckinDataGridViewTextBoxColumn
            // 
            this.timecheckinDataGridViewTextBoxColumn.DataPropertyName = "Timecheckin";
            this.timecheckinDataGridViewTextBoxColumn.HeaderText = "Timecheckin";
            this.timecheckinDataGridViewTextBoxColumn.Name = "timecheckinDataGridViewTextBoxColumn";
            // 
            // timecheckoutDataGridViewTextBoxColumn
            // 
            this.timecheckoutDataGridViewTextBoxColumn.DataPropertyName = "Timecheckout";
            this.timecheckoutDataGridViewTextBoxColumn.HeaderText = "Timecheckout";
            this.timecheckoutDataGridViewTextBoxColumn.Name = "timecheckoutDataGridViewTextBoxColumn";
            // 
            // iDCustomerDataGridViewTextBoxColumn
            // 
            this.iDCustomerDataGridViewTextBoxColumn.DataPropertyName = "ID_Customer";
            this.iDCustomerDataGridViewTextBoxColumn.HeaderText = "IDCustomer";
            this.iDCustomerDataGridViewTextBoxColumn.Name = "iDCustomerDataGridViewTextBoxColumn";
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            // 
            // roomStateDataGridViewTextBoxColumn
            // 
            this.roomStateDataGridViewTextBoxColumn.DataPropertyName = "RoomState";
            this.roomStateDataGridViewTextBoxColumn.HeaderText = "RoomState";
            this.roomStateDataGridViewTextBoxColumn.Name = "roomStateDataGridViewTextBoxColumn";
            // 
            // iDBookRoomDataGridViewTextBoxColumn
            // 
            this.iDBookRoomDataGridViewTextBoxColumn.DataPropertyName = "ID_BookRoom";
            this.iDBookRoomDataGridViewTextBoxColumn.HeaderText = "IDBookRoom";
            this.iDBookRoomDataGridViewTextBoxColumn.Name = "iDBookRoomDataGridViewTextBoxColumn";
            // 
            // bookRoomViewBindingSource
            // 
            this.bookRoomViewBindingSource.DataMember = "BookRoomView";
            this.bookRoomViewBindingSource.DataSource = this.hotelDataDataSet6;
            // 
            // hotelDataDataSet6
            // 
            this.hotelDataDataSet6.DataSetName = "HotelDataDataSet6";
            this.hotelDataDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btndeleteroom
            // 
            this.btndeleteroom.BorderRadius = 15;
            this.btndeleteroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndeleteroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndeleteroom.FillColor = System.Drawing.Color.OrangeRed;
            this.btndeleteroom.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteroom.ForeColor = System.Drawing.Color.Black;
            this.btndeleteroom.Image = global::Hotel_Management.Properties.Resources.bin_484611;
            this.btndeleteroom.Location = new System.Drawing.Point(596, 598);
            this.btndeleteroom.Name = "btndeleteroom";
            this.btndeleteroom.Size = new System.Drawing.Size(162, 36);
            this.btndeleteroom.TabIndex = 62;
            this.btndeleteroom.Text = "Delete";
            this.btndeleteroom.Click += new System.EventHandler(this.btndeleteroom_Click);
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
            this.btnaddcustomer.Location = new System.Drawing.Point(596, 508);
            this.btnaddcustomer.Name = "btnaddcustomer";
            this.btnaddcustomer.Size = new System.Drawing.Size(162, 36);
            this.btnaddcustomer.TabIndex = 61;
            this.btnaddcustomer.Text = "Check In";
            this.btnaddcustomer.Click += new System.EventHandler(this.btnaddcustomer_Click);
            // 
            // bookRoomViewTableAdapter
            // 
            this.bookRoomViewTableAdapter.ClearBeforeFill = true;
            // 
            // Bookroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 770);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndeleteroom);
            this.Controls.Add(this.btnaddcustomer);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bookroom";
            this.Text = "Bookroom";
            this.Load += new System.EventHandler(this.Bookroom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookRoomViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboroomname;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dobpicker1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dobpicker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtidroom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstateroom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpriceroom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtnationcustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcardidcustomer;
        private System.Windows.Forms.TextBox txtphonecustomer;
        private System.Windows.Forms.TextBox txtcustomername;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2Button btndeleteroom;
        private Guna.UI2.WinForms.Guna2Button btnaddcustomer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txttyperoom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataDataSet6 hotelDataDataSet6;
        private System.Windows.Forms.BindingSource bookRoomViewBindingSource;
        private HotelDataDataSet6TableAdapters.BookRoomViewTableAdapter bookRoomViewTableAdapter;
        private System.Windows.Forms.TextBox txtidbookroom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomKindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timecheckinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timecheckoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBookRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtidcustomer;
        private System.Windows.Forms.Label label9;
    }
}