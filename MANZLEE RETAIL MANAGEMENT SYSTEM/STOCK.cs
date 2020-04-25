using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
using System.ComponentModel;

namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    public partial class STOCK : Syncfusion.Windows.Forms.MetroForm
    {
       
        
   
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        public STOCK()
        {
            InitializeComponent();
           
           
        }
        public void frmInvoice()
        {
            InitializeComponent();
        }
        private void auto()
        {
            

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
        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
           
        }
       

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtItemname.Text=="")
            {
                MessageBox.Show("Please enter item name","", MessageBoxButtons.OK);
                txtItemname.Focus();
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter price", "", MessageBoxButtons.OK);
               txtPrice.Focus();
                return;
            }
            if (txtPvat.Text == "")
            {
                MessageBox.Show("Please enter price", "", MessageBoxButtons.OK);
                txtPvat.Focus();
                return;
            }
            if (txtTax.Text == "")
            {
                MessageBox.Show("Please enter tax", "", MessageBoxButtons.OK);
                txtTax.Focus();
                return;
            }
            if (cbxItemcode.Text == "")
            {
                MessageBox.Show("Please enter item code", "", MessageBoxButtons.OK);
                cbxItemcode.Focus();
                return;
            }
            if (cbxweight.Text == "")
            {
                MessageBox.Show("Please enter item weight", "", MessageBoxButtons.OK);
                cbxweight.Focus();
                return;
            }
            if(nudQnty.Text=="")
            {
                MessageBox.Show("enter quantity please");
                nudQnty.Focus();
            }

            try
            {

                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT into STOCK( ITEM_id, ITEM_NAME, PRICE_NOVAT, TAX, PRICE_VAT, WEIGHT, QUANTITY, CATEGORY) VALUES(@id, @inam, @priv, @dedu, @netpri, @weight, @qnty, @cat)", con);
                cmd.Parameters.AddWithValue("@id",cbxItemcode.Text);
                cmd.Parameters.AddWithValue("@inam", txtItemname.Text);
                cmd.Parameters.AddWithValue("@priv", txtPrice.Text);
                cmd.Parameters.AddWithValue("@dedu", txtTax.ToString());
                cmd.Parameters.AddWithValue("@netpri", txtPvat.Text);
                cmd.Parameters.AddWithValue("@weight", cbxweight.Text);
                cmd.Parameters.AddWithValue("@qnty", nudQnty.Text);
                cmd.Parameters.AddWithValue("@cat", cbxCategory.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("DATA SUCCESSFULLY ADDED");
                con.Close();
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select * FROM STOCK", con);
                DataTable DR = new DataTable();               
                sda.Fill(DR);
                dataGridView1.DataSource = DR;
                con.Close();                
                
                clear();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);

            }
             
         
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
                                           
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            txtTax.Text = "";
            txtItemname.Text="";
            txtPrice.Text="";
            txtPvat.Clear();
            cbxItemcode.Text = "";
            cbxweight.Text = "";
            cbxItemcode.Text = "";
        }
        private void clear()
        {
            btnsave.Enabled = true;
            txtTax.Text = "";
            txtItemname.Text = "";
            txtPrice.Text = "";
            txtPvat.Clear();
            cbxItemcode.Text = "";
            cbxweight.Text = "";
            cbxItemcode.Text = "";
        }
        private void STOCK_Load(object sender, EventArgs e)
        {
            GetData1();
            GetDatac();
           
        }

        private void txtTax_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cbxCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxItemcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nudQnty_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnget_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tx, pr2, pr3, pr1, tot, mak;
                  

             
            decimal.TryParse(txtPrice.Text, out pr1);
                decimal.TryParse(txtmark.Text, out mak);
                 decimal.TryParse(txtTax.Text, out tx);
                // tx = Convert.ToDecimal(txtTax.Text);
                // pr1 = Convert.ToDecimal(txtPrice.Text);
                pr2 = (pr1 / (100 - mak))*100;
                tx = tx / 100;
                pr3 = tx * pr2;
                tot = pr2 + pr3;
               
                txtPvat.Text = tot.ToString();
                
                txtmark.ReadOnly = true;
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GetDatac()
        {
            try
            {
               SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                string sql = "SELECT rtrim(CATEGORY_Id),rtrim(CATEGORY_NAME) from CATEGORY order by CATEGORY_NAME";
               SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dgvCategory.DataSource=dt;
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetData1()
        {
            try
            {
              SqlConnection  con = new SqlConnection(cs.dbcon);
                con.Open();
                string sql = "SELECT rtrim(PRODUCT_Id),rtrim(PRODUCT_NAME), rtrim(PRICE_PER_UNIT) from PURCHTB order by PRODUCT_NAME";
               SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
               DataTable dt=new DataTable();
                dgvitem.Rows.Clear();
                cmd.Fill(dt);
                dgvitem.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvCategory.SelectedRows[0];
                cbxCategory.Text = dr.Cells[1].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvitem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                DataGridViewRow dr = dgvitem.SelectedRows[0];
                cbxItemcode.Text = dr.Cells[0].Value.ToString();
                txtItemname.Text = dr.Cells[1].Value.ToString();
                txtPrice.Text = dr.Cells[2].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void nudQnty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void cbxItemcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void cbxItemcode_TextChanged(object sender, EventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(cbxItemcode.Text, "^[0-9]"))
            {
                cbxItemcode.Text = "";
            }
        }

        private void btnmark_Click(object sender, EventArgs e)
        {
            txtmark.ReadOnly = false; 
        }

        private void txtTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
        }

        private void txtPvat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') < -2))
            {
                e.Handled = true;
            }
        }
    }
}
