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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChanSetpasswordtxtBox.Text.Trim().Length >= 8)
                {
                    if (ChanSetpasswordtxtBox.Text.Trim() == ChanConfirmpasswordtxtBox.Text.Trim())
                    {
                        SqlConnection con = new SqlConnection(@"Data Source = AJITH\SQLEXPRESS; Initial Catalog = EmployeeManagement; Integrated Security = True;");
                        con.Open();

                        SqlCommand cmd = new SqlCommand("SP_register_tbl", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                        cmd.Parameters.Add(p1).Value = ChanUsernametxtbox.Text.Trim();

                        SqlParameter p2 = new SqlParameter("@spassword", SqlDbType.VarChar);
                        cmd.Parameters.Add(p2).Value = ChanSetpasswordtxtBox.Text.Trim();

                        SqlParameter p3 = new SqlParameter("@cpassword", SqlDbType.VarChar);
                        cmd.Parameters.Add(p3).Value = ChanConfirmpasswordtxtBox.Text.Trim();



                        int a = cmd.ExecuteNonQuery();

                        if (a > 0)
                        {
                            MessageBox.Show("Password Updated Successfully");
                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Paassword Updation Failed!!!");
                            ChanUsernametxtbox.Clear();
                            ChanSetpasswordtxtBox.Clear();
                            ChanConfirmpasswordtxtBox.Clear();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
