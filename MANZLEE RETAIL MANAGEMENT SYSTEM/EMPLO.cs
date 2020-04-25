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
using System.Text.RegularExpressions;

namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    public partial class EMPLO : Syncfusion.Windows.Forms.MetroForm
    {

        CONNECTIONSTRING cs = new CONNECTIONSTRING();

        public EMPLO()
        {
            InitializeComponent();
            timer1.Enabled = true;


        }

        private void EMPLO_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id;
            id = rnd.Next(1000, 9999);
            txtEmpno.Text = Convert.ToString("E" + id);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }
         private bool ValidateInput(string input, string expression, string message)
         {
            // store whether the input is valid
            bool valid = Regex.Match(input, expression).Success;
            // if the input doesn't match the regular expression 
            if ( !valid )
         {
         // signal the user that input was invalid
         MessageBox.Show( message, "Invalid Input",
         MessageBoxButtons.OK, MessageBoxIcon.Error );
         } // end if

         return valid; // return whether the input is valid
         } // end method ValidateInput
        
            Regex idnat = new Regex("/^([0-9]{2})*-([0-9]{6})([A-Z])([0-9]){2}$/");



        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(txtidnat.Text, "^([0-9]{2})*-([0-9]{6})([A-Z])([0-9]){2}$", "Invalid last name"))
                txtidnat.Select();

            if (cbxGEN.Text == "--SELECT ITEM--")
            {
                MessageBox.Show("PLEASE CHECK GENDER");
            }
            if (txtAddre.Text == "")
            {
                MessageBox.Show("ENTER ALL REQUIRED FIELDS PLEASE");
                txtAddre.Focus();
            }
            if (txtDedu.Text == "")
            {
                MessageBox.Show("ENTER ALL REQUIRED FIELDS PLEASE");
                txtDedu.Focus();
            }
            if (txtDesign.Text == "--SELECT ITEM--")
            {
                MessageBox.Show("ENTER ALL REQUIRED FIELDS PLEASE");
                txtDesign.Focus();
            }
            if (txtEmpno.Text == "")
            {
                MessageBox.Show("ENTER ALL REQUIRED FIELDS PLEASE");

            }
            if (txtFname.Text == "")
            {
                MessageBox.Show("ENTER ALL REQUIRED FIELDS PLEASE");
                txtFname.Focus();
            }
            if (txtNetsal.Text == "")
            {
                MessageBox.Show("ENTER ALL REQUIRED FIELDS [PLEASE");
                txtNetsal.Focus();
            }
            if (cbxDay.Text == "")
            {
                MessageBox.Show("ENTER ALL REQUIRED FIELDS [PLEASE");
                cbxDay.Focus();
            }


            if (cbxMont.Text == "")
            {
                MessageBox.Show("ENTER ALL REQUIRED FIELDS [PLEASE");
                cbxMont.Focus();
            }
            if (cbxYr.Text == "")
            {
                MessageBox.Show("ENTER ALL REQUIRED FIELDS [PLEASE");
                cbxYr.Focus();
            }
            if (cbxYr.Text == "")
            {
                MessageBox.Show("ENTER ALL REQUIRED FIELDS [PLEASE");
                cbxYr.Focus();
            }

            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(cs.dbcon);
                    con.Open();

                    string ct = "select employee_id from emloyees where employee_id='" + txtEmpno.Text + "'";
                    SqlCommand cmd;
                    SqlDataReader rdr;
                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        MessageBox.Show("EMPLOYEE ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtFname.Text = "";
                        txtFname.Focus();


                        if ((rdr != null))
                        {
                            rdr.Close();
                        }

                        return;

                    }
                    con = new SqlConnection(cs.dbcon);
                    con.Open();

                    cmd = new SqlCommand("INSERT INTO [dbo].[emloyees] ([employee_Id], [emplo_name], [emplo_type], [emplo_dob], [emplo_address], [emplo_netsalary_$], [emplo_natid], [gender], [email]) VALUES(@id,@enam, @etype, @edob, @eaddr, @enets, @ntid,@gen,@mail)", con);
                    cmd.Parameters.AddWithValue("@id", txtEmpno.Text);
                    cmd.Parameters.AddWithValue("@enam", txtFname.Text);
                    cmd.Parameters.AddWithValue("@etype", txtDesign.Text);
                    cmd.Parameters.AddWithValue("@edob", cbxDay.Text + '-' + cbxMont.Text + '-' + cbxYr.Text);
                    cmd.Parameters.AddWithValue("@eaddr", txtAddre.Text);
                    cmd.Parameters.AddWithValue("@enets", txtNetsal.Text);
                    cmd.Parameters.AddWithValue("@ntid", txtidnat.Text);
                    cmd.Parameters.AddWithValue("@gen", cbxGEN.Text);
                    cmd.Parameters.AddWithValue("@mail", txtemail.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("EMPLOYEE ADDED");

                    con.Close();
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * FROM emloyees", con);
                    DataTable DR;
                    DR = new DataTable();
                    sda.Fill(DR);
                    emloyeesDataGridView.DataSource = DR;
                    con.Dispose();
                    con.Close();
                    rdr.Close();

                    clear();
                    //GetData();
                    Random rnd = new Random();
                    int id;
                    id = rnd.Next(1000, 9999);
                    txtEmpno.Text = Convert.ToString("E" + id);

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void emloyeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emloyeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pURCHASDataSet1);

        }



        private void txtEmpno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id;
            id = rnd.Next(1000, 9999);
            txtEmpno.Text = Convert.ToString("E" + id);
            btnsave.Enabled = true;
            
            txtDedu.Clear();
            txtAddre.Clear();
            
            cbxDay.Text = "";
            cbxMont.Text = "";
            cbxYr.Text = "";
            txtFname.Clear();
            txtNetsal.Clear();
            txtSal.Clear();
            txtDedu.Clear();
            txtemail.Clear();
        }
        private void clear()
        {
            btnsave.Enabled = true;
            
            txtDedu.Clear();
            txtAddre.Clear();
            txtidnat.Clear();
            cbxDay.Text = "";
            cbxMont.Text = "";
            cbxYr.Text = "";
            txtFname.Clear();
            txtNetsal.Clear();
            txtSal.Clear();
            txtDedu.Clear();
            txtemail.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int     P, R , S;
          int.TryParse(txtSal.Text, out  P);
           int.TryParse(txtDedu.Text, out R);
               // P = Convert.ToDecimal(txtSal.Text);
               // R = Convert.ToDecimal(txtDedu.Text);

                S = P - P * (R / 100);
                txtNetsal.Text = S.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtFname_Validated(object sender, EventArgs e)
        {

        }

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(txtemail.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtidnat.Select(0, txtemail.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(txtidnat, errorMsg);
            }
        }

        private void txtemail_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(txtidnat, "");
        }
        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the e-mail address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "e-mail address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }
            errorMessage = "e-mail address must be valid e-mail address format.\n" +
     "For example 'someone@example.com' ";
            return false;
        }

        private void txtSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtDedu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtidnat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
