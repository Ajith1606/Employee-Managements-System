using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kaashiv_Managements_System
{
    public partial class Loading2 : Form
    {
        public Loading2()
        {
            InitializeComponent();
        }

        private void Loading2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value < 100)
            {
                guna2CircleProgressBar1.Value += 2;
                label2.Text = guna2CircleProgressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Loaded succefully");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
