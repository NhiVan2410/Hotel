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
    public partial class InventoryManagement : Form
    {
        public static int Id = -1;
        Inventory inventory = new Inventory();
        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void txtiditems_TextChanged(object sender, EventArgs e)
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

        private void txtpriceitems_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                // Kiểm tra xem chuỗi có thể chuyển đổi thành số thực không
                if (!double.TryParse(textBox.Text.Replace(",", "."), out _))
                {
                    MessageBox.Show("Invalid, please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Text = string.Empty;
                }
            }
        }

        private void txtnameitems_TextChanged(object sender, EventArgs e)
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

                int id = Convert.ToInt32(txtiditems.Text);
                string nameitem = txtnameitems.Text;
                int amount = Convert.ToInt32(numberofitems.Value);
                string price = txtpriceitems.Text;


                if (inventory.insertInventory(id, nameitem, amount, price))
                {
                    MessageBox.Show("New Item Add", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to add Item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Check
        private bool VerifyFields()
        {
            if (string.IsNullOrWhiteSpace(txtiditems.Text) ||
                string.IsNullOrWhiteSpace(txtnameitems.Text) ||
                string.IsNullOrWhiteSpace(txtpriceitems.Text) ||
                numberofitems.Value <= 0) // Kiểm tra giá trị của NumericUpDown
            {
                return false;
            }
            return true;
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataDataSet2.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.hotelDataDataSet2.Inventory);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void datagridviewitemlist_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }

        private void datagridviewitemlist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
   
          
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
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Inventory WHERE CONCAT(ID_Inventory, Name) LIKE '%" + txtsearch.Text + "%'");

                // Gọi hàm fillGrid để hiển thị kết quả
                fillGrid(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LoadData()
        {
            // Tạo và thiết lập lệnh SQL
            string query = "SELECT * FROM dbo.Inventory";
            SqlCommand command = new SqlCommand(query);

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable table = inventory.getInventory(command);

            // Gán dữ liệu vào datagridview
            datagridviewitemlist.DataSource = table;
        }


        //FILL
        private void fillGrid(SqlCommand command)
        {
            datagridviewitemlist.ReadOnly = true;
            datagridviewitemlist.DataSource = inventory.getInventory(command);
        }

        private void btndeleteitems_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtiditems.Text))
                {
                    MessageBox.Show("Please enter the Item ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID khách hàng từ trường nhập liệu
                int id = Convert.ToInt32(txtiditems.Text);

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Gọi hàm DeleteCustomer để xóa khách hàng
                    if (inventory.deleteItem(id))
                    {
                        MessageBox.Show("Customer Item", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Item.", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Kiểm tra xem trường ID có được điền hay không
            
        }

        private void datagridviewitemlist_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtiditems.Text = datagridviewitemlist.Rows[e.RowIndex].Cells[0].Value == DBNull.Value ? "" : datagridviewitemlist.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnameitems.Text = datagridviewitemlist.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ? "" : datagridviewitemlist.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (datagridviewitemlist.Rows[e.RowIndex].Cells[2].Value != DBNull.Value)
            {
                numberofitems.Value = Convert.ToDecimal(datagridviewitemlist.Rows[e.RowIndex].Cells[2].Value);
            }
            else
            {
                numberofitems.Value = numberofitems.Minimum; // Hoặc giá trị mặc định khác
            }
            txtpriceitems.Text = datagridviewitemlist.Rows[e.RowIndex].Cells[3].Value == DBNull.Value ? "" : datagridviewitemlist.Rows[e.RowIndex].Cells[3].Value.ToString();
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

                int id = Convert.ToInt32(txtiditems.Text);
                string nameitem = txtnameitems.Text;
                int amount = Convert.ToInt32(numberofitems.Value);
                string price = txtpriceitems.Text;

               

                // Gọi hàm UpdateCustomer để cập nhật thông tin khách hàng
                if (inventory.updateItem(id, nameitem, amount, price))
                {
                    MessageBox.Show("Update Item Update", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to Update Item.", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
