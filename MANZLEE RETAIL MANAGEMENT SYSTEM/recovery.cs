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
using System.Net.Mail;
using System.Net;

namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
   
    public partial class recovery : Syncfusion.Windows.Forms.MetroForm
    {
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        public recovery()
        {
            InitializeComponent();
        }

        private void btnSnd_Click(object sender, EventArgs e)
        {
            try
            {
                /*DataSet ds = new DataSet();

                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("select password from PASSWORD WHERE username=ADMINISTRATOR ");
                SqlCommand CM = new SqlCommand("select email from PASSWORD WHERE username =ADMINISTRATOR");
                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = "smtp.gmail.com";

                mail.Sender.Equals(CM);
                mail.Subject = "Password forgotten email.";
                mail.Body = "this is my test email body" + Convert.ToString(ds.Tables.Equals("password"));
                client.Send(mail);/*/

                Cursor = Cursors.WaitCursor;

                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT password FROM PASSWORD Where email = '" + txtEmail.Text + "'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MailMessage Msg = new MailMessage();
                    // Sender e-mail address.
                    Msg.From = new MailAddress("manzinilee@gmail.com");
                    // Recipient e-mail address.
                    Msg.To.Add(txtEmail.Text);
                    Msg.Subject = "Your Password Details";
                    Msg.Body = "Your Password: " + Convert.ToString(ds.Tables[0].Rows[0]["password"]) + "";
                    Msg.IsBodyHtml = true;
                    // your remote SMTP server IP.
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("manzinilee@gmail.com", "27041999ml");
                    smtp.EnableSsl = true;
                    smtp.Send(Msg);
                    MessageBox.Show(("Password Successfully sent " + ("\r\n" + "Please check your mail")), "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Hide();
                    Passsword secondForm = new Passsword();
                    secondForm.Show();



                }
                else
                    MessageBox.Show("Error! Message not send.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
