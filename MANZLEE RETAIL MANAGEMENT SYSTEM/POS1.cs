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
using System.IO;
using System.Drawing.Printing;
using System.Collections;

namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{

    public partial class POS1 : Syncfusion.Windows.Forms.MetroForm
    {
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        DataTable dt = new DataTable();

        #region Member Variables
        const string strConnectionString = "data source=localhost;Integrated Security=SSPI;Initial Catalog=Northwind;";
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        #endregion
        // SqlDataReader rdr;
        public POS1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            
         

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

        private void cler()
        {
           
            txtItemno.Clear();
            txtInvoice.Clear();
            txtQnty.Text = "1";
            
        }
        private void clear()
        {
            
            txtItemno.Clear();
            txtInvoice.Clear();
            
            
            
            txtChange.Clear();
           
           
            
            txtMoneypaid.Clear();
            txtChange.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {try
            {

                btnConf.Enabled = false;
                txtTotprice.Text = txtTotal.Text;

                try
                {

                    {
                        SqlConnection conn = new SqlConnection(cs.dbcon);
                        conn.Open();
                        // SqlCommand cmd = new SqlCommand("select ITEM_Id, ITEM_NAME, CATEGORY,  PRICE_VAT from STOCK where ITEM_Id = '" + txtItemno.Text + "'", conn);
                        //rdr = cmd.ExecuteReader();

                        SqlDataReader dr;

                        SqlCommand sad = new SqlCommand("select ITEM_NAME, PRICE_VAT, QUANTITY,WEIGHT,CATEGORY from STOCK where ITEM_Id LIKE '" + txtItemno.Text + "'", conn);
                        dr = sad.ExecuteReader();
                        while (dr.Read())
                        {
                            txtNma.Text = (string)dr["ITEM_NAME"].ToString();
                            txtItempri.Text = (string)dr["PRICE_VAT"].ToString();
                            qntyAvailable.Text = dr["QUANTITY"].ToString();
                            txtweigth.Text = dr["WEIGHT"].ToString();
                            txtcategory.Text = (string)dr["CATEGORY"].ToString();
                        }

                        conn.Close();

                        /*conn.Open();
                         SqlDataAdapter DR = new SqlDataAdapter("select ITEM_NAME, PRICE_VAT, QUANTITY,WEIGHT from STOCK where ITEM_Id = '" + txtItemno.Text + "'", conn);
                         DataTable Dt = new DataTable();

                         DR.Fill(Dt);
                         dataGridView1.DataSource = Dt;
                         conn.Close();*/

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                /* btnConf.Enabled = false;
                txtTotprice.Text = txtTotal.Text;
                auto();


                    {
                        SqlConnection conn = new SqlConnection(cs.dbcon);
                        conn.Open();
                        // SqlCommand cmd = new SqlCommand("select ITEM_Id, ITEM_NAME, CATEGORY,  PRICE_VAT from STOCK where ITEM_Id = '" + txtItemno.Text + "'", conn);
                        //rdr = cmd.ExecuteReader();

                        SqlDataReader dr;

                        SqlCommand sad = new SqlCommand("select ITEM_NAME, PRICE_VAT, QUANTITY,WEIGHT from STOCK where ITEM_Id = '" + txtItemno.Text + "'", conn);
                        dr = sad.ExecuteReader();
                        while (dr.Read())
                        {
                            txtNma.Text = (string)dr["ITEM_NAME"].ToString();
                            txtItempri.Text = (string)dr["PRICE_VAT"].ToString();
                            qntyAvailable.Text = dr["QUANTITY"].ToString();
                            txtweigth.Text = dr["WEIGHT"].ToString();
                        }

                        conn.Close();

                       conn.Open();
                         SqlDataAdapter DR = new SqlDataAdapter("select ITEM_NAME, PRICE_VAT, QUANTITY,WEIGHT from STOCK where ITEM_Id = '" + txtItemno.Text + "'", conn);
                         DataTable Dt = new DataTable();

                         DR.Fill(Dt);
                         dataGridView1.DataSource = Dt;
                         conn.Close();

                    }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void button3_Click(object sender, EventArgs e)
        {
            btnConf.Enabled = false;
            txtTotprice.Text =txtTotal.Text;
           
            try
            {

                {
                    SqlConnection conn = new SqlConnection(cs.dbcon);
                    conn.Open();
                    // SqlCommand cmd = new SqlCommand("select ITEM_Id, ITEM_NAME, CATEGORY,  PRICE_VAT from STOCK where ITEM_Id = '" + txtItemno.Text + "'", conn);
                    //rdr = cmd.ExecuteReader();

                    SqlDataReader dr;

                    SqlCommand sad = new SqlCommand("select ITEM_NAME, PRICE_VAT, QUANTITY,WEIGHT,CATEGORY from STOCK where ITEM_Id = '" + txtItemno.Text + "'", conn);
                    dr = sad.ExecuteReader();
                    while (dr.Read())
                    {
                        txtNma.Text = (string)dr["ITEM_NAME"].ToString();
                        txtItempri.Text = (string)dr["PRICE_VAT"].ToString();
                        qntyAvailable.Text = dr["QUANTITY"].ToString();
                        txtweigth.Text = dr["WEIGHT"].ToString();
                        txtcategory.Text =(string)dr["CATEGORY"].ToString();
                    }

                    conn.Close();
                  
                    /*conn.Open();
                     SqlDataAdapter DR = new SqlDataAdapter("select ITEM_NAME, PRICE_VAT, QUANTITY,WEIGHT from STOCK where ITEM_Id = '" + txtItemno.Text + "'", conn);
                     DataTable Dt = new DataTable();

                     DR.Fill(Dt);
                     dataGridView1.DataSource = Dt;
                     conn.Close();*/
                 
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

            DateTime mdat;
            mdat = DateTime.Now;
            datesave.Text = mdat.ToString();
            btnConf.Enabled = false;
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

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

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
            
            SqlConnection conn;
            SqlCommand cmd;

            try
            {
                conn = new SqlConnection(cs.dbcon);
                conn.Open();
                int rowsInserted = 0;
                
                for (int i = 0; i <= dataGridView1.Rows.Count-1; i++) {

                    cmd = new SqlCommand("insert into SALES(invoiceno, itemno, item_name, item_price, total_amnt ,quantity,DATE, weight, category) VALUES(@invo, @itnoo,@itnam, @itpri, @totam, @qua,@daat,@wegt, @cat)", conn);
               
                    cmd.Parameters.AddWithValue("@itnoo", dataGridView1.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@itnam", dataGridView1.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@itpri", dataGridView1.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@totam", dataGridView1.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@qua", dataGridView1.Rows[i].Cells[4].Value);
                    cmd.Parameters.AddWithValue("@wegt", dataGridView1.Rows[i].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@cat", dataGridView1.Rows[i].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@daat", dataGridView1.Rows[i].Cells[7].Value);
                    cmd.Parameters.AddWithValue("@invo", dataGridView1.Rows[i].Cells[8].Value);
                    if ((cmd.ExecuteNonQuery() > 0) && (dataGridView1.Rows[i] != null))
                    {

                        rowsInserted++;

                     // cmd.Parameters.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please add items to list", rowsInserted.ToString(), MessageBoxButtons.OK);
                    }
                }

                MessageBox.Show("ITEM(S) SOLD ");
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {

                    cmd = new SqlCommand("update STOCK set QUANTITY = QUANTITY -'" + dataGridView1.Rows[i].Cells[4].Value + "' where  ITEM_Id= '" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'");
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                }
                while (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows[0].Index);

                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: '" + error.Message + "'");
                 
            }
           
                try
                {
             
                

                SqlConnection con = new SqlConnection(cs.dbcon);
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select * FROM SALES ", con);

                DataTable Dt = new DataTable();

                sda.Fill(Dt);
                dgvPos.DataSource = Dt;
                con.Close();
                con.Dispose();
                //sda.Fill(DR);
                /*listView1.Items.Add(txtInvoice.Text);
                listView1.Items.Add(txtItemno.Text);
                listView1.Items.Add(txtNma.Text);
                listView1.Items.Add(txtQnty.Text);
                listView1.Items.Add(txtTotprice.Text);
                listView1.Items.Add(txtItempri.Text);
                listView1.Items.Add(dtpTime.Text);

                ResetText();
                /*for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {
                    conn = new SqlConnection(cs.dbcon);

                    string cd = "insert Into SALES(invoiceno,itemno,item_name,quantity,price,total_amnt) VALUES (@d1,@d2,@d3,@d4,@d5,@d6)";
                    cmd = new SqlCommand(cd);
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("d1", listView1.Items[i].SubItems[1].Text);
                    cmd.Parameters.AddWithValue("d2", listView1.Items[i].SubItems[2].Text);
                    cmd.Parameters.AddWithValue("d3", listView1.Items[i].SubItems[3].Text);
                    cmd.Parameters.AddWithValue("d4", listView1.Items[i].SubItems[4].Text);
                    cmd.Parameters.AddWithValue("d5", listView1.Items[i].SubItems[6].Text);
                    cmd.Parameters.AddWithValue("d6", listView1.Items[i].SubItems[7].Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                } for (int i = 0; i <= listView1.Items.Count - 1; i++)string cb1 = "update STOCK set QUANTITY = QUANTITY - " + listView1.Items[i].SubItems[4].Text + " where  Item_Id= '" + listView1.Items[i].SubItems[1].Text + "'";
                {*/



            }
            catch (Exception der)
            {
                MessageBox.Show("Data operation error'"+ der.Message + "'","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private object GetNewValues()
        {
            throw new NotImplementedException();
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
            decimal av, now;
           decimal.TryParse(qntyAvailable.Text, out av);
            decimal.TryParse(txtQnty.Text, out now);

            if (txtItempri.Text != "" && txtQnty.Text != "")
            {
                if (av > now)
                {
                    try
                    {//decimal pri, qty, tot, hol;
                        decimal tot, privat, qunty;
                        decimal.TryParse(txtItempri.Text, out privat);
                        decimal.TryParse(txtTotal.Text, out tot);
                        qunty = Convert.ToInt32(txtQnty.Text);
                        tot = privat * qunty;
                        txtTotal.Text = tot.ToString();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                }
                else { MessageBox.Show("STOCK NO LONGER AVAILABLE", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto();


            btnremove.Enabled = true;
            if ((txtItemno.Text == "") && (txtItempri.Text == "") && (txtNma.Text == "") && (txtQnty.Text == "") && (txtweigth.Text == ""))
            {
                MessageBox.Show("Please enter all product details!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    adddata(txtItemno.Text.ToString(), txtNma.Text, txtItempri.Text, txtTotal.Text, txtQnty.Text, txtweigth.Text, txtcategory.Text, datesave.Text, txtInvoice.Text);
                    cler();


                }
                catch (Exception ter)
                {
                    MessageBox.Show("Adding items Error: "+ter.Message);
                }
            }
        }
        private void adddata(string ITEM_NUMBER, string ITEM_NAME, string ITEM_PRICE,string  qnty, string subtot, string weight, string cat, string dat, string invo)
           
        {
            
            
            String[] row = {ITEM_NUMBER, ITEM_NAME, ITEM_PRICE, qnty, subtot, weight, cat, dat, invo};

            dataGridView1.Rows.Add(row);
           
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            
            try
            {
        decimal cost, paid, res;
                // cost = Convert.ToDecimal(txtTotal.Text);
                // paid = Convert.ToDecimal(txtMoneypaid.Text);
                decimal.TryParse(txtTotprice.Text, out cost);
                decimal.TryParse(txtMoneypaid.Text, out paid);
            
                if (paid < cost)
                {
                    MessageBox.Show("INSUFFICIENT AMOUNT", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    res = paid - cost;
                    txtChange.Text = res.ToString();
                    btnConf.Enabled = true;
                    btnPay.Enabled = false;
                }
                   
          txtTotprice.Text =  cost.ToString();
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void txtTotprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtMoneypaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMoneypaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                /* foreach(DataGridView item in dataGridView1.SelectedRows)
             {
                 dataGridView1.Rows.RemoveAt(item.SelectedRows[0].Index);
             }
             */
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txtnames.Text=="")
            {
                MessageBox.Show("INPUT NAME PLEASE");
                txtnames.Focus();
            }
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                SqlDataAdapter cmd = new SqlDataAdapter("select ITEM_id, ITEM_NAME, TAX, PRICE_VAT, WEIGHT, QUANTITY, CATEGORY  from STOCK where ITEM_NAME='" + txtnames.Text + "'", con);
                DataTable rdr;
                rdr = new DataTable();

                cmd.Fill(rdr);
               dgvPos.DataSource = rdr;
                txtnames.Clear();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            

                
        }

        private void dgvPos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           //Open the print dialog
            PrintDialog printDialog = new PrintDialog();            
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;           
            
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Test Page Print";                
                printDocument1.Print();
            }

            //Open the print preview dialog
            //PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            //objPPdialog.Document = printDocument1;
            //objPPdialog.ShowDialog();

            /*TextWriter sw = new StreamWriter(@"D:\\rms1sales.txt");

            int rowcount = dgvPos.Rows.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {
                for (int j = 0; j < dgvPos.Columns.Count; j++)
                {
                    sw.Write("\t"+ dgvPos.Rows[i].Cells[j].Value.ToString()+"\t\t"+"|");
                    
                }
                sw.WriteLine("");
                sw.WriteLine("_____________________________________________________________________________________");
            }
            sw.Close();


            MessageBox.Show("Text file was created.");
            */
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows[0].Index);

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal ssum = 0;
                for (int i = 0; i <= dataGridView1.Rows.Count-1; i++)
                {

                    ssum = ssum + Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    txtTotprice.Text = ssum.ToString();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void POSRBTN_Click(object sender, EventArgs e)
        {
           
        }

        private void txtcategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnames_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs.dbcon);
                SqlDataAdapter cmd = new SqlDataAdapter("select ITEM_id, ITEM_NAME, TAX, PRICE_VAT, WEIGHT, QUANTITY, CATEGORY  from STOCK where ITEM_NAME LIKE '" + txtnames.Text + "%'", con);
                DataTable rdr;
                rdr = new DataTable();

                cmd.Fill(rdr);
                dgvPos.DataSource = rdr;
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void txtQnty_KeyUp(object sender, KeyEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtQnty.Text, "^[0-9]"))
            {
                errorProvider1.SetError(txtQnty, "Digits only!");    
            }
            else
            {
                    errorProvider1.Clear();
            }

        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView1.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView1.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Customer Summary", new Font(dataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Customer Summary", new Font(dataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(dataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Customer Summary", new Font(new Font(dataGridView1.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            decimal ssum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {

                ssum = ssum + Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                txtTotprice.Text = ssum.ToString();
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            decimal ssum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {

                ssum = ssum + Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                txtTotprice.Text = ssum.ToString();
            }
        }
    }
}
