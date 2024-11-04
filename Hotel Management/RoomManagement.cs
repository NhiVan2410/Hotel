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
    public partial class RoomManagement : Form
    {
        public static int Id = -1;
        Room0 room = new Room0();
        public RoomManagement()
        {
            InitializeComponent();
        }

        private void RoomManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataDataSet3.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotelDataDataSet3.Room);

        }

        private void txtcardidcustomer_TextChanged(object sender, EventArgs e)
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

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VerifyFields())
                {
                    MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(txtidroom.Text);
                string nameroom = txtnameroom.Text;
                string state = combostateroom.SelectedItem.ToString();
                string type = combotyperoom.SelectedItem.ToString();
                string price = txtpriceroom.Text;

                if (room.inserRoom(id, nameroom, state, type, price))
                {
                    MessageBox.Show("New Room Add", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    var otherForm = Application.OpenForms["OtherForm"] as Bookroom;
                    if (otherForm != null)
                    {
                        otherForm.PopulateComboBox();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to add Room.", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            if (string.IsNullOrWhiteSpace(txtnameroom.Text) ||
                string.IsNullOrWhiteSpace(txtpriceroom.Text) ||
                string.IsNullOrWhiteSpace(txtidroom.Text) ||
                combotyperoom.SelectedIndex == -1 ||
                combostateroom.SelectedIndex == -1)

            {
                return false;
            }
            return true;
        }

        private void txtnameroom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void datagridviewroomlist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Room  WHERE CONCAT(ID_Room,Name,State) LIKE '%" + txtsearch.Text + "%'");

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
            string query = "SELECT * FROM dbo.Room ";
            SqlCommand command = new SqlCommand(query);

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable table = room.getRoom(command);

            // Gán dữ liệu vào datagridview
            datagridviewroomlist.DataSource = table;
        }


        //FILL
        private void fillGrid(SqlCommand command)
        {
            datagridviewroomlist.ReadOnly = true;
            datagridviewroomlist.DataSource = room.getRoom(command);


        }

        private void btnupdateroom_Click(object sender, EventArgs e)
        {

            try
            {
                if (!VerifyFields())
                {
                    MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(txtidroom.Text);
                string nameroom = txtnameroom.Text;
                string price = txtpriceroom.Text;
                string state = combostateroom.SelectedItem.ToString();
                string type = combotyperoom.SelectedItem.ToString();



                // Gọi hàm UpdateCustomer để cập nhật thông tin khách hàng
                if (room.updateRoom(id, nameroom, state, type, price))
                {
                    MessageBox.Show("Room Information Updated", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to update Room information.", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btndeleteroom_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtidroom.Text))
                {
                    MessageBox.Show("Please enter the Room ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID Room từ trường nhập liệu
                int id = Convert.ToInt32(txtidroom.Text);

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Gọi hàm deleteRoom để xóa khách hàng
                    if (room.deleteRoom(id))
                    {
                        MessageBox.Show("Room Deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Room.", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void datagridviewroomlist_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtidroom.Text = datagridviewroomlist.Rows[e.RowIndex].Cells[0].Value == DBNull.Value ? "" : datagridviewroomlist.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnameroom.Text = datagridviewroomlist.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ? "" : datagridviewroomlist.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (datagridviewroomlist.Rows[e.RowIndex].Cells[2].Value.ToString() == "Busy")
            {
                combostateroom.SelectedIndex = 0; // Sets the selected item to the first item
            }
            else
            {
                combostateroom.SelectedIndex = 1; // Sets the selected item to the second item
            }

            if (datagridviewroomlist.Rows[e.RowIndex].Cells[3].Value.ToString() == "Single Room")


            {
                combotyperoom.SelectedIndex = 1; // Sets the selected item to the first item
            }
            else if (datagridviewroomlist.Rows[e.RowIndex].Cells[3].Value.ToString() == "Double Room")
            {
                combotyperoom.SelectedIndex = 2; // Sets the selected item to the first item
            }
            else
            {
                combotyperoom.SelectedIndex = 0; // Sets the selected item to the second item
            }
            txtpriceroom.Text = datagridviewroomlist.Rows[e.RowIndex].Cells[4].Value == DBNull.Value ? "" : datagridviewroomlist.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
