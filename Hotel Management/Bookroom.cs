using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class Bookroom : Form
    {
        MY_DB mydb = new MY_DB();
        BookRoom0 bookRoom = new BookRoom0();
        public Bookroom()
        {
            InitializeComponent();
            PopulateComboBox();
            comboroomname.SelectedIndexChanged += comboroomname_SelectedIndexChanged;
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
                //string state = combogendercustomer.SelectedItem.ToString();

                int idbookroom = Convert.ToInt32(txtidbookroom.Text);
                int idcustomer = Convert.ToInt32(txtidcustomer.Text);
                int idroom = Convert.ToInt32(txtidroom.Text);
                DateTime timecheckin = dobpicker.Value;
                DateTime timecheckout = dobpicker1.Value;



                if (bookRoom.insertBookroom(idbookroom, idcustomer, idroom, timecheckin, timecheckout))
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

        private void LoadData()
        {
            // Tạo và thiết lập lệnh SQL
            string query = "SELECT * FROM  dbo.BookRoomView";
            SqlCommand command = new SqlCommand(query);

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable table = bookRoom.getInfoBookRoom(command);

            // Gán dữ liệu vào datagridview
            dataGridView1.DataSource = table;
        }

        //Kiểm tra 

        private bool VerifyFields()
        {


            if (string.IsNullOrWhiteSpace(txtphonecustomer.Text) ||
                string.IsNullOrWhiteSpace(txtidbookroom.Text) ||
                string.IsNullOrWhiteSpace(txtnationcustomer.Text) ||
                string.IsNullOrWhiteSpace(txtcustomername.Text) ||
                string.IsNullOrWhiteSpace(txtcardidcustomer.Text) ||
                string.IsNullOrWhiteSpace(txtidroom.Text) ||
                string.IsNullOrWhiteSpace(txtstateroom.Text) ||
                string.IsNullOrWhiteSpace(txttyperoom.Text) ||
                 comboroomname.SelectedIndex == -1)

                

            {
                return false;
            }
            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bookroom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataDataSet6.BookRoomView' table. You can move, or remove it, as needed.
            this.bookRoomViewTableAdapter.Fill(this.hotelDataDataSet6.BookRoomView);

        }


        //Roomdata 
        public class RoomData
        {
            MY_DB mydb = new MY_DB();

            public List<string> GetRoomKinds()
            {
                List<string> names = new List<string>();
                try
                {
                    mydb.openConnection();
                    string query = "SELECT DISTINCT [Name] FROM [HotelData].[dbo].[Room]";
                    SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        names.Add(reader["Name"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    mydb.closeConnection();
                }

                return names;
            }

            public DataRow GetRoomDetails(string roomName)
            {
                DataTable table = new DataTable();
                try
                {
                    mydb.openConnection();
                    string query = "SELECT [ID_Room], [Name], [State], [Kind], [Price] FROM [HotelData].[dbo].[Room] WHERE [Name] = @Name";
                    SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
                    cmd.Parameters.AddWithValue("@Name", roomName);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    mydb.closeConnection();
                }

                if (table.Rows.Count > 0)
                    return table.Rows[0];
                else
                    return null;
            }

        }




        // Xử lí 

        RoomData roomData = new RoomData();
        public void PopulateComboBox()
        {
            List<string> names = roomData.GetRoomKinds();
            comboroomname.DataSource = names;
        }

        private void comboroomname_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoomName = comboroomname.SelectedItem.ToString();
            DataRow roomDetails = roomData.GetRoomDetails(selectedRoomName);

            if (roomDetails != null)
            {
                txtidroom.Text = roomDetails["ID_Room"].ToString();
                txtstateroom.Text = roomDetails["State"].ToString();
                txttyperoom.Text = roomDetails["Kind"].ToString();
                txtpriceroom.Text = roomDetails["Price"].ToString();
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

                string connectionString = (@"Data Source=DAROND\SQLEXPRESS;Initial Catalog=HotelData;Integrated Security=True");
                string query = "SELECT * FROM dbo.Customer WHERE CONCAT(IDCard, ID_Customer, Name) LIKE '%" + txtsearch.Text + "%'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Lấy dữ liệu từ cột trong kết quả truy vấn
                            string customerName = reader["Name"].ToString();
                            string idcardcustomer = reader["IDcard"].ToString();
                            string idcustomer = reader["ID_Customer"].ToString();
                            string phone = reader["PhoneNumber"].ToString();
                            string nation = reader["Nationality"].ToString();
                            DateTime dob = Convert.ToDateTime(reader["DOB"]);

                            // Populate dữ liệu vào các điều khiển
                            txtcustomername.Text = customerName;
                            txtidcustomer.Text = idcustomer; // Giả sử các giá trị trong combobox đã được đặt trước
                            dobpicker.Value = dob;
                            txtcardidcustomer.Text = idcardcustomer;
                            txtphonecustomer.Text = phone;
                            txtnationcustomer.Text = nation;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No matching records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close();
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
                // Kiểm tra xem trường ID có được điền hay không
                if (string.IsNullOrWhiteSpace(txtidbookroom.Text))
                {
                    MessageBox.Show("Please enter the ID Book Room.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID khách hàng từ trường nhập liệu
                int id = Convert.ToInt32(txtidbookroom.Text);

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Gọi hàm DeleteCustomer để xóa khách hàng
                    if (bookRoom.DeleteCustomer(id))
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

        //fillData




    }
}