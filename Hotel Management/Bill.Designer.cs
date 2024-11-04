namespace Hotel_Management
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.label24 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.listViewUseService = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPeoples = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblRoomPrice_ = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lblDateCheckIn = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblRoomTypeName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDateCreate = new System.Windows.Forms.Label();
            this.lblCustom = new System.Windows.Forms.Label();
            this.lblStaffSetUp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIDBill = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.btnprint = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(399, 635);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 17);
            this.label24.TabIndex = 112;
            this.label24.Text = "Total:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(162, 635);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(131, 17);
            this.lblTotalPrice.TabIndex = 109;
            this.lblTotalPrice.Text = "Mã hóa đơn";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label27.Location = new System.Drawing.Point(85, 635);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 17);
            this.label27.TabIndex = 108;
            this.label27.Text = "Price:";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblServicePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblServicePrice.Location = new System.Drawing.Point(476, 609);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(154, 17);
            this.lblServicePrice.TabIndex = 107;
            this.lblServicePrice.Text = "Mã hóa đơn";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label25.Location = new System.Drawing.Point(396, 609);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 17);
            this.label25.TabIndex = 106;
            this.label25.Text = "Service Price:";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRoomPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRoomPrice.Location = new System.Drawing.Point(161, 609);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(132, 17);
            this.lblRoomPrice.TabIndex = 103;
            this.lblRoomPrice.Text = "Mã hóa đơn";
            this.lblRoomPrice.Click += new System.EventHandler(this.lblRoomPrice_Click);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(85, 609);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 17);
            this.label22.TabIndex = 102;
            this.label22.Text = "Room Price:";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // listViewUseService
            // 
            this.listViewUseService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listViewUseService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewUseService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewUseService.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.listViewUseService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listViewUseService.FullRowSelect = true;
            this.listViewUseService.GridLines = true;
            this.listViewUseService.HideSelection = false;
            this.listViewUseService.Location = new System.Drawing.Point(38, 389);
            this.listViewUseService.Name = "listViewUseService";
            this.listViewUseService.Size = new System.Drawing.Size(631, 195);
            this.listViewUseService.TabIndex = 100;
            this.listViewUseService.UseCompatibleStateImageBehavior = false;
            this.listViewUseService.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name Service";
            this.columnHeader2.Width = 330;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.Width = 100;
            // 
            // lblPeoples
            // 
            this.lblPeoples.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeoples.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPeoples.Location = new System.Drawing.Point(476, 343);
            this.lblPeoples.Name = "lblPeoples";
            this.lblPeoples.Size = new System.Drawing.Size(214, 17);
            this.lblPeoples.TabIndex = 96;
            this.lblPeoples.Text = "Mã hóa đơn";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(361, 343);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 17);
            this.label20.TabIndex = 95;
            this.label20.Text = "Number of Guest:";
            // 
            // lblRoomPrice_
            // 
            this.lblRoomPrice_.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRoomPrice_.Location = new System.Drawing.Point(476, 284);
            this.lblRoomPrice_.Name = "lblRoomPrice_";
            this.lblRoomPrice_.Size = new System.Drawing.Size(214, 17);
            this.lblRoomPrice_.TabIndex = 92;
            this.lblRoomPrice_.Text = "Mã hóa đơn";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(365, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 17);
            this.label18.TabIndex = 91;
            this.label18.Text = "Price:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // lblDateCheckIn
            // 
            this.lblDateCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDateCheckIn.Location = new System.Drawing.Point(476, 312);
            this.lblDateCheckIn.Name = "lblDateCheckIn";
            this.lblDateCheckIn.Size = new System.Drawing.Size(214, 17);
            this.lblDateCheckIn.TabIndex = 90;
            this.lblDateCheckIn.Text = "Mã hóa đơn";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(365, 312);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 17);
            this.label17.TabIndex = 89;
            this.label17.Text = "Received Date:";
            // 
            // lblRoomTypeName
            // 
            this.lblRoomTypeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRoomTypeName.Location = new System.Drawing.Point(476, 255);
            this.lblRoomTypeName.Name = "lblRoomTypeName";
            this.lblRoomTypeName.Size = new System.Drawing.Size(214, 17);
            this.lblRoomTypeName.TabIndex = 88;
            this.lblRoomTypeName.Text = "Mã hóa đơn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(365, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 17);
            this.label16.TabIndex = 87;
            this.label16.Text = "Type:";
            // 
            // lblRoomName
            // 
            this.lblRoomName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRoomName.Location = new System.Drawing.Point(476, 224);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(214, 17);
            this.lblRoomName.TabIndex = 86;
            this.lblRoomName.Text = "Mã hóa đơn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(365, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 85;
            this.label15.Text = "Roome Name:";
            // 
            // lblNationality
            // 
            this.lblNationality.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNationality.Location = new System.Drawing.Point(142, 312);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(183, 17);
            this.lblNationality.TabIndex = 84;
            this.lblNationality.Text = "Mã hóa đơn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(35, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 83;
            this.label14.Text = "National:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(142, 284);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(183, 17);
            this.lblPhoneNumber.TabIndex = 80;
            this.lblPhoneNumber.Text = "Mã hóa đơn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(35, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 79;
            this.label11.Text = "Phone Number:";
            // 
            // lblIDCard
            // 
            this.lblIDCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIDCard.Location = new System.Drawing.Point(142, 255);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(183, 17);
            this.lblIDCard.TabIndex = 78;
            this.lblIDCard.Text = "Mã hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(35, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "Card ID:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblFinalPrice);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.lblTotalPrice);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.lblServicePrice);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.lblRoomPrice);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.listViewUseService);
            this.groupBox6.Controls.Add(this.lblPeoples);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.lblRoomPrice_);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.lblDateCheckIn);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.lblRoomTypeName);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.lblRoomName);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.lblNationality);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.lblPhoneNumber);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.lblIDCard);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.lblCustomerName);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.lblDateCreate);
            this.groupBox6.Controls.Add(this.lblCustom);
            this.groupBox6.Controls.Add(this.lblStaffSetUp);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.lblIDBill);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.pictureBox2);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox6.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox6.Location = new System.Drawing.Point(72, 56);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(696, 676);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFinalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFinalPrice.Location = new System.Drawing.Point(476, 635);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(131, 17);
            this.lblFinalPrice.TabIndex = 113;
            this.lblFinalPrice.Text = "Mã hóa đơn";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerName.Location = new System.Drawing.Point(142, 224);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(225, 17);
            this.lblCustomerName.TabIndex = 76;
            this.lblCustomerName.Text = "Mã hóa đơn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(35, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 75;
            this.label9.Text = "Customer Name:";
            // 
            // lblDateCreate
            // 
            this.lblDateCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDateCreate.Location = new System.Drawing.Point(560, 185);
            this.lblDateCreate.Name = "lblDateCreate";
            this.lblDateCreate.Size = new System.Drawing.Size(130, 17);
            this.lblDateCreate.TabIndex = 73;
            this.lblDateCreate.Text = "Mã hóa đơn";
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustom.Location = new System.Drawing.Point(490, 185);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(38, 17);
            this.lblCustom.TabIndex = 72;
            this.lblCustom.Text = "Date:";
            // 
            // lblStaffSetUp
            // 
            this.lblStaffSetUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffSetUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStaffSetUp.Location = new System.Drawing.Point(324, 185);
            this.lblStaffSetUp.Name = "lblStaffSetUp";
            this.lblStaffSetUp.Size = new System.Drawing.Size(160, 17);
            this.lblStaffSetUp.TabIndex = 71;
            this.lblStaffSetUp.Text = "Mã hóa đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(212, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Name Receiptor:";
            // 
            // lblIDBill
            // 
            this.lblIDBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIDBill.Location = new System.Drawing.Point(119, 185);
            this.lblIDBill.Name = "lblIDBill";
            this.lblIDBill.Size = new System.Drawing.Size(83, 17);
            this.lblIDBill.TabIndex = 69;
            this.lblIDBill.Text = "Mã hóa đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(35, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Bill ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(255, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 25);
            this.label5.TabIndex = 67;
            this.label5.Text = "BILL PAYMENT SERVICES";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(206, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 23);
            this.label4.TabIndex = 66;
            this.label4.Text = "▶ Website: https://www.thereveriesaigon.com";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(206, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 19);
            this.label3.TabIndex = 65;
            this.label3.Text = "▶ Phone: 028 3823 6688";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(206, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(484, 37);
            this.label13.TabIndex = 64;
            this.label13.Text = "▶ Address: The Reverie Saigon, 22-36 Nguyen Hue Boulevard, Ben Nghe Ward, Distric" +
    "t 1, Ho Chi Minh City.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(201, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "HOTEL 999";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(69, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "Print Bill";
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
            this.btnclose.Location = new System.Drawing.Point(501, 767);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(162, 36);
            this.btnclose.TabIndex = 42;
            this.btnclose.Text = "Close";
            // 
            // btnprint
            // 
            this.btnprint.BorderRadius = 15;
            this.btnprint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnprint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnprint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnprint.FillColor = System.Drawing.Color.LightGreen;
            this.btnprint.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.Black;
            this.btnprint.Image = global::Hotel_Management.Properties.Resources._7830829_print_text_icon;
            this.btnprint.Location = new System.Drawing.Point(217, 767);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(162, 36);
            this.btnprint.TabIndex = 41;
            this.btnprint.Text = "Print";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 835);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label2);
            this.Name = "Bill";
            this.Text = "Bill";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListView listViewUseService;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblPeoples;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblRoomPrice_;
        private System.Windows.Forms.Label label18;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lblDateCheckIn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRoomTypeName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDateCreate;
        private System.Windows.Forms.Label lblCustom;
        private System.Windows.Forms.Label lblStaffSetUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIDBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinalPrice;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2Button btnprint;
    }
}