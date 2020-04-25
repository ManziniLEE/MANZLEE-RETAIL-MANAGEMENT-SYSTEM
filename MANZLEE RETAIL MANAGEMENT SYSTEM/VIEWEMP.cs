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
    public partial class VIEWEMP : Syncfusion.Windows.Forms.MetroForm
    {
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        public VIEWEMP()
        {
            InitializeComponent();
        }

        private void emloyeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emloyeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pURCHASDataSet1);

        }

        private void VIEWEMP_Load(object sender, EventArgs e)
        {
           
            try
            {
                
            // TODO: This line of code loads data into the 'pURCHASDataSet1.emloyees' table. You can move, or remove it, as needed.
          //  this.emloyeesTableAdapter.Fill(this.pURCHASDataSet1.emloyees);
            // TODO: This line of code loads data into the 'pURCHASDataSet1.PASSWORD' table. You can move, or remove it, as needed.
           // this.pASSWORDTableAdapter.Fill(this.pURCHASDataSet1.PASSWORD);
            }
            catch(Exception rr)
            {
                MessageBox.Show("ERROR", rr.Message);
            }
        }

        private void emloyeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void emplo_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void emloyeesDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlDataAdapter DR= new SqlDataAdapter("select employee_Id,emplo_name, emplo_type, emplo_dob, emplo_address, emplo_netsalary_$, emplo_natid, gender,email from emloyees where emplo_name='" + txtEmploname.Text+"'", con);               
                DataTable Dt = new DataTable();

                DR.Fill(Dt);
                emloyeesDataGridView.DataSource = Dt;
                con.Close();

            }
            catch(Exception nor)
            {
                MessageBox.Show(nor.Message);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            /* try
             {
                 SqlConnection con = new SqlConnection(cs.dbcon);
                 con.Open();

                 SqlDataAdapter dr = new SqlDataAdapter("select * from emloyees", con);
                 DataTable dt = new DataTable();
                 dr.Fill(dt);
                 emloyeesDataGridView.DataSource = dr;
                 con.Close();

             }
             catch (Exception nor)
             {
                 MessageBox.Show(nor.Message);
             }*/
            try
            {

                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlDataAdapter DR = new SqlDataAdapter("select employee_Id,emplo_name, emplo_type, emplo_dob, emplo_address, emplo_netsalary_$, emplo_natid,gender,email from emloyees ", con);
                DataTable Dt = new DataTable();

                DR.Fill(Dt);
                emloyeesDataGridView.DataSource = Dt;
                con.Close();

            }
            catch (Exception nor)
            {
                MessageBox.Show(nor.Message);
            }


        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM employee  where employee_Id='" + txteid.Text + "'", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("DATA DELETE SUCCESSFULL");

                con.Close();

            }
            catch (Exception ret)
            {
                MessageBox.Show(ret.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("update employee SET employee_name = '" +txtenam.Text + "',emplo_type ='" + txtetype.Text + "',emplo_dob='" + txtdob.Text + "',emplo_address='" + txtaddress.Text + "',emplo_netsalry_$ ='" + txtesala.Text + "'  where employee_Id='" + txteid.Text + "'", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("DATA UPDATE SUCCESSFULL");
               
                con.Close();

            }
            catch (Exception ret)
            {
                MessageBox.Show(ret.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void emloyeesDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = emloyeesDataGridView.SelectedRows[0];
                txteid.Text = dr.Cells[0].Value.ToString();
                txtenam.Text = dr.Cells[1].Value.ToString();
                txtetype.Text = dr.Cells[2].Value.ToString();
                txtdob.Text = dr.Cells[3].Value.ToString();
               txtaddress.Text = dr.Cells[4].Value.ToString();
                txtesala.Text = dr.Cells[5].Value.ToString();
                txtnatid.Text = dr.Cells[6].Value.ToString();
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
    }
}
