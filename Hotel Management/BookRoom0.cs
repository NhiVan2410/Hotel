using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class BookRoom0
    {
        MY_DB mydb = new MY_DB();
        public DataTable getInfoBookRoom(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertBookroom(int idbookroom, int idcustomer, int idroom, DateTime timecheckin, DateTime timecheckout)
        {

            SqlCommand command = new SqlCommand("INSERT INTO dbo.BookRoom (ID_BookRoom, ID_Customer, ID_Room, Timecheckin, Timecheckout)" +
             "VALUES (@idbr, @idcus, @idr, @timein, @timeout)", mydb.getConnection);
            command.Parameters.Add("@idbr", SqlDbType.Int).Value = idbookroom;
            command.Parameters.Add("@idcus", SqlDbType.Int).Value = idcustomer;
            command.Parameters.Add("@idr", SqlDbType.Int).Value = idroom;
            command.Parameters.Add("@timein", SqlDbType.DateTime).Value = timecheckin;
            command.Parameters.Add("@timeout", SqlDbType.DateTime).Value = timecheckout;


            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool DeleteCustomer(int idcustomer)
        {
            // Câu lệnh SQL để xóa khách hàng dựa trên ID
            SqlCommand command = new SqlCommand("DELETE FROM   dbo.BookRoom WHERE ID_BookRoom = @id", mydb.getConnection);

            // Gán giá trị cho tham số
            command.Parameters.Add("@id", SqlDbType.Int).Value = idcustomer;

            // Mở kết nối và thực thi câu lệnh
            mydb.openConnection();

            // Kiểm tra xem câu lệnh thực thi thành công không
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
