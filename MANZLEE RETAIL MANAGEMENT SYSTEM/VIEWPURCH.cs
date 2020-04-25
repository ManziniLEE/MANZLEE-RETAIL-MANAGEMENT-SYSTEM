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
    public partial class VIEWPURCH : Syncfusion.Windows.Forms.MetroForm
    {
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        public VIEWPURCH()
        {
            InitializeComponent();
        }

        private void pURCHTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
            this.pURCHTBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pURCHASDataSet1);

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            

        }

        private void VIEWPURCH_Load(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select PRODUCT_Id, PRODUCT_NAME, PRICE_PER_UNIT,QUANTITY,WEIGHT_KG_LTRES, SUPPLIER,SUPPLIER_CONTACT,DATE,CATEGORY  from PURCHTB where PRODUCT_NAME='" + txtSearch.Text + "'", con);
                DataTable rdr;
                rdr = new DataTable();

                cmd.Fill(rdr);
                pURCHTBDataGridView.DataSource = rdr;
            }
            catch(Exception tr)
            {
                MessageBox.Show(tr.Message);
            }
                                 
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnALL_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select PRODUCT_Id, PRODUCT_NAME, PRICE_PER_UNIT,QUANTITY,WEIGHT_KG_LTRES, SUPPLIER,SUPPLIER_CONTACT,DATE,CATEGORY from PURCHTB ", con);
                DataTable rdr;
                rdr = new DataTable();

                cmd.Fill(rdr);
                pURCHTBDataGridView.DataSource = rdr;
            }
            catch (Exception tr)
            {
                MessageBox.Show(tr.Message);
            }

        }

        private void pURCHTBDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Update secondForm = new Update();
            secondForm.Show();
        }
    }
}
