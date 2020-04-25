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
    public partial class CPwd : Syncfusion.Windows.Forms.MetroForm
    {
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        public CPwd()
        {
            InitializeComponent();
        }

        private void CPwd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text=="")
            {
                MessageBox.Show("ENTER EMAIL ADDRESS PLEASE");
                txtEmail.Focus();

            }
            
            
            if (txtNew.Text == "")
            {
                MessageBox.Show("ENTER NEW PASSWORD PLEASE");
                txtNew.Focus();
            }
            if(txtConf.Text==""&&txtNew.Text!=txtConf.Text)
            {
                MessageBox.Show("CONFIRM PASSWORD PLEASE");
                txtConf.Focus();

            }
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();

                string co = "UPDATE PASSWORD set password = '" + txtNew.Text + "' where username='" + txtUser.Text + "' ";//and password = '" + txtOld.Text + "'

                SqlCommand cmd = new SqlCommand(co);
                cmd.Connection = con;
                var RowsAffected = cmd.ExecuteNonQuery();
                cmd.Dispose();
                if ((RowsAffected > 0))
                {
                    MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    
                    txtNew.Text = "";
                    txtOld.Text = "";
                    txtConf.Text = "";
                     
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR", err.Message);
            }

        }


       
    }
}
