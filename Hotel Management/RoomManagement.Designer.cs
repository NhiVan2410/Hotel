namespace Hotel_Management
{
    partial class RoomManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidroom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combotyperoom = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combostateroom = new System.Windows.Forms.ComboBox();
            this.txtpriceroom = new System.Windows.Forms.TextBox();
            this.txtnameroom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datagridviewroomlist = new System.Windows.Forms.DataGridView();
            this.iDRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataDataSet3 = new Hotel_Management.HotelDataDataSet3();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.btndeleteroom = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdateroom = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddroom = new Guna.UI2.WinForms.Guna2Button();
            this.roomTableAdapter = new Hotel_Management.HotelDataDataSet3TableAdapters.RoomTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewroomlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(54, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 39);
            this.label2.TabIndex = 25;
            this.label2.Text = "Manager Room";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.guna2Button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 122);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(38, 68);
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
            this.guna2Button1.Location = new System.Drawing.Point(252, 63);
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
            this.label5.Location = new System.Drawing.Point(43, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "ID/Name Room :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtidroom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.combotyperoom);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.combostateroom);
            this.groupBox2.Controls.Add(this.txtpriceroom);
            this.groupBox2.Controls.Add(this.txtnameroom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(61, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 273);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Info";
            // 
            // txtidroom
            // 
            this.txtidroom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidroom.Location = new System.Drawing.Point(36, 70);
            this.txtidroom.Name = "txtidroom";
            this.txtidroom.Size = new System.Drawing.Size(162, 27);
            this.txtidroom.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Kind of room :";
            // 
            // combotyperoom
            // 
            this.combotyperoom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotyperoom.FormattingEnabled = true;
            this.combotyperoom.Items.AddRange(new object[] {
            "Single Room",
            "Double Room ",
            "Deluxe Room "});
            this.combotyperoom.Location = new System.Drawing.Point(248, 69);
            this.combotyperoom.Name = "combotyperoom";
            this.combotyperoom.Size = new System.Drawing.Size(164, 28);
            this.combotyperoom.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 24);
            this.label9.TabIndex = 50;
            this.label9.Text = "State :";
            // 
            // combostateroom
            // 
            this.combostateroom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combostateroom.FormattingEnabled = true;
            this.combostateroom.Items.AddRange(new object[] {
            "Busy",
            "Free"});
            this.combostateroom.Location = new System.Drawing.Point(38, 216);
            this.combostateroom.Name = "combostateroom";
            this.combostateroom.Size = new System.Drawing.Size(164, 28);
            this.combostateroom.TabIndex = 49;
            // 
            // txtpriceroom
            // 
            this.txtpriceroom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpriceroom.Location = new System.Drawing.Point(248, 141);
            this.txtpriceroom.Name = "txtpriceroom";
            this.txtpriceroom.Size = new System.Drawing.Size(162, 27);
            this.txtpriceroom.TabIndex = 48;
            this.txtpriceroom.TextChanged += new System.EventHandler(this.txtcardidcustomer_TextChanged);
            // 
            // txtnameroom
            // 
            this.txtnameroom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameroom.Location = new System.Drawing.Point(36, 141);
            this.txtnameroom.Name = "txtnameroom";
            this.txtnameroom.Size = new System.Drawing.Size(162, 27);
            this.txtnameroom.TabIndex = 47;
            this.txtnameroom.TextChanged += new System.EventHandler(this.txtnameroom_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Name Room :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "ID Room :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datagridviewroomlist);
            this.groupBox3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(545, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(655, 646);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List Room";
            // 
            // datagridviewroomlist
            // 
            this.datagridviewroomlist.AutoGenerateColumns = false;
            this.datagridviewroomlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewroomlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewroomlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRoomDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.kindDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.datagridviewroomlist.DataSource = this.roomBindingSource;
            this.datagridviewroomlist.Location = new System.Drawing.Point(0, 32);
            this.datagridviewroomlist.Name = "datagridviewroomlist";
            this.datagridviewroomlist.RowTemplate.Height = 35;
            this.datagridviewroomlist.Size = new System.Drawing.Size(654, 615);
            this.datagridviewroomlist.TabIndex = 0;
            this.datagridviewroomlist.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridviewroomlist_RowHeaderMouseClick_1);
            // 
            // iDRoomDataGridViewTextBoxColumn
            // 
            this.iDRoomDataGridViewTextBoxColumn.DataPropertyName = "ID_Room";
            this.iDRoomDataGridViewTextBoxColumn.HeaderText = "ID Room";
            this.iDRoomDataGridViewTextBoxColumn.Name = "iDRoomDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // kindDataGridViewTextBoxColumn
            // 
            this.kindDataGridViewTextBoxColumn.DataPropertyName = "Kind";
            this.kindDataGridViewTextBoxColumn.HeaderText = "Kind";
            this.kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotelDataDataSet3;
            // 
            // hotelDataDataSet3
            // 
            this.hotelDataDataSet3.DataSetName = "HotelDataDataSet3";
            this.hotelDataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnclose.Location = new System.Drawing.Point(313, 631);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(162, 36);
            this.btnclose.TabIndex = 44;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
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
            this.btndeleteroom.Location = new System.Drawing.Point(99, 631);
            this.btndeleteroom.Name = "btndeleteroom";
            this.btndeleteroom.Size = new System.Drawing.Size(162, 36);
            this.btndeleteroom.TabIndex = 43;
            this.btndeleteroom.Text = "Delete";
            this.btndeleteroom.Click += new System.EventHandler(this.btndeleteroom_Click);
            // 
            // btnupdateroom
            // 
            this.btnupdateroom.BorderRadius = 15;
            this.btnupdateroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupdateroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupdateroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdateroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupdateroom.FillColor = System.Drawing.Color.PaleGoldenrod;
            this.btnupdateroom.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateroom.ForeColor = System.Drawing.Color.Black;
            this.btnupdateroom.Image = global::Hotel_Management.Properties.Resources.save_4223793;
            this.btnupdateroom.Location = new System.Drawing.Point(313, 575);
            this.btnupdateroom.Name = "btnupdateroom";
            this.btnupdateroom.Size = new System.Drawing.Size(162, 36);
            this.btnupdateroom.TabIndex = 42;
            this.btnupdateroom.Text = "Update";
            this.btnupdateroom.Click += new System.EventHandler(this.btnupdateroom_Click);
            // 
            // btnaddroom
            // 
            this.btnaddroom.BorderRadius = 15;
            this.btnaddroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddroom.FillColor = System.Drawing.Color.LightGreen;
            this.btnaddroom.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddroom.ForeColor = System.Drawing.Color.Black;
            this.btnaddroom.Image = global::Hotel_Management.Properties.Resources.add_5372888;
            this.btnaddroom.Location = new System.Drawing.Point(99, 575);
            this.btnaddroom.Name = "btnaddroom";
            this.btnaddroom.Size = new System.Drawing.Size(162, 36);
            this.btnaddroom.TabIndex = 41;
            this.btnaddroom.Text = "Add";
            this.btnaddroom.Click += new System.EventHandler(this.btnaddcustomer_Click);
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 710);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndeleteroom);
            this.Controls.Add(this.btnupdateroom);
            this.Controls.Add(this.btnaddroom);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "RoomManagement";
            this.Text = "RoomManagement";
            this.Load += new System.EventHandler(this.RoomManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewroomlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combostateroom;
        private System.Windows.Forms.TextBox txtpriceroom;
        private System.Windows.Forms.TextBox txtnameroom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combotyperoom;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2Button btndeleteroom;
        private Guna.UI2.WinForms.Guna2Button btnupdateroom;
        private Guna.UI2.WinForms.Guna2Button btnaddroom;
        private System.Windows.Forms.TextBox txtidroom;
        private System.Windows.Forms.DataGridView datagridviewroomlist;
        private HotelDataDataSet3 hotelDataDataSet3;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotelDataDataSet3TableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}