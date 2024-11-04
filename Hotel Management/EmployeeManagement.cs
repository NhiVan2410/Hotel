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
    public partial class EmployeeManagement : Form
    {
        Employee0 employee = new Employee0();
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void btnaccess_Click(object sender, EventArgs e)
        {

        }

        private void txtphonecustomer_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!int.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show("Invalid, please enter only number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Text = string.Empty;
                }
            }
        }

        private void txtnameEmployee_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                // Kiểm tra xem chuỗi có chứa số hay không
                if (textBox.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Invalid, please enter only letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Text = string.Empty;
                }
            }
        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VerifyFields())
                {
                    MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(txtidemployee.Text);
                string nameemployee = txtnameEmployee.Text;
                string gender = combogenderemployee.SelectedItem.ToString();
                DateTime bdate = dobpicker.Value;
                string phone = txtphoneemployee.Text;
                string address = txtaddressemployee.Text;
                int born_year = dobpicker.Value.Year;
                int this_year = DateTime.Now.Year;
                string role = comboroleemployee.SelectedItem.ToString();
                string username = txtusernameemployee.Text;
                string password = txtpasswordemployee.Text;

                //  sv tu 10-100,  co the thay doi
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Employee Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (employee.insertEmployee(id, nameemployee, gender, bdate, phone, address, role, username, password))
                {
                    MessageBox.Show("New Employee Add", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to add Employee.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // Check Info 
        private bool VerifyFields()
        {
            int born_year = dobpicker.Value.Year;
            int this_year = DateTime.Now.Year;

            if (string.IsNullOrWhiteSpace(txtusernameemployee.Text) ||
                string.IsNullOrWhiteSpace(txtphoneemployee.Text) ||
                string.IsNullOrWhiteSpace(txtpasswordemployee.Text) ||
                string.IsNullOrWhiteSpace(txtnameEmployee.Text) ||
                string.IsNullOrWhiteSpace(txtaddressemployee.Text) ||
                combogenderemployee.SelectedIndex == -1 || // Kiểm tra ComboBox đã được chọn
                dobpicker.Value == null || // Kiểm tra DateTimePicker có giá trị
                (this_year - born_year) < 10 || (this_year - born_year) > 100) // Kiểm tra tuổi hợp lệ
            {
                return false;
            }
            return true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datagridviewlistemployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataDataSet5.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.hotelDataDataSet5.Employee);

        }

        private void datagridviewlistemployee_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtidemployee.Text = datagridviewlistemployee.Rows[e.RowIndex].Cells[0].Value == DBNull.Value ? "" : datagridviewlistemployee.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnameEmployee.Text = datagridviewlistemployee.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ? "" : datagridviewlistemployee.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (datagridviewlistemployee.Rows[e.RowIndex].Cells[2].Value.ToString() == "Male")
            {
                combogenderemployee.SelectedIndex = 1; // Sets the selected item to the first item
            }
            else
            {
                combogenderemployee.SelectedIndex = 0; // Sets the selected item to the second item
            }


            if (datagridviewlistemployee.Rows[e.RowIndex].Cells[3].Value != DBNull.Value)
            {
                dobpicker.Value = Convert.ToDateTime(datagridviewlistemployee.Rows[e.RowIndex].Cells[3].Value);
            }
            else
            {
                dobpicker.Value = DateTime.Now; // Hoặc giá trị mặc định khác
            }

            txtphoneemployee.Text = datagridviewlistemployee.Rows[e.RowIndex].Cells[4].Value == DBNull.Value ? "" : datagridviewlistemployee.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtaddressemployee.Text = datagridviewlistemployee.Rows[e.RowIndex].Cells[5].Value == DBNull.Value ? "" : datagridviewlistemployee.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (datagridviewlistemployee.Rows[e.RowIndex].Cells[6].Value.ToString() == "Manager")
            {
                comboroleemployee.SelectedIndex = 0; // Sets the selected item to the first item
            }
            else if (datagridviewlistemployee.Rows[e.RowIndex].Cells[6].Value.ToString() == "Receipter")
            {
                comboroleemployee.SelectedIndex = 1; // Sets the selected item to the second item
            }
            else
            {
                comboroleemployee.SelectedIndex = 2; // Sets the selected item to the second item
            }
            txtusernameemployee.Text = datagridviewlistemployee.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ? "" : datagridviewlistemployee.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtpasswordemployee.Text = datagridviewlistemployee.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ? "" : datagridviewlistemployee.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtsearch.Text))
                {
                    MessageBox.Show("Please enter the search query.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo câu lệnh SQL để tìm kiếm thông tin khách hàng
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Employee WHERE CONCAT(ID_Employee, Name, Address) LIKE '%" + txtsearch.Text + "%'");

                // Gọi hàm fillGrid để hiển thị kết quả
                fillGrid(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Load Data :

        private void LoadData()
        {
            // Tạo và thiết lập lệnh SQL
            string query = "SELECT * FROM dbo.Employee";
            SqlCommand command = new SqlCommand(query);

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable table = employee.getEmployee(command);

            // Gán dữ liệu vào datagridview
            datagridviewlistemployee.DataSource = table;
        }


        //FILL
        private void fillGrid(SqlCommand command)
        {
            datagridviewlistemployee.ReadOnly = true;
            datagridviewlistemployee.DataSource = employee.getEmployee(command);
        }

        private void btnupdatecustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VerifyFields())
                {
                    MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int id = Convert.ToInt32(txtidemployee.Text);
                string nameemployee = txtnameEmployee.Text;
                string gender = combogenderemployee.SelectedItem.ToString();
                DateTime bdate = dobpicker.Value;
                string phone = txtphoneemployee.Text;
                string address = txtaddressemployee.Text;
                int born_year = dobpicker.Value.Year;
                int this_year = DateTime.Now.Year;
                string role = comboroleemployee.SelectedItem.ToString();
                string username = txtusernameemployee.Text;
                string password = txtpasswordemployee.Text;

                // Kiểm tra tuổi hợp lệ
                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("The Employee Age Must Be Between 10 and 100 years", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi hàm UpdateCustomer để cập nhật thông tin khách hàng
                if (employee.updateEmployee(id, nameemployee, gender, bdate, phone, address, role, username, password))
                {
                    MessageBox.Show("Employee Information Updated", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to update Employee information.", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btndeletecustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem trường ID có được điền hay không
                if (string.IsNullOrWhiteSpace(txtidemployee.Text))
                {
                    MessageBox.Show("Please enter the Employee ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID khách hàng từ trường nhập liệu
                int id = Convert.ToInt32(txtidemployee.Text);

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Gọi hàm DeleteCustomer để xóa khách hàng
                    if (employee.deleteEmployee(id))
                    {
                        MessageBox.Show("Employee Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Employee.", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
