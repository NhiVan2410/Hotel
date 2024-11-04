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
    public partial class SalaryEmployee : Form
    {
        public SalaryEmployee()
        {
            InitializeComponent();
        }

        public DataTable GetSalaryByDate(DateTime date)
        {
            DataTable salaryData = new DataTable();

            MY_DB db = new MY_DB();

            string query = "SELECT ID_Salary, ID_Employee, Day, Amount " +
                           "FROM Salary " +
                           "WHERE Day = @Date";
            using (SqlCommand command = new SqlCommand(query, db.getConnection))
            {
                command.Parameters.AddWithValue("@Date", date);

                db.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                salaryData.Load(reader);
            }


            return salaryData;
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetSalaryByDate(dobpicker.Value);
        }

        private void SalaryEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataDataSet13.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.hotelDataDataSet13.Salary);

        }
    }
}
