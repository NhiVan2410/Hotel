using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class Inventory
    {

        MY_DB mydb = new MY_DB();
        public DataTable getInventory(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertInventory(int iditem, string nameitem, int amountitem, string price)
        {

            SqlCommand command = new SqlCommand("INSERT INTO dbo.Inventory (ID_Inventory, Name, Number, Price)" +
             "VALUES (@id, @name, @amount, @price)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = iditem;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameitem;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amountitem;
            command.Parameters.Add("@price", SqlDbType.VarChar).Value = price;


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

        public bool updateItem(int iditem, string nameitem, int amountitem, string price)
        {
            SqlCommand command = new SqlCommand("UPDATE dbo.Inventory SET Name = @name, Number = @amount, Price = @price WHERE ID_Inventory = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = iditem;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameitem;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amountitem;
            command.Parameters.Add("@price", SqlDbType.VarChar).Value = price;

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

        public bool deleteItem(int iditem)
        {
            SqlCommand command = new SqlCommand("DELETE FROM dbo.Inventory WHERE ID_Inventory = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = iditem;

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
