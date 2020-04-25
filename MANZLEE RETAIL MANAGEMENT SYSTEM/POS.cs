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
using System.Security.Cryptography;

namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
   
    public partial class POS : Form
    {
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        public POS()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void auto()
        {
            txtInvoice.Text = "INV-" + GetUniqueKey(8);

        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                {
                    SqlConnection conn = new SqlConnection(cs.dbcon);
                    conn.Open();
                    // SqlCommand cmd = new SqlCommand("select ITEM_Id, ITEM_NAME, CATEGORY,  PRICE_VAT from STOCK where ITEM_Id = '" + txtItemno.Text + "'", conn);
                    //rdr = cmd.ExecuteReader();

                    SqlDataReader dr;
                    SqlCommand sad = new SqlCommand("select ITEM_NAME, PRICE_VAT from STOCK where ITEM_Id = '" + txtItemno.Text + "'", conn);
                    dr = sad.ExecuteReader();
                    while (dr.Read())
                    {
                        txtNma.Text = (string)dr["ITEM_NAME"].ToString();
                        txtItempri.Text = (string)dr["PRICE_VAT"].ToString();
                        txtQnty.Text = (string)dr["QUANTITY"].ToString();
                    }

                    dr.Close();


                    /* dr = new DataTable();
                     sad.Fill(dr);
                     dataGridView1.DataSource = dr;
                     // while (rdr.Read() == true)
                     /* {
                          dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
                      }*/
                    conn.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            try
            {
                /*SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();

                SqlCommand cm = new SqlCommand("select QUANTITY from STOCK where ITEM_Id ='" + txtItemno.Text + "'", con);

                SqlDataReader reader = cm.ExecuteReader();
                reader.Read();
                DataSet data = new DataSet();
                int i = data.Tables["QUANTITY"].Rows.Count;
                qntyAvailable.Text = i.ToString();
                con.Close();*/
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
            // TODO: This line of code loads data into the 'pURCHASDataSet1.STOCK' table. You can move, or remove it, as needed.
            // this.sTOCKTableAdapter.Fill(this.pURCHASDataSet1.STOCK);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


      

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void qntyAvailable_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /*SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();

                SqlCommand cm =new SqlCommand("select QUANTITY from STOCK where ITEM_Id ='" +txtItemno.Text+"')", con);
           
            SqlDataReader reader = cm.ExecuteReader();
            reader.Read();
            DataSet data = new DataSet();
            int i = data.Tables["QUANTITY"].Rows.Count;
            qntyAvailable.Text = i.ToString();
                con.Close();*/
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }

        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            try
            {
                auto();
                SqlConnection conn = new SqlConnection(cs.dbcon);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into SALES(invoiceno, itemno, item_name, item_price, total_amnt, quantity, DATE ) VALUES(@invo, @itno,@itnam, @itpri, @totam, @qua,@dat)", conn);

                cmd.Parameters.Add("@invo", SqlDbType.NVarChar, 50).Value = txtInvoice.Text;
                cmd.Parameters.AddWithValue("@itno", txtItemno.Text);
                cmd.Parameters.AddWithValue("@itnam", txtNma.Text);
                cmd.Parameters.AddWithValue("@itpri", txtItempri.Text);
                cmd.Parameters.AddWithValue("@totam", txtTotprice.Text);
                cmd.Parameters.AddWithValue("@qua", txtQnty.Text);
                cmd.Parameters.AddWithValue("@dat", dtpTime.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                SqlCommand sda = new SqlCommand("select invoiceno,itemno,item_name,item_price,total_amnt,quantity,DATE FROM SALES ", conn);
                SqlDataReader DR;
                DR = sda.ExecuteReader();
                //sda.Fill(DR);
                listView1.Items.Add(txtInvoice.Text);
                listView1.Items.Add(txtItemno.Text);
                listView1.Items.Add(txtNma.Text);
                listView1.Items.Add(txtQnty.Text);
                listView1.Items.Add(txtTotprice.Text);
                listView1.Items.Add(txtItempri.Text);
                listView1.Items.Add(dtpTime.Text);

                ResetText();
                for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {
                    conn = new SqlConnection(cs.dbcon);

                    string cd = "insert Into SALES(invoiceno,itemno,item_name,quantity,price,total_amnt) VALUES (@d1,@d2,@d3,@d4,@d5,@d6)";
                    cmd = new SqlCommand(cd);
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("d1", txtInvoice.Text);
                    cmd.Parameters.AddWithValue("d2", listView1.Items[i].SubItems[1].Text);
                    cmd.Parameters.AddWithValue("d3", listView1.Items[i].SubItems[2].Text);
                    cmd.Parameters.AddWithValue("d4", listView1.Items[i].SubItems[4].Text);
                    cmd.Parameters.AddWithValue("d5", listView1.Items[i].SubItems[3].Text);
                    cmd.Parameters.AddWithValue("d6", listView1.Items[i].SubItems[5].Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {
                    conn = new SqlConnection(cs.dbcon);
                    conn.Open();
                    string cb1 = "update STOCK set QUANTITY = QUANTITY - " + listView1.Items[i].SubItems[4].Text + " where  Item_Id= '" + listView1.Items[i].SubItems[1].Text + "'";
                    cmd = new SqlCommand(cb1);
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }


             

            }
            catch (Exception der)
            {
                MessageBox.Show(der.Message);
            }


        }

        private void qntyAvailable_Click(object sender, EventArgs e)
        {


        }

        private void lnlcalculat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            /* p.WaitForInputIdle();
             NativeMethods.SetParent(p.MainWindowHandle, this.Handle);*/
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtQnty_TextChanged(object sender, EventArgs e)
        {
            //decimal pri, qty, tot, hol;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

    

