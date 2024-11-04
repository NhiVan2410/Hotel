using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class Payment
    {
        MY_DB mydb = new MY_DB();
        public DataTable getPayment(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertPayment( int idrecep, int idcustomer, int idroom,int idbookroom, DateTime dob, decimal fee, int daytotal, decimal total )
        {

            SqlCommand command = new SqlCommand("INSERT INTO dbo.Receipt (ID_Receipt, ID_Customer, ID_Room, ID_BookRoom, Timemake, Service_fee, Dayintotal, Totalpayment)" +
             "VALUES ( @idre, @idcus, @idro, @idbo, @time, @fee, @daytotal, @total)", mydb.getConnection);
            command.Parameters.Add("@idre", SqlDbType.Int).Value = idrecep;
            command.Parameters.Add("@idcus", SqlDbType.Int).Value = idcustomer;
            command.Parameters.Add("@idro", SqlDbType.Int).Value = idroom;
            command.Parameters.Add("@idbo", SqlDbType.Int).Value = idbookroom;
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = dob;
            command.Parameters.Add("@fee", SqlDbType.Decimal).Value = fee;
            command.Parameters.Add("@daytotal", SqlDbType.Int).Value = daytotal;
            command.Parameters.Add("@total", SqlDbType.Decimal).Value = total;

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
    }
}
