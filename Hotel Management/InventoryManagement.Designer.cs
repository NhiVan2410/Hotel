namespace Hotel_Management
{
    partial class InventoryManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numberofitems = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtpriceitems = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnameitems = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtiditems = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datagridviewitemlist = new System.Windows.Forms.DataGridView();
            this.iDInventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataDataSet2 = new Hotel_Management.HotelDataDataSet2();
            this.btndeleteitems = new Guna.UI2.WinForms.Guna2Button();
            this.btnadditems = new Guna.UI2.WinForms.Guna2Button();
            this.inventoryTableAdapter = new Hotel_Management.HotelDataDataSet2TableAdapters.InventoryTableAdapter();
            this.btnupdatecustomer = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberofitems)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewitemlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(81, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 55);
            this.label2.TabIndex = 26;
            this.label2.Text = "Manager Inventory";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.guna2Button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(90, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(676, 188);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(57, 105);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(241, 35);
            this.txtsearch.TabIndex = 36;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Hotel_Management.Properties.Resources._9004762_search_find_zoom_magnifier_icon;
            this.guna2Button1.Location = new System.Drawing.Point(378, 97);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(243, 55);
            this.guna2Button1.TabIndex = 35;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "ID/Name Items :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numberofitems);
            this.groupBox2.Controls.Add(this.txtpriceitems);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtnameitems);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtiditems);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(90, 360);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(676, 314);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 33);
            this.label6.TabIndex = 44;
            this.label6.Text = "Amount :";
            // 
            // numberofitems
            // 
            this.numberofitems.BackColor = System.Drawing.Color.Transparent;
            this.numberofitems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberofitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofitems.Location = new System.Drawing.Point(368, 105);
            this.numberofitems.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.numberofitems.Name = "numberofitems";
            this.numberofitems.Size = new System.Drawing.Size(254, 42);
            this.numberofitems.TabIndex = 43;
            // 
            // txtpriceitems
            // 
            this.txtpriceitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpriceitems.Location = new System.Drawing.Point(368, 215);
            this.txtpriceitems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpriceitems.Name = "txtpriceitems";
            this.txtpriceitems.Size = new System.Drawing.Size(252, 35);
            this.txtpriceitems.TabIndex = 40;
            this.txtpriceitems.TextChanged += new System.EventHandler(this.txtpriceitems_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 33);
            this.label4.TabIndex = 39;
            this.label4.Text = "Price :";
            // 
            // txtnameitems
            // 
            this.txtnameitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameitems.Location = new System.Drawing.Point(57, 215);
            this.txtnameitems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnameitems.Name = "txtnameitems";
            this.txtnameitems.Size = new System.Drawing.Size(241, 35);
            this.txtnameitems.TabIndex = 38;
            this.txtnameitems.TextChanged += new System.EventHandler(this.txtnameitems_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 33);
            this.label3.TabIndex = 37;
            this.label3.Text = "Name :";
            // 
            // txtiditems
            // 
            this.txtiditems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiditems.Location = new System.Drawing.Point(57, 105);
            this.txtiditems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtiditems.Name = "txtiditems";
            this.txtiditems.Size = new System.Drawing.Size(241, 35);
            this.txtiditems.TabIndex = 36;
            this.txtiditems.TextChanged += new System.EventHandler(this.txtiditems_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID :";
            // 
            // btnclose
            // 
            this.btnclose.BorderRadius = 15;
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(458, 803);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(260, 55);
            this.btnclose.TabIndex = 48;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datagridviewitemlist);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(802, 54);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(982, 855);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List Items";
            // 
            // datagridviewitemlist
            // 
            this.datagridviewitemlist.AutoGenerateColumns = false;
            this.datagridviewitemlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewitemlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewitemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewitemlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDInventoryDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.datagridviewitemlist.DataSource = this.inventoryBindingSource;
            this.datagridviewitemlist.Location = new System.Drawing.Point(8, 51);
            this.datagridviewitemlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridviewitemlist.Name = "datagridviewitemlist";
            this.datagridviewitemlist.RowHeadersWidth = 30;
            this.datagridviewitemlist.RowTemplate.Height = 35;
            this.datagridviewitemlist.Size = new System.Drawing.Size(975, 794);
            this.datagridviewitemlist.TabIndex = 0;
            this.datagridviewitemlist.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // iDInventoryDataGridViewTextBoxColumn
            // 
            this.iDInventoryDataGridViewTextBoxColumn.DataPropertyName = "ID_Inventory";
            this.iDInventoryDataGridViewTextBoxColumn.HeaderText = "ID_Inventory";
            this.iDInventoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDInventoryDataGridViewTextBoxColumn.Name = "iDInventoryDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.hotelDataDataSet2;
            // 
            // hotelDataDataSet2
            // 
            this.hotelDataDataSet2.DataSetName = "HotelDataDataSet2";
            this.hotelDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btndeleteitems
            // 
            this.btndeleteitems.BorderRadius = 15;
            this.btndeleteitems.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteitems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteitems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndeleteitems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndeleteitems.FillColor = System.Drawing.Color.OrangeRed;
            this.btndeleteitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteitems.ForeColor = System.Drawing.Color.Black;
            this.btndeleteitems.Image = global::Hotel_Management.Properties.Resources.bin_484611;
            this.btndeleteitems.Location = new System.Drawing.Point(100, 803);
            this.btndeleteitems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndeleteitems.Name = "btndeleteitems";
            this.btndeleteitems.Size = new System.Drawing.Size(260, 55);
            this.btndeleteitems.TabIndex = 47;
            this.btndeleteitems.Text = "Delete";
            this.btndeleteitems.Click += new System.EventHandler(this.btndeleteitems_Click);
            // 
            // btnadditems
            // 
            this.btnadditems.BorderRadius = 15;
            this.btnadditems.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadditems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadditems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadditems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadditems.FillColor = System.Drawing.Color.LightGreen;
            this.btnadditems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditems.ForeColor = System.Drawing.Color.Black;
            this.btnadditems.Image = global::Hotel_Management.Properties.Resources.add_5372888;
            this.btnadditems.Location = new System.Drawing.Point(100, 723);
            this.btnadditems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadditems.Name = "btnadditems";
            this.btnadditems.Size = new System.Drawing.Size(260, 55);
            this.btnadditems.TabIndex = 45;
            this.btnadditems.Text = "Add Items";
            this.btnadditems.Click += new System.EventHandler(this.btnaddcustomer_Click);
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // btnupdatecustomer
            // 
            this.btnupdatecustomer.BorderRadius = 15;
            this.btnupdatecustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupdatecustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupdatecustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdatecustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupdatecustomer.FillColor = System.Drawing.Color.PaleGoldenrod;
            this.btnupdatecustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatecustomer.ForeColor = System.Drawing.Color.Black;
            this.btnupdatecustomer.Image = global::Hotel_Management.Properties.Resources.save_4223793;
            this.btnupdatecustomer.Location = new System.Drawing.Point(458, 723);
            this.btnupdatecustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdatecustomer.Name = "btnupdatecustomer";
            this.btnupdatecustomer.Size = new System.Drawing.Size(260, 55);
            this.btnupdatecustomer.TabIndex = 50;
            this.btnupdatecustomer.Text = "Update";
            this.btnupdatecustomer.Click += new System.EventHandler(this.btnupdatecustomer_Click);
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 917);
            this.Controls.Add(this.btnupdatecustomer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndeleteitems);
            this.Controls.Add(this.btnadditems);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InventoryManagement";
            this.Text = "InventoryManagement";
            this.Load += new System.EventHandler(this.InventoryManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberofitems)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewitemlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataDataSet2)).EndInit();
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
        private System.Windows.Forms.TextBox txtpriceitems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnameitems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtiditems;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2Button btndeleteitems;
        private Guna.UI2.WinForms.Guna2Button btnadditems;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown numberofitems;
        private HotelDataDataSet2 hotelDataDataSet2;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private HotelDataDataSet2TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridView datagridviewitemlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button btnupdatecustomer;
    }
}