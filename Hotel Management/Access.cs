using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    internal class Access
    {
        MY_DB db = new MY_DB();
        public void LoginAsManager(string username, string password)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Manager WHERE Username = @User AND Password = @Pass", db.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Globals.SetGlobalUserID(int.Parse(table.Rows[0]["ID_Manager"].ToString()));
                Globals.SetGlobalUserName(table.Rows[0]["Name"].ToString());

                AdminMenu adminMenu = new AdminMenu();  
                adminMenu.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void LoginAsEmployee(string username, string password)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Employee WHERE Username = @User AND Password = @Pass", db.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Globals.SetGlobalUserID(int.Parse(table.Rows[0]["ID_Employee"].ToString()));
                Globals.SetGlobalUserName(table.Rows[0]["Name"].ToString());
                Globals.SetGlobalUserRole(table.Rows[0]["Role"].ToString());
                string role = table.Rows[0]["Role"].ToString();

                // Show appropriate message based on the role
                if (role == "Labor")
                {
                    MessageBox.Show("Welcome Labor!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (role == "Receiptor")
                {
                    MessageBox.Show("Welcome Receiptor!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unknown role", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Open MainFormStudent with role-specific button configurations
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
