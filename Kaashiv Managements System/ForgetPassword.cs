using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Kaashiv_Managements_System
{
    public partial class ForgetPassword : Form
    {
        string randomcode;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void btnOtp_Click(object sender, EventArgs e)
        {
            string pass, messagebody, from, to;
            Random random = new Random();
            randomcode = (random.Next(999999)).ToString();
            MailMessage mailMessage = new MailMessage();
            to = (ForgetEmailtxtbox.Text).ToString();
            from = "ajith16062001@gmail.com";
            pass = "gfsw dsvu wdfu ghab";
            messagebody = "Your OTP Verification Code : " + randomcode;
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Body = messagebody;
            mailMessage.Subject = "Employee Management Verification";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("OTP Sended Successfully", "OTP Verification");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerifyotp_Click(object sender, EventArgs e)
        {
            if (randomcode == (ForgetOtptxtbox.Text).ToString())
            {
                MessageBox.Show("OTP Verified Successfully", "OTP Verification");
                ChangePassword changePassword = new ChangePassword();
                changePassword.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid OTP", "OTP Verification");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confiramation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
