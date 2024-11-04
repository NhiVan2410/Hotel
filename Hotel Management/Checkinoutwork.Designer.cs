namespace Hotel_Management
{
    partial class Checkinoutwork
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
            this.btnaddcustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btndeletecustomer = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidca = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hotelDataDataSet11 = new Hotel_Management.HotelDataDataSet11();
            this.calendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendarTableAdapter = new Hotel_Management.HotelDataDataSet11TableAdapters.CalendarTableAdapter();
            this.iDCalendarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDShiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelDataDataSet12 = new Hotel_Management.HotelDataDataSet12();
            this.checkinoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkinoutTableAdapter = new Hotel_Management.HotelDataDataSet12TableAdapters.CheckinoutTableAdapter();
            this.iDCheckinoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCalendarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCheckinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCheckoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcheck = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinoutBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnaddcustomer.Location = new System.Drawing.Point(259, 114);
            this.btnaddcustomer.Name = "btnaddcustomer";
            this.btnaddcustomer.Size = new System.Drawing.Size(162, 36);
            this.btnaddcustomer.TabIndex = 38;
            this.btnaddcustomer.Text = "Check In";
            this.btnaddcustomer.Click += new System.EventHandler(this.btnaddcustomer_Click);
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
            this.btndeletecustomer.Image = global::Hotel_Management.Properties.Resources._9004773_tick_check_mark_accept_icon;
            this.btndeletecustomer.Location = new System.Drawing.Point(259, 200);
            this.btndeletecustomer.Name = "btndeletecustomer";
            this.btndeletecustomer.Size = new System.Drawing.Size(162, 36);
            this.btndeletecustomer.TabIndex = 44;
            this.btndeletecustomer.Text = "Check Out ";
            this.btndeletecustomer.Click += new System.EventHandler(this.btndeletecustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(34, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 39);
            this.label2.TabIndex = 48;
            this.label2.Text = "Checkin/out";
            // 
            // txtidem
            // 
            this.txtidem.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidem.Location = new System.Drawing.Point(47, 163);
            this.txtidem.Name = "txtidem";
            this.txtidem.Size = new System.Drawing.Size(162, 27);
            this.txtidem.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "ID Employee:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcheck);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtidem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btndeletecustomer);
            this.groupBox1.Controls.Add(this.txtidca);
            this.groupBox1.Controls.Add(this.btnaddcustomer);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 335);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Working Information During The Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID Calender";
            // 
            // txtidca
            // 
            this.txtidca.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidca.Location = new System.Drawing.Point(47, 77);
            this.txtidca.Name = "txtidca";
            this.txtidca.Size = new System.Drawing.Size(162, 27);
            this.txtidca.TabIndex = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(543, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 305);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(543, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 305);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schedule List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCalendarDataGridViewTextBoxColumn,
            this.iDShiftDataGridViewTextBoxColumn,
            this.iDPersonDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calendarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCheckinoutDataGridViewTextBoxColumn,
            this.iDCalendarDataGridViewTextBoxColumn1,
            this.iDEmployeeDataGridViewTextBoxColumn,
            this.timeCheckinDataGridViewTextBoxColumn,
            this.timeCheckoutDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.checkinoutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(748, 279);
            this.dataGridView2.TabIndex = 1;
            // 
            // hotelDataDataSet11
            // 
            this.hotelDataDataSet11.DataSetName = "HotelDataDataSet11";
            this.hotelDataDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calendarBindingSource
            // 
            this.calendarBindingSource.DataMember = "Calendar";
            this.calendarBindingSource.DataSource = this.hotelDataDataSet11;
            // 
            // calendarTableAdapter
            // 
            this.calendarTableAdapter.ClearBeforeFill = true;
            // 
            // iDCalendarDataGridViewTextBoxColumn
            // 
            this.iDCalendarDataGridViewTextBoxColumn.DataPropertyName = "ID_Calendar";
            this.iDCalendarDataGridViewTextBoxColumn.HeaderText = "ID_Calendar";
            this.iDCalendarDataGridViewTextBoxColumn.Name = "iDCalendarDataGridViewTextBoxColumn";
            // 
            // iDShiftDataGridViewTextBoxColumn
            // 
            this.iDShiftDataGridViewTextBoxColumn.DataPropertyName = "ID_Shift";
            this.iDShiftDataGridViewTextBoxColumn.HeaderText = "ID_Shift";
            this.iDShiftDataGridViewTextBoxColumn.Name = "iDShiftDataGridViewTextBoxColumn";
            // 
            // iDPersonDataGridViewTextBoxColumn
            // 
            this.iDPersonDataGridViewTextBoxColumn.DataPropertyName = "ID_Person";
            this.iDPersonDataGridViewTextBoxColumn.HeaderText = "ID_Person";
            this.iDPersonDataGridViewTextBoxColumn.Name = "iDPersonDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // hotelDataDataSet12
            // 
            this.hotelDataDataSet12.DataSetName = "HotelDataDataSet12";
            this.hotelDataDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkinoutBindingSource
            // 
            this.checkinoutBindingSource.DataMember = "Checkinout";
            this.checkinoutBindingSource.DataSource = this.hotelDataDataSet12;
            // 
            // checkinoutTableAdapter
            // 
            this.checkinoutTableAdapter.ClearBeforeFill = true;
            // 
            // iDCheckinoutDataGridViewTextBoxColumn
            // 
            this.iDCheckinoutDataGridViewTextBoxColumn.DataPropertyName = "ID_Checkinout";
            this.iDCheckinoutDataGridViewTextBoxColumn.HeaderText = "ID_Checkinout";
            this.iDCheckinoutDataGridViewTextBoxColumn.Name = "iDCheckinoutDataGridViewTextBoxColumn";
            // 
            // iDCalendarDataGridViewTextBoxColumn1
            // 
            this.iDCalendarDataGridViewTextBoxColumn1.DataPropertyName = "ID_Calendar";
            this.iDCalendarDataGridViewTextBoxColumn1.HeaderText = "ID_Calendar";
            this.iDCalendarDataGridViewTextBoxColumn1.Name = "iDCalendarDataGridViewTextBoxColumn1";
            // 
            // iDEmployeeDataGridViewTextBoxColumn
            // 
            this.iDEmployeeDataGridViewTextBoxColumn.DataPropertyName = "ID_Employee";
            this.iDEmployeeDataGridViewTextBoxColumn.HeaderText = "ID_Employee";
            this.iDEmployeeDataGridViewTextBoxColumn.Name = "iDEmployeeDataGridViewTextBoxColumn";
            // 
            // timeCheckinDataGridViewTextBoxColumn
            // 
            this.timeCheckinDataGridViewTextBoxColumn.DataPropertyName = "TimeCheckin";
            this.timeCheckinDataGridViewTextBoxColumn.HeaderText = "TimeCheckin";
            this.timeCheckinDataGridViewTextBoxColumn.Name = "timeCheckinDataGridViewTextBoxColumn";
            // 
            // timeCheckoutDataGridViewTextBoxColumn
            // 
            this.timeCheckoutDataGridViewTextBoxColumn.DataPropertyName = "TimeCheckout";
            this.timeCheckoutDataGridViewTextBoxColumn.HeaderText = "TimeCheckout";
            this.timeCheckoutDataGridViewTextBoxColumn.Name = "timeCheckoutDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn1
            // 
            this.dayDataGridViewTextBoxColumn1.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn1.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn1.Name = "dayDataGridViewTextBoxColumn1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "ID Checkinout :";
            // 
            // txtcheck
            // 
            this.txtcheck.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcheck.Location = new System.Drawing.Point(47, 254);
            this.txtcheck.Name = "txtcheck";
            this.txtcheck.Size = new System.Drawing.Size(162, 27);
            this.txtcheck.TabIndex = 52;
            // 
            // Checkinoutwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 698);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Checkinoutwork";
            this.Text = "Checkinoutwork";
            this.Load += new System.EventHandler(this.Checkinoutwork_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinoutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnaddcustomer;
        private Guna.UI2.WinForms.Guna2Button btndeletecustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataDataSet11 hotelDataDataSet11;
        private System.Windows.Forms.BindingSource calendarBindingSource;
        private HotelDataDataSet11TableAdapters.CalendarTableAdapter calendarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCalendarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDShiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private HotelDataDataSet12 hotelDataDataSet12;
        private System.Windows.Forms.BindingSource checkinoutBindingSource;
        private HotelDataDataSet12TableAdapters.CheckinoutTableAdapter checkinoutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCheckinoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCalendarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCheckinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCheckoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcheck;
    }
}