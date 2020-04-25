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
using System.Reflection;
using System.IO;

namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    public partial class REPORT : Syncfusion.Windows.Forms.MetroForm
    {
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        public REPORT()
        {
            InitializeComponent();
        }

        private void sTOCKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTOCKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pURCHASDataSet1);

        }

        private void REPORT_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs.dbcon);
            con.Open();
            SqlDataAdapter dat = new SqlDataAdapter("select * from SALES", con);
            DataTable DT = new DataTable();
            DT = new DataTable();

            dat.Fill(DT);
            sALESDataGridView.DataSource = DT;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sALESTableAdapter.FillBy(this.pURCHASDataSet1.SALES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnall_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs.dbcon);
            con.Open();
            SqlDataAdapter dat = new SqlDataAdapter("select * from SALES", con);
            DataTable DT = new DataTable();
            DT = new DataTable();
      
            dat.Fill(DT);
            sALESDataGridView.DataSource = DT;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                decimal  ssum=0;
            for(int i = 0; i < sALESDataGridView.Rows.Count; ++i)
            {
                   
                    ssum +=Convert.ToInt32(sALESDataGridView.Rows[i].Cells[4].Value);
                    lbltotal.Text=ssum.ToString();
               
            }
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
           
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlCommand cmd = new SqlCommand( "select * from SALES", con);
                
                SqlDataReader rdr;
               rdr= cmd.ExecuteReader();
                while(rdr.Read())
                {
                    chart1.Series["SALES"].Points.AddXY((rdr["Category"]).ToString(), (rdr["Quantity"]).ToString());                      
                }
                con.Close();
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnday_Click(object sender, EventArgs e)
        {
            string dat;
           dat = dateTimePicker3.ToString();
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from SALES where DATE='"+dateTimePicker2.Text+"'", con);

                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    sALESDataGridView.DataSource=rdr;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnmonth_Click(object sender, EventArgs e)
        {
            //WHERE([DATE_RECORD_CREATED] BETWEEN '" + startdatetime + "' AND '" + enddatetime + "') ORDER BY[DATE_RECORD_CREATED] ASC";

            try
                {
                    SqlConnection con = new SqlConnection(cs.dbcon);
                    con.Open();
                
                    SqlCommand cmd = new SqlCommand("select * from SALES where DATE='" + dateTimePicker3.Text + "'", con);

                    SqlDataReader rdr;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        sALESDataGridView.DataSource = rdr;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {


            TextWriter sw = new StreamWriter(@"D:\\rms.txt");

            int rowcount = sALESDataGridView.Rows.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {for(int f = 0; f < sALESDataGridView.Columns.Count; f++)
                {
                    sw.WriteLine("\t"+sALESDataGridView.Rows[i].Cells[f].Value.ToString()+"\t"+"|");
                }
                sw.WriteLine("");
                sw.WriteLine("____________________________________________________________________________");

            }
            sw.Close();


            MessageBox.Show("Text file was created.");


        }
    }
}
