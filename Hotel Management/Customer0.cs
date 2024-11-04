using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hotel_Management
{
    internal class Customer0
    {
        MY_DB mydb = new MY_DB();
        public DataTable getCustomer(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertCustomer(int idcustomer, string namecustomer, string idcard, string gender, DateTime dobcustomer, string phonenumber, string national)
        {

            SqlCommand command = new SqlCommand("INSERT INTO dbo.Customer (ID_Customer, Name, IDcard, Gender, DOB, PhoneNumber, Nationality)" +
             "VALUES (@id, @name, @Idcard, @gdr, @dob, @phone, @nation)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idcustomer;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = namecustomer;
            command.Parameters.Add("@Idcard", SqlDbType.VarChar).Value = idcard;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@dob", SqlDbType.DateTime).Value = dobcustomer;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phonenumber;
            command.Parameters.Add("@nation", SqlDbType.VarChar).Value = national;

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

        public bool UpdateCustomer(int idcustomer, string namecustomer, string idcard, string gender, DateTime dobcustomer, string phonenumber, string national)
        {
            // Câu lệnh SQL để cập nhật thông tin khách hàng
            SqlCommand command = new SqlCommand("UPDATE dbo.Customer SET Name = @name, IDcard = @Idcard, Gender = @gdr, DOB = @dob, PhoneNumber = @phone, Nationality = @nation WHERE ID_Customer = @id", mydb.getConnection);

            // Gán giá trị cho các tham số
            command.Parameters.Add("@id", SqlDbType.Int).Value = idcustomer;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = namecustomer;
            command.Parameters.Add("@Idcard", SqlDbType.VarChar).Value = idcard;
            command.Parameters.Add("@gdr", SqlDbType.Int).Value = gender;
            command.Parameters.Add("@dob", SqlDbType.DateTime).Value = dobcustomer;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phonenumber;
            command.Parameters.Add("@nation", SqlDbType.VarChar).Value = national;

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

        public bool DeleteCustomer(int idcustomer)
        {
            // Câu lệnh SQL để xóa khách hàng dựa trên ID
            SqlCommand command = new SqlCommand("DELETE FROM  dbo.Customer WHERE ID_Customer = @id", mydb.getConnection);

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
