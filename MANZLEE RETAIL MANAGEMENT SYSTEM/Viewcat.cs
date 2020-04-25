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
    
    public partial class Viewcat : Syncfusion.Windows.Forms.MetroForm
    {
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        public Viewcat()
        {
            InitializeComponent();
        }

        private void cATEGORYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATEGORYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pURCHASDataSet1);

        }

        private void Viewcat_Load(object sender, EventArgs e)
        {
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * FROM CATEGORY ", con);
                DataTable DR;
                DR = new DataTable();
                sda.Fill(DR);
                cATEGORYDataGridView.DataSource = DR;
                con.Close();

                // TODO: This line of code loads data into the 'pURCHASDataSet1.CATEGORY' table. You can move, or remove it, as needed.
                // this.cATEGORYTableAdapter.Fill(this.pURCHASDataSet1.CATEGORY);
            }
            catch(Exception rt)
            {
                MessageBox.Show(rt.Message);
            }
        }

        private void cATEGORYDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cATEGORYDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btndelete.Enabled = true;
            btnupdate.Enabled = true;
            try
            {
                DataGridViewRow dr = cATEGORYDataGridView.SelectedRows[0];
                txtcid.Text = dr.Cells[0].Value.ToString();
                txtnam.Text = dr.Cells[1].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtcid.Text != "" && txtnam.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cs.dbcon);
                    con.Open();
                   
                    if (cATEGORYDataGridView.SelectedRows.Count > 0)
                    {
                        int selectedIndex = cATEGORYDataGridView.SelectedRows[0].Index;

                        int rowID = int.Parse(cATEGORYDataGridView[0, selectedIndex].Value.ToString());
                        string sql = "DELETE FROM Table1 WHERE RowID = @RowID";

                        SqlCommand deleteRecord = new SqlCommand();
                        deleteRecord.Connection = con;
                        deleteRecord.CommandType = CommandType.Text;
                        deleteRecord.CommandText = sql;

                        SqlParameter RowParameter = new SqlParameter();
                        RowParameter.ParameterName = "@RowID";
                        RowParameter.SqlDbType = SqlDbType.Int;
                        RowParameter.IsNullable = false;
                        RowParameter.Value = rowID;

                        deleteRecord.Parameters.Add(RowParameter);

                        deleteRecord.Connection.Open();

                        deleteRecord.ExecuteNonQuery();

                        deleteRecord.Connection.Close();

                        cATEGORYDataGridView.Refresh();

                        
                    }
                    con.Close();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else MessageBox.Show("please fill the textboxes");                    
        }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("update CATEGORY SET CATEGORY_NAME='"+txtnam.Text+"'  where CATEGORY_Id='" + txtcid.Text + "'", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("DATA UPDATE SUCCESSFULL");
             txtcid.Clear();
                txtnam.Clear();
            con.Close();
               
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
           
        }
    }
}
