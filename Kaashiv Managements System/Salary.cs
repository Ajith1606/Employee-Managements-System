using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaashiv_Managements_System
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void SalManagerradioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SalManagerradioBtn.ForeColor = Color.Green;
            SalEmployeeradioBtn.ForeColor = Color.Red;

            SalUsernamecombBox.Items.Clear();
            SalUsernamecombBox.Items.Add("Venkat");
            SalUsernamecombBox.Items.Add("Praveen");
        }

        private void SalEmployeeradioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SalManagerradioBtn.ForeColor = Color.Red;
            SalEmployeeradioBtn.ForeColor = Color.Green;

            SalUsernamecombBox.Items.Clear();
            SalUsernamecombBox.Items.Add("Nizar");
            SalUsernamecombBox.Items.Add("Nandha");
        }

        private void SalUsernamecombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SalUsernamecombBox.SelectedItem.ToString() == "Venkat")
            {
                SalTotalsalarytxtbox.Text = "120000";
            }
            else if (SalUsernamecombBox.SelectedItem.ToString() == "Praveen")
            {
                SalTotalsalarytxtbox.Text = "220000";
            }
            else if (SalUsernamecombBox.SelectedItem.ToString() == "Nizar")
            {
                SalTotalsalarytxtbox.Text = "50000";
            }
            else if (SalUsernamecombBox.SelectedItem.ToString() == "Nandha")
            {
                SalTotalsalarytxtbox.Text = "70000";
            }
            else
            {
                SalTotalsalarytxtbox.Text = "0";
            }
        }

        private void SalBonustxtbox_TextChanged(object sender, EventArgs e)
        {
            if(SalTotalsalarytxtbox.Text.Length > 0)
            {
                SalTotaltxtbox.Text = (Convert.ToInt64(SalTotalsalarytxtbox.Text) + Convert.ToInt64(SalBonustxtbox.Text)).ToString();
            }
        }

        private void SalbtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = AJITH\SQLEXPRESS; Initial Catalog = EmployeeManagement; Integrated Security = True;");
                con.Open();

                SqlCommand cmd = new SqlCommand("SP_salary", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = SalUsernamecombBox.SelectedItem.ToString();

                SqlParameter p2 = new SqlParameter("@salary", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = SalTotalsalarytxtbox.Text.Trim();

                SqlParameter p3 = new SqlParameter("@bonus", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = SalBonustxtbox.Text.Trim();

                SqlParameter p4 = new SqlParameter("@total", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = SalTotaltxtbox.Text.Trim();


                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Employee Salary Added");
                }
                else
                {
                    MessageBox.Show("Failed!!!");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SalbtnFetch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = AJITH\SQLEXPRESS; Initial Catalog = EmployeeManagement; Integrated Security = True;");
                con.Open();

                SqlCommand cmd = new SqlCommand("SP_salary_fetch", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SalbtnAdd_MouseHover(object sender, EventArgs e)
        {
            SalbtnAdd.BackColor = Color.Green;
        }

        private void SalbtnAdd_MouseLeave(object sender, EventArgs e)
        {
            SalbtnAdd.BackColor = Color.White;
        }

        private void SalbtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp) |" +
                " *.jpg; *.jpeg; *.png; *.gif; *.bmp | All files(*.*) | *.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if(dialog.ShowDialog() == DialogResult.OK) 
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }
    }
}
