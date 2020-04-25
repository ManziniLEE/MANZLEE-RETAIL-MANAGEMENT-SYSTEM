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
using System.Data.OleDb;
using Syncfusion.WinForms.Controls;

namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        ConnectionStirng cc = new ConnectionStirng();
        CONNECTIONSTRING cs = new CONNECTIONSTRING();

        public Form1()
        {
            InitializeComponent();
            populatethemes();

        }

        private void populatethemes()
        {
            CreateThemesMenuItem(Menutelerik, "Default", "Default");
            CreateThemesMenuItem(Menutelerik, "Aqua", "Aqua");
            CreateThemesMenuItem(Menutelerik, "Breeze", "Breeze");
            CreateThemesMenuItem(Menutelerik, "TelerikMetroTouch", "TelerikMetroTouch");
            CreateThemesMenuItem(Menutelerik, "TelerikMetroBlue", "TelerikMetroBlue");
            CreateThemesMenuItem(Menutelerik, "Office2013Dark", "Office2013Dark");
            CreateThemesMenuItem(Menutelerik, "Windows8", "Windows8");
            CreateThemesMenuItem(Menutelerik, "VisualStudio2012Dark", "VisualStudio2012Dark");
            CreateThemesMenuItem(Menutelerik, "Office2010Black", "Office2010Black");
        }

        public void CreateThemesMenuItem(ToolStripMenuItem parents, string newMenuitemnam, string menuname)
        {
            
            ToolStripMenuItem newMenuitem = new ToolStripMenuItem(menuname,null, new EventHandler(Menutelerik_Click));
            newMenuitem.Click += new EventHandler(Menutelerik_Click);
            parents.DropDownItems.Add(newMenuitem);

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void sALESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
         POS1 secondForm = new POS1();
         secondForm.Show();
        }

        private void pURCHASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            STOCK secondForm = new STOCK();
            secondForm.Show();
        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORT secondForm = new REPORT();
            secondForm.Show();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEWEMP secondForm = new VIEWEMP();
            secondForm.Show();
        }

        private void eNTRYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          EMPLO secondForm = new EMPLO();
            secondForm.Show();
            
        }

        private void sTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sEACHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEARCHSTO secondForm = new SEARCHSTO();
            secondForm.Show();
        }

        private void eNTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PURCH secondForm = new PURCH();
            secondForm.Show();
           
        }

        private void vIEWToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VIEWPURCH secondForm = new VIEWPURCH();
            secondForm.Show();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About secondForm = new About();
            secondForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passsword secondForm = new Passsword();
            secondForm.Show();
        }

        private void btnChangepsw_Click(object sender, EventArgs e)
        {
            CPwd secondForm = new CPwd();
            secondForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category secordForm = new Category();
            secordForm.Show();
        }

        private void sETTINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // SETT secondForm = new SETT();
           // secondForm.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void vIEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Viewcat secondForm = new Viewcat();
            secondForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            POS1 secondForm = new POS1();
            secondForm.Show();
        }

        private void lnlemplo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EMPLO secondForm = new EMPLO();
            secondForm.Show();
        }

        private void lnlsett_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SETT secondForm = new SETT();
            secondForm.Show();
        }

        private void lnlstock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            STOCK secondForm = new STOCK();
            secondForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
               // OleDbConnection conn = new OleDbConnection(cc.dbconn);
                SqlConnection conn = new SqlConnection(cs.dbcon);
                conn.Open();
                string ct = "select  password from PASSWORD where username ='" + txtUsername.Text+ "'";

                //OleDbCommand cmd = new OleDbCommand(); 
                SqlCommand cmd;
                
                SqlDataReader rdr;

                cmd = new SqlCommand(ct);
                cmd.Connection = conn;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    if (txtPasswd.Text== rdr[0].ToString())
                    {
                        MessageBox.Show("WELCOME");
                        txtPasswd.Clear();
                        pURCHASEToolStripMenuItem.Enabled = true;
                        sTOCKToolStripMenuItem.Enabled = true;
                        cATEGORYToolStripMenuItem.Enabled = true;
                        sALESToolStripMenuItem.Enabled = true;
                        eMPLOYEEToolStripMenuItem.Enabled = true;
                        lnlemplo.Enabled = true;
                        lnlpos.Enabled = true;
                        lnlstock.Enabled = true;
                        txtPasswd.Text = "";
                    }

                    else
                    {
                        MessageBox.Show("WRONG PASSWORD");
                        txtPasswd.Clear();
                        txtPasswd.Focus();

                    }
                }

                conn.Close();
                return;

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pURCHASEToolStripMenuItem.Enabled = false;
            sTOCKToolStripMenuItem.Enabled = false;
            cATEGORYToolStripMenuItem.Enabled = false;
            sALESToolStripMenuItem.Enabled = false;
            eMPLOYEEToolStripMenuItem.Enabled = false;
            lnlemplo.Enabled = false;
            lnlpos.Enabled = true;
            lnlstock.Enabled = false;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            pURCHASEToolStripMenuItem.Enabled = false;
            sTOCKToolStripMenuItem.Enabled = false;
            cATEGORYToolStripMenuItem.Enabled = false;
            sALESToolStripMenuItem.Enabled = false;
            eMPLOYEEToolStripMenuItem.Enabled = false;
            lnlemplo.Enabled = false;
            lnlpos.Enabled = false;
            lnlstock.Enabled = false;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recovery secondform = new recovery();
            secondform.Show();
        }

        private void Menutelerik_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menitem = sender as ToolStripMenuItem;
          
        }
    }
}
