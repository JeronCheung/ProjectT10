using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ProjectT100.View
{
    public partial class FrmEmail : Form
    {
        public FrmEmail()
        {
            InitializeComponent();
        }

        //private void tbemail_Enter(object sender, EventArgs e)
        //{
        //    if (tbemail.Text == "  Email")
        //    {
        //        tbemail.Clear();
        //        tbemail.ForeColor = Color.FromArgb(83, 179, 233);
        //    }
        //}

        //private void tbemail_Leave(object sender, EventArgs e)
        //{
        //    if (tbemail.Text == "  Email")
        //    {
        //        tbemail.ForeColor = Color.FromArgb(200, 200, 200);
        //        tbemail.Text = "  Email";
        //    }
        //}

        //private void TbMess_Enter(object sender, EventArgs e)
        //{
        //    if (lbtext.Text == "  Message")
        //    {
        //        lbtext.ForeColor = Color.FromArgb(83, 179, 233);
        //    }
        //}

        //private void TbMess_Leave(object sender, EventArgs e)
        //{
        //    if (lbtext.Text == "  Message")
        //    {
        //        lbtext.ForeColor = Color.FromArgb(200, 200, 200);
        //        lbtext.Text = "  Message";
        //    }
        //}

        private void BtnSend_Click(object sender, EventArgs e)
        {

            var fromAddress = new MailAddress("jkl.cheung@gmail.com", "From jeron");
            var toAddress = new MailAddress(tbemail.Text, "To jeron");
            const string fromPassword = "fromPassword";
            const string subject = "Subject";
            const string body = "Uw registratie is succesvol geregistreed";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }


            //string to, from, pass, messagebody;
            //MailMessage message = new MailMessage();
            //to = tbemail.Text;
            //from = "jkl.cheung@gmail.com";
            //pass = "Pokmon10.";
            //messagebody = lbtext.Text;
            //message.To.Add(to);
            //message.From = new MailAddress(from);
            //message.Body = "From : " + "<br>Message: " + messagebody;
            //message.IsBodyHtml = true;
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //smtp.EnableSsl = true;
            //smtp.Port = 587;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Credentials = new NetworkCredential(from, pass);

            //try
            //{
            //    smtp.Send(message);
            //    DialogResult code = MessageBox.Show(" Email is succesvol ", " Email sent ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    if (code == DialogResult.OK) 
            //    {
            //        tbemail.Clear();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
