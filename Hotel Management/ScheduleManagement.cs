using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.Resources
{
    public partial class ScheduleManagement : Form
    {
        public ScheduleManagement()
        {
            InitializeComponent();
        }

        private void ScheduleManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataDataSet10.Calendar' table. You can move, or remove it, as needed.
            this.calendarTableAdapter.Fill(this.hotelDataDataSet10.Calendar);

        }
    }
}
