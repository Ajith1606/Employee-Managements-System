using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kaashiv_Managements_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confiramation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (LogUsernametxtbox.Text.Trim() == "" || LogPasswordtxtbox.Text.Trim() == "")
                {
                    MessageBox.Show("Fill all the Field");
                }
                else if (LogUsernametxtbox.Text.Trim() == "Admin" || LogPasswordtxtbox.Text.Trim() == "12345")
                {
                    MessageBox.Show("Welcome Administrator");
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source = AJITH\SQLEXPRESS; Initial Catalog = EmployeeManagement; Integrated Security = True;");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_login", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = LogUsernametxtbox.Text.Trim();

                    SqlParameter p2 = new SqlParameter("@cpassword", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = LogPasswordtxtbox.Text.Trim();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    int a = Convert.ToInt32(ds.Tables[0].Rows.Count);
                    if (a > 0)
                    {
                        MessageBox.Show("Welcome Back " + LogUsernametxtbox.Text);
                        EmpDashboard empDashboard = new EmpDashboard();
                        empDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username");
                    }
                    con.Close();
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void llLoginReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogUsernametxtbox.Clear();
            LogPasswordtxtbox.Clear();
        }

        private void LogShowpasswordchkBox_CheckedChanged(object sender, EventArgs e)
        {
            LogPasswordtxtbox.PasswordChar = LogShowpasswordchkBox.Checked ? '\0' : '*';
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void llForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
            this.Hide();
        }
    }
}
