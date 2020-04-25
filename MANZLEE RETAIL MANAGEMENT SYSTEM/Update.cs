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

    public partial class Update : Syncfusion.Windows.Forms.MetroForm
    {
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        public Update()
        {
            InitializeComponent();
           // btnupdate.Enabled = false;
           // btndelete.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("select PRODUCT_NAME,PRICE_PER_UNIT,QUANTITY,WEIGHT_KG_LTRES,SUPPLIER,SUPPLIER_CONTACT,CATEGORY FROM PURCHTB where PRODUCT_Id='" + txtid.Text + "'", con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtname.Text = rdr["PRODUCT_NAME"].ToString();
                    txtprice.Text = rdr["PRICE_PER_UNIT"].ToString();
                    txtqnty.Text = rdr["QUANTITY"].ToString();
                    txtweightt.Text = rdr["WEIGHT_KG_LTRES"].ToString();
                    txtsupp.Text = rdr["SUPPLIER"].ToString();
                    txtsuppc.Text = rdr["SUPPLIER_CONTACT"].ToString();
                    txtcate.Text = rdr["CATEGORY"].ToString();
                }
                con.Close();
            }
            catch (Exception ret)
            {
                MessageBox.Show(ret.Message);
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {
            try
            {
            SqlConnection con = new SqlConnection(cs.dbcon);
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from PURCHTB", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dgvpurchase.DataSource = dt;
            con.Close();
            } catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
        private void clear()
        {
            txtid.Clear();
            txtcate.Clear();
            txtname.Clear();
            txtprice.Clear();
            txtqnty.Clear();
            txtsupp.Clear();
            txtsuppc.Clear();
            txtweight.Text = "";
            txtweightt.Clear();
            btnupdate.Enabled = true;         
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("update PURCHTB SET PRODUCT_NAME = '" + txtname.Text + "',PRICE_PER_UNIT ='" + txtprice.Text + "',QUANTITY ='" + txtqnty.Text + "',WEIGHT_KG_LTRES = '" + txtweightt.Text + "',SUPPLIER = '" + txtsupp.Text + "' ,SUPPLIER_CONTACT ='" + txtsuppc.Text + "',CATEGORY = '" + txtcate.Text + "', DATE ='"+dateTimePicker1.Text+"' where PRODUCT_Id='"+txtid.Text+"'"  , con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("DATA UPDATE SUCCESSFULL");
                clear();
                dgvpurchase.RefreshEdit();
                con.Close();


            }
            catch (Exception ret)
            {
                MessageBox.Show(ret.Message);
            }
        }

        private void cbxname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvpurchase_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvpurchase.Refresh();
            btnupdate.Enabled = true;
            try
            {
                DataGridViewRow dr = dgvpurchase.SelectedRows[0];
                txtid.Text = dr.Cells[0].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvdetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btndelete.Enabled = true;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
            DialogResult res= MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THE ROW?","", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res==DialogResult.Yes)
            {
               SqlConnection con = new SqlConnection(cs.dbcon);
            con.Open();
                SqlCommand cmd = new SqlCommand("delete from PURCHTB where PRODUCT_Id ='" + txtid + "'",con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("DELETED");
                con.Close();

            }
            else
            {
                return;
            }
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
           
            
        }
    }
}
