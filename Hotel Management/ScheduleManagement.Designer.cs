namespace Hotel_Management.Resources
{
    partial class ScheduleManagement
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hotelDataDataSet10 = new Hotel_Management.HotelDataDataSet10();
            this.calendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendarTableAdapter = new Hotel_Management.HotelDataDataSet10TableAdapters.CalendarTableAdapter();
            this.datagridviewcalender = new System.Windows.Forms.DataGridView();
            this.iDShiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcalender)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datagridviewcalender);
            this.groupBox3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(952, 543);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schedule";
            // 
            // hotelDataDataSet10
            // 
            this.hotelDataDataSet10.DataSetName = "HotelDataDataSet10";
            this.hotelDataDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calendarBindingSource
            // 
            this.calendarBindingSource.DataMember = "Calendar";
            this.calendarBindingSource.DataSource = this.hotelDataDataSet10;
            // 
            // calendarTableAdapter
            // 
            this.calendarTableAdapter.ClearBeforeFill = true;
            // 
            // datagridviewcalender
            // 
            this.datagridviewcalender.AutoGenerateColumns = false;
            this.datagridviewcalender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewcalender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewcalender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDShiftDataGridViewTextBoxColumn,
            this.iDPersonDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn});
            this.datagridviewcalender.DataSource = this.calendarBindingSource;
            this.datagridviewcalender.Location = new System.Drawing.Point(6, 32);
            this.datagridviewcalender.Name = "datagridviewcalender";
            this.datagridviewcalender.RowTemplate.Height = 35;
            this.datagridviewcalender.Size = new System.Drawing.Size(946, 505);
            this.datagridviewcalender.TabIndex = 1;
            // 
            // iDShiftDataGridViewTextBoxColumn
            // 
            this.iDShiftDataGridViewTextBoxColumn.DataPropertyName = "ID_Shift";
            this.iDShiftDataGridViewTextBoxColumn.HeaderText = "ID Shift";
            this.iDShiftDataGridViewTextBoxColumn.Name = "iDShiftDataGridViewTextBoxColumn";
            // 
            // iDPersonDataGridViewTextBoxColumn
            // 
            this.iDPersonDataGridViewTextBoxColumn.DataPropertyName = "ID_Person";
            this.iDPersonDataGridViewTextBoxColumn.HeaderText = "ID Person";
            this.iDPersonDataGridViewTextBoxColumn.Name = "iDPersonDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // ScheduleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 583);
            this.Controls.Add(this.groupBox3);
            this.Name = "ScheduleManagement";
            this.Text = "ScheduleManagement";
            this.Load += new System.EventHandler(this.ScheduleManagement_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcalender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private HotelDataDataSet10 hotelDataDataSet10;
        private System.Windows.Forms.BindingSource calendarBindingSource;
        private HotelDataDataSet10TableAdapters.CalendarTableAdapter calendarTableAdapter;
        private System.Windows.Forms.DataGridView datagridviewcalender;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDShiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
    }
}