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
using static Hotel_Management.Bookroom;

namespace Hotel_Management
{
    public partial class PaymentandService : Form
    {
        Payment payment = new Payment();
        MY_DB db = new MY_DB();
        public PaymentandService()
        {
            InitializeComponent();
            //populate combobox
            PopulateComboBox();
            comboservicelist.SelectedIndexChanged += comboservicelist_SelectedIndexChanged;
            listViewUseService.View = View.Details;


        }


        private void btnaddservice_Click(object sender, EventArgs e)
        {

            try
            {
                // Lấy dữ liệu từ các điều khiển đầu vào
                int amount = Convert.ToInt32(numberofitems.Value);
                string namefood = comboservicelist.SelectedItem?.ToString();
                string priceText = txtpriceitems.Text;

                // Kiểm tra xem các đầu vào có hợp lệ không
                if (string.IsNullOrEmpty(namefood) || string.IsNullOrEmpty(priceText) || amount <= 0)
                {
                    MessageBox.Show("Please enter complete and valid information.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi giá từ chuỗi sang số
                if (!decimal.TryParse(priceText, out decimal price))
                {
                    MessageBox.Show("Giá không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tính tổng tiền
                decimal total = price * amount;

                // Tạo số thứ tự cho mục mới
                int stt = listViewUseService.Items.Count;

                // Tạo một mảng các chuỗi để thêm vào ListView
                string[] row = { stt.ToString(), namefood, price.ToString(), amount.ToString(), total.ToString(), total.ToString() };

                // Tạo một đối tượng ListViewItem từ mảng chuỗi
                ListViewItem listViewItem = new ListViewItem(row);

                // Thêm ListViewItem vào ListView
                listViewUseService.Items.Add(listViewItem);

                // Cập nhật lại số thứ tự cho tất cả các mục
                UpdateListViewIndices();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateListViewIndices()
        {
            for (int i = 0; i < listViewUseService.Items.Count; i++)
            {
                listViewUseService.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }



        private void PaymentandService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataDataSet9.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter1.Fill(this.hotelDataDataSet9.Receipt);
            // TODO: This line of code loads data into the 'hotelDataDataSet8.BookRoomView' table. You can move, or remove it, as needed.
            this.bookRoomViewTableAdapter.Fill(this.hotelDataDataSet8.BookRoomView);
            // TODO: This line of code loads data into the 'hotelDataDataSet7.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.hotelDataDataSet7.Receipt);

        }

        // xử lí pupulate data
        public class InventoryData
        {
            MY_DB mydb = new MY_DB();

            public List<string> GetRoomKinds()
            {
                List<string> names = new List<string>();
                try
                {
                    mydb.openConnection();
                    string query = "SELECT DISTINCT [Name] FROM [HotelData].[dbo].[Inventory]";
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

            public DataRow GetitemDetails(string itemName)
            {
                DataTable table = new DataTable();
                try
                {
                    mydb.openConnection();
                    string query = "SELECT  [Price] FROM [HotelData].[dbo].[Inventory] WHERE [Name] = @Name";
                    SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
                    cmd.Parameters.AddWithValue("@Name", itemName);
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

        InventoryData inventoryData = new InventoryData();
        public void PopulateComboBox()
        {
            List<string> names = inventoryData.GetRoomKinds();
            comboservicelist.DataSource = names;
        }

        private void comboservicelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditemName = comboservicelist.SelectedItem.ToString();
            DataRow inventoryDetails = inventoryData.GetitemDetails(selecteditemName);

            if (inventoryDetails != null)
            {
                txtpriceitems.Text = inventoryDetails["Price"].ToString();
            }
        }

        private void listViewBillRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            
        }


        public static class TotalPriceManager
        {
            public static decimal TotalPrice { get; set; }
        }

        private void UpdateTotalRow()
        {
            // Khởi tạo biến tổng tiền
            decimal totalPrice = 0;

            // Lặp qua từng mục trong ListView
            foreach (ListViewItem item in listViewUseService.Items)
            {
                // Lấy giá trị của cột thứ 5 (index 4) và cộng vào tổng tiền
                totalPrice += decimal.Parse(item.SubItems[4].Text, System.Globalization.NumberStyles.Currency);
            }

            // Tạo một mảng chuỗi để cập nhật giá trị của hàng thứ 14
            string[] row = { "", "", "", "", totalPrice.ToString(), totalPrice.ToString() };

            // Nếu hàng thứ 14 đã tồn tại, cập nhật giá trị của nó
            if (listViewUseService.Items.Count >= 14)
            {
                for (int i = 0; i < listViewUseService.Columns.Count; i++)
                {
                    listViewUseService.Items[13].SubItems[i].Text = row[i];
                }
            }
            else
            {
                // Nếu hàng thứ 14 chưa tồn tại, thêm một hàng mới
                ListViewItem totalItem = new ListViewItem(row);
                listViewUseService.Items.Add(totalItem);
            }
            TotalPriceManager.TotalPrice = totalPrice;
        }

  
        private decimal TotalPayment(decimal servicefee, int dayintotal, decimal roomprice)
        {
            return (dayintotal * roomprice) + servicefee;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtidcard.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ? "" : dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcustomer.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value == DBNull.Value ? "" : dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtidroom.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value == DBNull.Value ? "" : dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dobpicker.Value = DateTime.Now;
            txtdayintotal.Text = Dayintotal(Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value)).ToString();
            txtidbookroom.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value == DBNull.Value ? "" : dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtroomprice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value == DBNull.Value ? "" : dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        


        }

        //Day in total
        private int Dayintotal( DateTime checkin )
        {
            // Giả sử hai thời điểm
            DateTime dateTime1 = checkin;
            DateTime dateTime2 = DateTime.Now;

            int totalDays;

            // Kiểm tra xem hai thời điểm có nằm trong cùng một ngày hay không
            if (dateTime1.Date == dateTime2.Date)
            {
                // Nếu cùng một ngày và chênh lệch dù chỉ vài giây, làm tròn lên thành 1 ngày
                if (dateTime1 != dateTime2)
                {
                    totalDays = 1;
                }
                else
                {
                    totalDays = 0;
                }
            }
            else
            {
                // Nếu không cùng một ngày, tính toán số ngày chênh lệch và làm tròn lên
                TimeSpan duration = dateTime2.Date - dateTime1.Date;
                totalDays = (int)Math.Ceiling(duration.TotalDays);
            }

            return totalDays;
        }

        private void btnpay_Click_1(object sender, EventArgs e)
        {

            UpdateTotalRow();
            txtfee.Text = TotalPriceManager.TotalPrice.ToString();
           
        }


        // Load Foods
        private void LoadFoods()
        {
            db.openConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT [Name] FROM dbo.Inventory", db.getConnection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboservicelist.Items.Add(reader["Name"].ToString());
                    }
                }
            }
            db.closeConnection();
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtfee.Text, out decimal serviceFee) &&
            int.TryParse(txtdayintotal.Text, out int dayInTotal) &&
            decimal.TryParse(txtroomprice.Text, out decimal roomPrice))
            {
                txttotal.Text = TotalPayment(serviceFee, dayInTotal, roomPrice).ToString();
            }
            else
            {
                // Hiển thị thông báo hoặc xử lý lỗi khi các giá trị không hợp lệ
                MessageBox.Show("Vui lòng nhập các giá trị hợp lệ cho phí dịch vụ, số ngày và giá phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // trừ item 
            string selectedFood = comboservicelist.SelectedItem?.ToString();
            int amount = (int)numberofitems.Value;

            if (string.IsNullOrEmpty(selectedFood) || amount <= 0)
            {
                MessageBox.Show("Please select a food and enter a valid amount.");
                return;
            }

            db.openConnection();

            using (SqlCommand cmd = new SqlCommand("SELECT [Number] FROM dbo.Inventory WHERE [Name] = @Name", db.getConnection))
            {
                cmd.Parameters.AddWithValue("@Name", selectedFood);
                int currentNumber = (int)cmd.ExecuteScalar();

                if (currentNumber < amount)
                {
                    MessageBox.Show("Món hàng này đã hết, hãy thêm hàng hóa!");
                }
                else
                {
                    using (SqlCommand updateCmd = new SqlCommand("UPDATE dbo.Inventory SET [Number] = [Number] - @Amount WHERE [Name] = @Name", db.getConnection))
                    {
                        updateCmd.Parameters.AddWithValue("@Amount", amount);
                        updateCmd.Parameters.AddWithValue("@Name", selectedFood);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Đã cập nhật số lượng thành công!");
                    }
                }
            }

            db.closeConnection();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int idrecep = Convert.ToInt32(txtidreceipt.Text);
            int idcustomer = Convert.ToInt32(txtcustomer.Text);
                
                int idroom = Convert.ToInt32(txtidroom.Text);
                int idbookroom = Convert.ToInt32(txtidbookroom.Text);
                DateTime bdate = dobpicker.Value;
                Decimal fee = Convert.ToDecimal(txtfee.Text);
                int dayintotal = Convert.ToInt32(txtdayintotal.Text);
                Decimal total = Convert.ToDecimal(txttotal.Text);

                if (payment.insertPayment(idrecep,idcustomer,idroom,idbookroom,bdate,fee,dayintotal,total))
                {
                    MessageBox.Show("New Info Add", "Add Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to add Info.", "Add Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void LoadData()
        {
            // Tạo và thiết lập lệnh SQL
            string query = "SELECT * FROM dbo.Receipt";
            SqlCommand command = new SqlCommand(query);

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable table = payment.getPayment(command);

            // Gán dữ liệu vào datagridview
            dataGridView1.DataSource = table;
        }
    }
}