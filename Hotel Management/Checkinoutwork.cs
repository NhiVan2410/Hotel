using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class Checkinoutwork : Form
    {
        public Checkinoutwork()
        {
            InitializeComponent();
        }

        Checkinout checkinout = new Checkinout();
        private void Checkinoutwork_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataDataSet12.Checkinout' table. You can move, or remove it, as needed.
            this.checkinoutTableAdapter.Fill(this.hotelDataDataSet12.Checkinout);
            // TODO: This line of code loads data into the 'hotelDataDataSet11.Calendar' table. You can move, or remove it, as needed.
            this.calendarTableAdapter.Fill(this.hotelDataDataSet11.Calendar);

        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            Checkinout.CheckIn(txtcheck.Text, txtidca.Text, txtidem.Text);
            LoadData();
        }

        private void btndeletecustomer_Click(object sender, EventArgs e)
        {
            Checkinout.CheckOut(txtcheck.Text);
            LoadData();
        }

        private void LoadData()
        {
            // Tạo và thiết lập lệnh SQL
            string query = "SELECT * FROM dbo.Checkinout";
            SqlCommand command = new SqlCommand(query);

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable table = checkinout.getcheck(command);

            // Gán dữ liệu vào datagridview
            dataGridView2.DataSource = table;
        }

    }
}
