using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class Employee0
    {
        MY_DB mydb = new MY_DB();
        public DataTable getEmployee(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertEmployee(int idemployee, string nameemployee, string gender, DateTime dobcustomer, string phonenumber, string addressemployee,string role, string username,string password)
        {

            SqlCommand command = new SqlCommand("INSERT INTO dbo.Employee (ID_Employee, Name, Gender, DOB, PhoneNumber, Address, Role, Username, Password)" +
             "VALUES (@id, @name, @gdr, @dob, @phone, @address, @role, @user, @pass)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idemployee;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameemployee;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@dob", SqlDbType.DateTime).Value = dobcustomer;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phonenumber;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = addressemployee;
            command.Parameters.Add("@role", SqlDbType.VarChar).Value = role;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;

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

        public bool updateEmployee(int idemployee, string nameemployee, string gender, DateTime dobemployee, string phonenumber, string addressemployee, string role, string username, string password)
        {
            SqlCommand command = new SqlCommand(
                "UPDATE dbo.Employee SET Name = @name, Gender = @gdr, DOB = @dob, PhoneNumber = @phone, Address = @address, Role = @role, Username = @user, Password = @pass WHERE ID_Employee = @id",
                mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = idemployee;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameemployee;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@dob", SqlDbType.DateTime).Value = dobemployee;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phonenumber;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = addressemployee;
            command.Parameters.Add("@role", SqlDbType.VarChar).Value = role;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;

            mydb.openConnection();

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

        public bool deleteEmployee(int idemployee)
        {
            SqlCommand command = new SqlCommand("DELETE FROM dbo.Employee WHERE ID_Employee = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = idemployee;

            mydb.openConnection();

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
