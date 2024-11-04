using Hotel_Management.Resources;
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
    public partial class AdminMenu : Form
    {
        private bool isCollapsed;
        private bool ismenu;
        private Form currentChildForm;

        public AdminMenu()
        {
            InitializeComponent();
            WelcomeUser();
            ConfigureButtonAccess();
        }

        //Welcome 
        private void WelcomeUser()
        {
            string welcomeMessage = $"{Globals.GlobalUserName}";
            labelname.Text = welcomeMessage; // Assuming you have a label named lblWelcome
        }


        // Phân quyền cho button 
        private void ConfigureButtonAccess()
        {
            string role = Globals.GlobalUserRole;

            if (role == "Labor")
            {
                EnableButtonsForLabor();
            }
            else if (role == "Receiptor")
            {
                EnableButtonsForReceiptor();
            }
        }

        private void EnableButtonsForLabor()
        {
            btnschedule.Enabled = true;
            btncheckinout.Enabled = true;
            btnstatistical.Enabled = true;
            btnmanainventory.Enabled = true;

            btncreateroom.Enabled = false;
            btnbookroom.Enabled = false;
            btnpayment.Enabled = false;
            btnmanaemployee.Enabled = false;
            btnmanacustomer.Enabled = false;

            SetAccessDeniedHandlers();
        }

        private void EnableButtonsForReceiptor()
        {
            btnbookroom.Enabled = true;
            btnschedule.Enabled = true;
            btnmanacustomer.Enabled = true;
            btncheckinout.Enabled = true;
            btnpayment.Enabled = true;
            btnstatistical.Enabled = true;

            btncreateroom.Enabled = false;
            btnmanainventory.Enabled = false;
            btnmanaemployee.Enabled = false;

            SetAccessDeniedHandlers();
        }

        private void SetAccessDeniedHandlers()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button && !button.Enabled)
                {
                    button.Click += AccessDeniedHandler;
                }
            }
        }

        private void AccessDeniedHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                guna2Panel1.Width += 15;
                if (guna2Panel1.Size == guna2Panel1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                guna2Panel1.Width -= 15;
                if (guna2Panel1.Size == guna2Panel1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnshowmenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnmanacustomer_Click(object sender, EventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement();
            customerManagement.ShowDialog();
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btncreateroom_Click(object sender, EventArgs e)
        {
            RoomManagement roomManagement = new RoomManagement();   
            roomManagement.ShowDialog();    
        }

        private void btnbookroom_Click(object sender, EventArgs e)
        {
            Bookroom bookroom = new Bookroom();
            bookroom.ShowDialog();  
        }

        private void btnmanaemployee_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();   
            employeeManagement.ShowDialog();
        }

        private void btnmanainventory_Click(object sender, EventArgs e)
        {
            InventoryManagement inventoryManagement = new InventoryManagement();    
            inventoryManagement.ShowDialog();
        }

        private void btnschedule_Click(object sender, EventArgs e)
        {
            ScheduleManagement scheduleManagement = new ScheduleManagement();
            scheduleManagement.ShowDialog();
        }

        private void btnmanaitems_Click(object sender, EventArgs e)
        {
            PaymentandService paymentandService = new PaymentandService();  
            paymentandService.ShowDialog(); 
        }

        private void btnstatistical_Click(object sender, EventArgs e)
        {
            SalaryEmployee salaryEmployee   = new SalaryEmployee();
            salaryEmployee.ShowDialog();    
        }

        private void guna2CirclePictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Checkinoutwork checkinoutwork   = new Checkinoutwork();
            checkinoutwork.ShowDialog();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
