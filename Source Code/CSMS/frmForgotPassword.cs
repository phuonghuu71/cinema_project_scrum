using CSMS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMS
{
    public partial class frmForgotPassword : Form
    {
        public static string to;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody, randomCode;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "phamnguyenhuuphuong2000@gmail.com";
            pass = "Phuong24122000";
            messageBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Mã reset mật khẩu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                AccountDAL.Instance.changepwd(txtUsername.Text, randomCode);
                smtp.Send(message);
                MessageBox.Show("Vui lòng kiểm tra email để xem mật khẩu vừa reset", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin df = new frmLogin();
            df.ShowDialog();
            this.Close();
        }
    }
}
