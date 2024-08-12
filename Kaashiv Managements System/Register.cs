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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace Kaashiv_Managements_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        public bool IsEmailValid(string email)
        {
            string pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

            Regex r = new Regex(pattern);
            return r.IsMatch(email);
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (RegUsernametxtbox.Text.Trim() != "" && RegSetpasswordtxtBox.Text.Trim() != "" && RegConfirmpasswordtxtBox.Text.Trim() != "" && RegEmailtxtbox.Text.Trim() != "" && RegPhonetxtbox.Text.Trim() != "")
                {
                    string emailaddress = RegEmailtxtbox.Text;
                    bool isValid = IsEmailValid(emailaddress);
                    if(isValid)
                    {
                        if (RegSetpasswordtxtBox.Text.Trim().Length >= 8)
                        {
                            if (RegSetpasswordtxtBox.Text.Trim() == RegConfirmpasswordtxtBox.Text.Trim())
                            {
                                SqlConnection con = new SqlConnection(@"Data Source = AJITH\SQLEXPRESS; Initial Catalog = EmployeeManagement; Integrated Security = True;");
                                con.Open();

                                SqlCommand cmd = new SqlCommand("SP_register", con);
                                cmd.CommandType = CommandType.StoredProcedure;

                                SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                                cmd.Parameters.Add(p1).Value = RegUsernametxtbox.Text.Trim();

                                SqlParameter p2 = new SqlParameter("@spassword", SqlDbType.VarChar);
                                cmd.Parameters.Add(p2).Value = RegSetpasswordtxtBox.Text.Trim();

                                SqlParameter p3 = new SqlParameter("@cpassword", SqlDbType.VarChar);
                                cmd.Parameters.Add(p3).Value = RegConfirmpasswordtxtBox.Text.Trim();

                                SqlParameter p4 = new SqlParameter("@email", SqlDbType.VarChar);
                                cmd.Parameters.Add(p4).Value = RegEmailtxtbox.Text.Trim();

                                SqlParameter p5 = new SqlParameter("@phonenum", SqlDbType.VarChar);
                                cmd.Parameters.Add(p5).Value = RegPhonetxtbox.Text.Trim();

                                int a = cmd.ExecuteNonQuery();

                                if (a > 0)
                                {
                                    MessageBox.Show("Registered Successfully");
                                }
                                else
                                {
                                    MessageBox.Show("Registeration Failed");
                                    con.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("SetPassword and ConfirmPassword should be same");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be greater or equal to 8 digit");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter Email in correct format");
                    }                   
                }
                else
                {
                    MessageBox.Show("Please fill the  all field");
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);

            }                            
        }

        private void llRegisterReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegUsernametxtbox.Clear();
            RegSetpasswordtxtBox.Clear();
            RegConfirmpasswordtxtBox.Clear();
            RegEmailtxtbox.Clear();
            RegPhonetxtbox.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confiramation Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }  

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
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
    }
}
