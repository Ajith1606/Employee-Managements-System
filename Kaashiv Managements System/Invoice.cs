using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaashiv_Managements_System
{
    public partial class Invoice : Form
    {

        public string name, department, salary, bonus, total, gender;
        private Bitmap bm;

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        private void invoicepictureBox_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(bm, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        public Image img = null;

        public Invoice()
        {
            InitializeComponent();
        }

        private void Print(Panel a)
        {
            PrinterSettings p = new PrinterSettings();
            panel1 = a;
            bm = new Bitmap(a.Width, a.Height);
            a.DrawToBitmap(bm, new Rectangle(0, 0, a.Width, a.Height));
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.Show();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
            invoicepictureBox.Image = img;
            lblname.Text = name;
            lblDepartment.Text = department;
            lblSalary.Text = salary;
            lblBonus.Text = bonus;
            lblTotal.Text = total;
            lblGender.Text = gender;
        }

    }
}
