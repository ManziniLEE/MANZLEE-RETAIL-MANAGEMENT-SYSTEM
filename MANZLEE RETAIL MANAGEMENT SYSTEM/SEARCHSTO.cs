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
using System.IO;
namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    public partial class SEARCHSTO : Syncfusion.Windows.Forms.MetroForm
    {
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        public SEARCHSTO()
        {
            InitializeComponent();
        }

        private void sTOCKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTOCKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pURCHASDataSet1);

        }

        private void SEARCHSTO_Load(object sender, EventArgs e)
        {
            /*// TODO: This line of code loads data into the 'pURCHASDataSet1.STOCK' table. You can move, or remove it, as needed.
            this.sTOCKTableAdapter.Fill(this.pURCHASDataSet1.STOCK);
            */
        }

        private void iTEM_IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select ITEM_id, ITEM_NAME, PRICE_NOVAT, TAX, PRICE_VAT, WEIGHT, QUANTITY, CATEGORY  from STOCK where ITEM_NAME='" + txtSearch.Text + "'", con);
                DataTable rdr;
                rdr = new DataTable();

                cmd.Fill(rdr);
                sTOCKDataGridView.DataSource = rdr;
            }
            catch (Exception tr)
            {
                MessageBox.Show(tr.Message);
            }

        }

        private void btnALL_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select ITEM_id, ITEM_NAME, PRICE_NOVAT, TAX, PRICE_VAT, WEIGHT, QUANTITY, CATEGORY from STOCK ", con);
                DataTable rdr;
                rdr = new DataTable();

                cmd.Fill(rdr);
                sTOCKDataGridView.DataSource = rdr;
            }
            catch (Exception tr)
            {
                MessageBox.Show(tr.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update secondForm = new Update();
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("update STOCK SET ITEM_NAME = '" + txtitnam.Text + "',PRICE_NOVAT ='" + txtpri.Text + "',TAX ='"+txttax.Text+"',PRICE_VAT='"+txtvat.Text+"',QUANTITY ='" + txtqua.Text + "',WEIGHT = '" + txtweight.Text + "',CATEGORY = '" + txtcat.Text + "' where ITEM_Id='" + txtid.Text + "'", con);
                cmd.ExecuteNonQuery();
               
                MessageBox.Show("DATA UPDATE SUCCESSFULL");
                clear();
                con.Close();

            }
            catch (Exception ret)
            {
                MessageBox.Show(ret.Message);
            }

        }
        private void clear()
        {
            txtpri.Clear();
            txtcat.Clear();
            txtid.Clear();
            txtitnam.Clear();
            txtqua.Clear();
            txttax.Clear();
            txtweight.Clear();
            
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void sTOCKDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = sTOCKDataGridView.SelectedRows[0];
                txtid.Text = dr.Cells[0].Value.ToString();
               txtitnam.Text= dr.Cells[1].Value.ToString();
                txtpri.Text = dr.Cells[2].Value.ToString();
                txttax.Text = dr.Cells[3].Value.ToString();
                txtvat.Text= dr.Cells[4].Value.ToString();
                txtweight.Text= dr.Cells[5].Value.ToString();                
                txtqua.Text= dr.Cells[6].Value.ToString();
                txtcat.Text= dr.Cells[7].Value.ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from  STOCK  where ITEM_Id='" + txtid.Text + "'", con);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("DATA DELETION SUCCESSFULL");
                clear();
                con.Close();

            }
            catch (Exception ret)
            {
                MessageBox.Show(ret.Message);
            }
        }

        private void btntxt_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter sw = new StreamWriter (@"D:\\rms1stock.txt");

            int rowcount = sTOCKDataGridView.Rows.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {
                for (int j = 0; j < sTOCKDataGridView.Columns.Count; j++)
                {

                    sw.Write("\t" + sTOCKDataGridView.Rows[i].Cells[j].Value.ToString() + "\t"+"|");
                }
                sw.WriteLine("");
                sw.WriteLine("____________________________________________________________________________");
            }
            sw.Close();


            MessageBox.Show("Text file was created.");

            }catch
            (Exception eer)
            {
                MessageBox.Show(eer.Message);
            }

           

        }
    }
}
