using Hotel_Management;
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
    public partial class CustomerManagement : Form
    {
        public static int Id = -1;
        Customer0 customer = new Customer0();
        MY_DB mydb = new MY_DB();
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnamecustomer_TextChanged(object sender, EventArgs e)
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

        private void txtnationcustomer_TextChanged(object sender, EventArgs e)
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

        private void txtcardidcustomer_TextChanged(object sender, EventArgs e)
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

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VerifyFields())
                {
                    MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(txtidcustomer.Text);
                string namecustomer = txtnamecustomer.Text;
                string card = txtcardidcustomer.Text;
                string gender = combogendercustomer.SelectedItem.ToString();
                DateTime bdate = dobpicker.Value;
                string phone = txtphonecustomer.Text;
                string nation = txtnationcustomer.Text;
                int born_year = dobpicker.Value.Year;
                int this_year = DateTime.Now.Year;
                //  sv tu 10-100,  co the thay doi
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (customer.insertCustomer(id, namecustomer, card, gender, bdate, phone, nation))
                {
                    MessageBox.Show("New Customer Add", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to add customer.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            if (string.IsNullOrWhiteSpace(txtphonecustomer.Text) ||
                string.IsNullOrWhiteSpace(txtidcustomer.Text) ||
                string.IsNullOrWhiteSpace(txtnationcustomer.Text) ||
                string.IsNullOrWhiteSpace(txtnamecustomer.Text) ||
                string.IsNullOrWhiteSpace(txtcardidcustomer.Text) ||
                combogendercustomer.SelectedIndex == -1)// Kiểm tra ComboBox đã được chọn

            {
                return false;
            }
            return true;
        }

        private void datagridviewlistcustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }




        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.hotelDataDataSet1.Customer);
            // TODO: This line of code loads data into the 'hotelDataDataSet.Customer' table. You can move, or remove it, as needed.


        }

        private void datagridviewlistcustomer_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtidcustomer.Text = datagridviewlistcustomer.Rows[e.RowIndex].Cells[0].Value == DBNull.Value ? "" : datagridviewlistcustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnamecustomer.Text = datagridviewlistcustomer.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ? "" : datagridviewlistcustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcardidcustomer.Text = datagridviewlistcustomer.Rows[e.RowIndex].Cells[2].Value == DBNull.Value ? "" : datagridviewlistcustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (datagridviewlistcustomer.Rows[e.RowIndex].Cells[3].Value.ToString() == "Male")
            {
                combogendercustomer.SelectedIndex = 1; // Sets the selected item to the first item
            }
            else
            {
                combogendercustomer.SelectedIndex = 0; // Sets the selected item to the second item
            }


            if (datagridviewlistcustomer.Rows[e.RowIndex].Cells[4].Value != DBNull.Value)
            {
                dobpicker.Value = Convert.ToDateTime(datagridviewlistcustomer.Rows[e.RowIndex].Cells[4].Value);
            }
            else
            {
                dobpicker.Value = DateTime.Now; // Hoặc giá trị mặc định khác
            }
            txtphonecustomer.Text = datagridviewlistcustomer.Rows[e.RowIndex].Cells[5].Value == DBNull.Value ? "" : datagridviewlistcustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtnationcustomer.Text = datagridviewlistcustomer.Rows[e.RowIndex].Cells[6].Value == DBNull.Value ? "" : datagridviewlistcustomer.Rows[e.RowIndex].Cells[6].Value.ToString();
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

                int id = Convert.ToInt32(txtidcustomer.Text);
                string namecustomer = txtnamecustomer.Text;
                string card = txtcardidcustomer.Text;
                string gender = combogendercustomer.SelectedItem.ToString();
                DateTime bdate = dobpicker.Value;
                string phone = txtphonecustomer.Text;
                string nation = txtnationcustomer.Text;
                int born_year = dobpicker.Value.Year;
                int this_year = DateTime.Now.Year;

                // Kiểm tra tuổi hợp lệ
                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("The Customer Age Must Be Between 10 and 100 years", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi hàm UpdateCustomer để cập nhật thông tin khách hàng
                if (customer.UpdateCustomer(id, namecustomer, card, gender, bdate, phone, nation))
                {
                    MessageBox.Show("Customer Information Updated", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to update customer information.", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrWhiteSpace(txtidcustomer.Text))
                {
                    MessageBox.Show("Please enter the Customer ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID khách hàng từ trường nhập liệu
                int id = Convert.ToInt32(txtidcustomer.Text);

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Gọi hàm DeleteCustomer để xóa khách hàng
                    if (customer.DeleteCustomer(id))
                    {
                        MessageBox.Show("Customer Deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete customer.", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Customer WHERE CONCAT(ID_Customer, Name, IDcard) LIKE '%" + txtsearch.Text + "%'");

                // Gọi hàm fillGrid để hiển thị kết quả
                fillGrid(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        // Phương thức hiển thị kết quả tìm kiếm
      

        //Load Data :

        private void LoadData()
        {
            // Tạo và thiết lập lệnh SQL
            string query = "SELECT * FROM dbo.Customer";
            SqlCommand command = new SqlCommand(query);

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable table = customer.getCustomer(command);

            // Gán dữ liệu vào datagridview
            datagridviewlistcustomer.DataSource = table;
        }


        //FILL
        private void fillGrid(SqlCommand command)
        {
            datagridviewlistcustomer.ReadOnly = true;
            datagridviewlistcustomer.DataSource = customer.getCustomer(command);
        } 
    }
}


