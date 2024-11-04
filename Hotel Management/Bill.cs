using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 58, 70);
            bitmap.Dispose();
        }
        Bitmap bitmap;

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void lblRoomPrice_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            bitmap = new Bitmap(708, 647, graphics);
            Graphics _graphics = Graphics.FromImage(bitmap);
            _graphics.CopyFromScreen(this.Location.X, this.Location.Y + 28, 0, 0, new Size(708, 647));
            bitmap.Save(Application.StartupPath + @"\Bill.Png", ImageFormat.Png);
            bitmap = new Bitmap(Application.StartupPath + @"\Bill.Png");
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
    }
}
