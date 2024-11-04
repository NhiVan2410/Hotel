using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class Room0
    {
        MY_DB mydb = new MY_DB();

        public DataTable getRoom(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool inserRoom(int idroom, string nameroom, string roomstate, string typeroom, string roomprice)
        {

            SqlCommand command = new SqlCommand("INSERT INTO dbo.Room (ID_Room, Name, State, Kind, Price)" +
             "VALUES (@id, @name, @state, @type, @price)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idroom;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameroom;
            command.Parameters.Add("@state", SqlDbType.VarChar).Value = roomstate;
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = typeroom;
            command.Parameters.Add("@price", SqlDbType.VarChar).Value = roomprice;

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

        public bool updateRoom(int idroom, string nameroom, string roomstate, string typeroom, string roomprice)
        {
            SqlCommand command = new SqlCommand("UPDATE dbo.Room  SET Name = @name, State = @state, Kind = @type, Price = @price WHERE ID_Room = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = idroom;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameroom;
            command.Parameters.Add("@state", SqlDbType.VarChar).Value = roomstate;
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = typeroom;
            command.Parameters.Add("@price", SqlDbType.VarChar).Value = roomprice;

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

        public bool deleteRoom(int idroom)
        {
            SqlCommand command = new SqlCommand("DELETE FROM dbo.Room  WHERE ID_Room = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = idroom;

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
