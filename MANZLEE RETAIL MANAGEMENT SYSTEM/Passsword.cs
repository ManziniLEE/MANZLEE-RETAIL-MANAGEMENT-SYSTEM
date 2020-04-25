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

namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    public partial class Passsword : Syncfusion.Windows.Forms.MetroForm
    {
        public Passsword()
        {
            InitializeComponent();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lap top\Documents\Visual Studio 2015\Projects\MANZLEE RETAIL MANAGEMENT SYSTEM\MANZLEE RETAIL MANAGEMENT SYSTEM\PURCHAS.mdf;");
                conn.Open();
                string ct = "select password from PASSWORD where username='" + txtUsername.Text + "'";
                SqlCommand cmd;
                SqlDataReader rdr;
               
                cmd = new SqlCommand(ct);
                cmd.Connection = conn;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                 
                if (txtPasswd.Text==rdr[0].ToString())
                {
                    MessageBox.Show("WELCOME");
                    this.Hide();
                   
                }

                else 
                {
                    MessageBox.Show("WRONG PASSWORD");

                    txtPasswd.Focus();
                    
                }
                }
               
                conn.Close();
                return;
                
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
           
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
                
        }

        private void Passsword_Load(object sender, EventArgs e)
        {

        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recovery secondForm = new recovery();
            secondForm.Show();
        }
    }
    }

