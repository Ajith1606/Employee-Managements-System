using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaashiv_Managements_System
{
    public partial class EmployeeSalary : Form
    {
        public string Gender = "";
        public EmployeeSalary()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(guna2RadioButtonmale.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            Invoice invoice = new Invoice();
            invoice.img = EmployeesalarypictureBox.Image;
            invoice.name = guna2TextBoxname.Text;
            if(guna2ComboBoxdepart.SelectedIndex == -1)
            {
                invoice.department = "";
            }
            else
            {
                invoice.department = guna2ComboBoxdepart.Text;
            }           
            invoice.salary = guna2TextBoxsalary.Text;
            invoice.bonus = guna2TextBoxbonus.Text;
            invoice.total = guna2TextBoxtotal.Text;
            invoice.gender = Gender;
            invoice.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp) |" +
                " *.jpg; *.jpeg; *.png; *.gif; *.bmp | All files(*.*) | *.*";
            dialog.Title = "Select an Employee Image";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = dialog.FileName;
                EmployeesalarypictureBox.Image = Image.FromFile(filepath);
            }
        }

        private void guna2TextBoxbonus_TextChanged(object sender, EventArgs e)
        {
            if(guna2TextBoxbonus.Text.Length > 0)
            {
                guna2TextBoxtotal.Text = (Convert.ToInt64(guna2TextBoxsalary.Text) + Convert.ToInt64(guna2TextBoxbonus.Text)).ToString();
            }
        }
    }
}
