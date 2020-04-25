using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    public partial class Category : Syncfusion.Windows.Forms.MetroForm
    {
        
        
       
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        ConnectionStirng cc = new ConnectionStirng();
        public Category()
        {
            InitializeComponent();
            
        }
     
        private void auto()
        {
            Random rnd = new Random();
            int id;
            id = rnd.Next(100, 999);
            txtCatid.Text = id.ToString();
        }
        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pURCHASDataSet1.CATEGORY' table. You can move, or remove it, as needed.
            auto();
                   
        }

        private void txtCatid_TextChanged(object sender, EventArgs e)
        {         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtCatid.Text = id.ToString();
            auto();
            txtCatnam.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtCatid.Text == "")
            {
                MessageBox.Show("Enter category id");
                txtCatid.Focus();
            }
            if (txtCatnam.Text == "")
            {
                MessageBox.Show("Enter category name please");
                txtCatnam.Focus();
            }
            else
            {
                try
                {
                   SqlConnection con;

                    con = new SqlConnection(cs.dbcon);
                    con.Open();

                    SqlCommand cmd;
                    SqlDataReader rdr;

                    string ct = "select CATEGORY_Id from CATEGORY where CATEGORY_Id='" + txtCatid.Text + "'";

                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        MessageBox.Show("Category ID OR name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCatid.Text = "";
                        txtCatid.Focus();


                        if ((rdr != null))
                        {
                            rdr.Close();
                        }
                        rdr.Close();
                        return;
                    }
                    con.Close();

                    con = new SqlConnection(cs.dbcon);
                    con.Open();

                    cmd = new SqlCommand("INSERT into CATEGORY(CATEGORY_Id, CATEGORY_NAME) VALUES(@cid, @cnam)", con);
                    cmd.Parameters.AddWithValue("@cid", txtCatid.Text);
                    cmd.Parameters.AddWithValue("@cnam", txtCatnam.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("DATA SUCCESFULLY ADDED");

                    con.Close();
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * FROM CATEGORY ", con);
                    DataTable DR;
                    DR = new DataTable();
                    sda.Fill(DR);
                    dataGridViewcat.DataSource = DR;
                    auto();
                    txtCatnam.Clear();
                    btnInser.Enabled = true;
                    con.Close();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                }
            }
        }
      
        private void cATEGORYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATEGORYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pURCHASDataSet1);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}

