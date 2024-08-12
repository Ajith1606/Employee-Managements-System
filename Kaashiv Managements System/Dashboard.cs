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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confiramation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                MessageBox.Show("Logout Successfully");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = AJITH\SQLEXPRESS; Initial Catalog = EmployeeManagement; Integrated Security = True;");
                con.Open();

                SqlCommand cmd = new SqlCommand("SP_emp_register", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@emp_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = DashEmpidtxtbox.Text.Trim();

                SqlParameter p2 = new SqlParameter("@emp_name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = DashEmpnametxtbox.Text.Trim();

                SqlParameter p3 = new SqlParameter("@emp_salary", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = DashEmpsalarytxtbox.Text.Trim();

                SqlParameter p4 = new SqlParameter("@emp_dep", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = DashEmpdepacomBox.SelectedItem.ToString();

                SqlParameter p5 = new SqlParameter("@emp_role", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = DashEmprolecombox.SelectedItem.ToString();

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Employee details Added");
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

        private void btnFetch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = AJITH\SQLEXPRESS; Initial Catalog = EmployeeManagement; Integrated Security = True;");
                con.Open();

                SqlCommand cmd = new SqlCommand("SP_fetch", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DashDatagridView.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Delete Employee?", "Confiramation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = AJITH\SQLEXPRESS; Initial Catalog = EmployeeManagement; Integrated Security = True;");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@emp_id", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = DashEmpsearchtxtbox.Text;

                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        MessageBox.Show("Data Deleted Successfully");
                    }
                    con.Close();
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = AJITH\SQLEXPRESS; Initial Catalog = EmployeeManagement; Integrated Security = True;");
                con.Open();

                SqlCommand cmd = new SqlCommand("SP_searchdata", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@searchdata", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = DashEmpsearchtxtbox.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DashDatagridView.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = AJITH\SQLEXPRESS; Initial Catalog = EmployeeManagement; Integrated Security = True;");
                con.Open();

                SqlCommand cmd = new SqlCommand("SP_update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@emp_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = DashEmpidtxtbox.Text.Trim();

                SqlParameter p2 = new SqlParameter("@emp_name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = DashEmpnametxtbox.Text.Trim();

                SqlParameter p3 = new SqlParameter("@emp_salary", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = DashEmpsalarytxtbox.Text.Trim();

                SqlParameter p4 = new SqlParameter("@emp_dep", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = DashEmpdepacomBox.SelectedItem.ToString();

                SqlParameter p5 = new SqlParameter("@emp_role", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = DashEmprolecombox.SelectedItem.ToString();

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Employee details Updated");
                }
                else
                {
                    MessageBox.Show("Updation Failed!!!");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap b = new Bitmap(DashDatagridView.Width, DashDatagridView.Height);
            DashDatagridView.DrawToBitmap(b, new Rectangle(0, 0, DashDatagridView.Width, DashDatagridView.Height));
            e.Graphics.DrawImage(b, 120, 120);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void DashDatagridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DashEmpidtxtbox.Text = DashDatagridView.SelectedRows[0].Cells[0].Value.ToString();
                DashEmpnametxtbox.Text = DashDatagridView.SelectedRows[0].Cells[1].Value.ToString();
                DashEmpsalarytxtbox.Text = DashDatagridView.SelectedRows[0].Cells[2].Value.ToString();
                DashEmpdepacomBox.Text = DashDatagridView.SelectedRows[0].Cells[3].Value.ToString();
                DashEmprolecombox.Text = DashDatagridView.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
