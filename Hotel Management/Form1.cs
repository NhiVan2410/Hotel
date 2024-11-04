using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class Form1 : Form
    {
        Access access = new Access();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            // Check if the user is a manager or an employee
            if (btnmanager.Checked) // Assuming you have radio buttons to select user type
            {
                access.LoginAsManager(username, password);
            }
            else if (btnemployee.Checked)
            {
                access.LoginAsEmployee(username, password);
            }
            else if (btnadmin.Checked)
            {
                txtusername.Text = "admin";
                txtpassword.Text = "admin";
                Globals.SetGlobalUserID(-1); // Admin ID can be a special value
                Globals.SetGlobalUserName("Admin");
                Globals.SetGlobalUserRole("Admin");

                MessageBox.Show("Welcome Admin!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            else
            {
                MessageBox.Show("Please select user type", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
