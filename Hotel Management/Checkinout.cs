using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    public class Checkinout
    {
        MY_DB mydb = new MY_DB();
        public DataTable getcheck(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static void CheckIn(string idCheckInOut, string idCalendar, string idEmployee)
        {
            MY_DB db = new MY_DB();
            string query = "INSERT INTO Checkinout (ID_Checkinout, ID_Calendar, ID_Employee, TimeCheckin, TimeCheckout, Day) " +
                               "VALUES (@ID_Checkinout, @ID_Calendar, @ID_Employee, @TimeCheckin, NULL, @Day)";
                using (SqlCommand command = new SqlCommand(query, db.getConnection ))
                {
                    command.Parameters.AddWithValue("@ID_Checkinout", idCheckInOut);
                    command.Parameters.AddWithValue("@ID_Calendar", idCalendar);
                    command.Parameters.AddWithValue("@ID_Employee", idEmployee);
                    command.Parameters.AddWithValue("@TimeCheckin", DateTime.Now);
                    command.Parameters.AddWithValue("@Day", DateTime.Today);

                db.openConnection();
                   command.ExecuteNonQuery();
                }
        }

        public static void CheckOut(string idCheckInOut)
        {
            MY_DB db = new MY_DB();
            string query = "UPDATE Checkinout SET TimeCheckout = @TimeCheckout WHERE ID_Checkinout = @ID_Checkinout";
                using (SqlCommand command = new SqlCommand(query, db.getConnection))
                {
                    command.Parameters.AddWithValue("@TimeCheckout", DateTime.Now);
                    command.Parameters.AddWithValue("@ID_Checkinout", idCheckInOut);

                db.openConnection();
                    command.ExecuteNonQuery();
                }
            

   
        }
    }
}
