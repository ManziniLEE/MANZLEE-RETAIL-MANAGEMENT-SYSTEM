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
using System.Data.OleDb;
using Syncfusion.WinForms.Controls;


namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    public partial class PURCH : Syncfusion.Windows.Forms.MetroForm
    {
        ConnectionStirng cc = new ConnectionStirng();
        CONNECTIONSTRING cs = new CONNECTIONSTRING();
        private Button btnHome;
        private ComboBox cbxWeight;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox txtAmnt;
        private TextBox txtProid;
        private TextBox txtSuppco;
        private TextBox txtSuppnam;
        private Button btnAdd;
        private Button btnClear;
        private TextBox txtTotprice;
        private Label label8;
        private DateTimePicker dtpDate;
        private GroupBox gbxTasks;
        private GroupBox gbxDetails;
        private ComboBox cbxProdnam;
        private Button btnNew;
        private Label lblTimee;
        private Label label10;
        private PURCHASDataSet1 pURCHASDataSet1;
        private BindingSource cATEGORYBindingSource;
        private IContainer components;
        private BindingSource pURCHTBBindingSource;
        private PURCHASDataSet1TableAdapters.PURCHTBTableAdapter pURCHTBTableAdapter;
        private PURCHASDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataGridView pURCHTBDataGridView;
        private Timer timer2;
        private TextBox txtQnty;
        private BindingSource cATEGORYBindingSource1;
        private GroupBox groupBox1;
        private DataGridView dgvCategory;
        private TextBox cbxCategory;
        int id = 100001;
       
        public PURCH()
        {
            InitializeComponent();
            gbxDetails.Enabled = false;
           
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Start();

        }
     

        private void PURCH_Load(object sender, EventArgs e)
        {
            
            id = id + 1;
            txtProid.Text = id.ToString();
            btnNew.Enabled = false;
        }
        private void displayTime()
        {
            lblTimee.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnHome = new System.Windows.Forms.Button();
            this.cbxWeight = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmnt = new System.Windows.Forms.TextBox();
            this.txtProid = new System.Windows.Forms.TextBox();
            this.txtSuppco = new System.Windows.Forms.TextBox();
            this.txtSuppnam = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxProdnam = new System.Windows.Forms.ComboBox();
            this.txtTotprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gbxTasks = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.TextBox();
            this.txtQnty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cATEGORYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHASDataSet1 = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTimee = new System.Windows.Forms.Label();
            this.pURCHTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHTBTableAdapter = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.PURCHTBTableAdapter();
            this.tableAdapterManager = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.TableAdapterManager();
            this.pURCHTBDataGridView = new System.Windows.Forms.DataGridView();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.gbxTasks.SuspendLayout();
            this.gbxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Blue;
            this.btnHome.Location = new System.Drawing.Point(27, 43);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(89, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // cbxWeight
            // 
            this.cbxWeight.FormattingEnabled = true;
            this.cbxWeight.Items.AddRange(new object[] {
            "KG",
            "LTRS",
            "g",
            "ml"});
            this.cbxWeight.Location = new System.Drawing.Point(449, 256);
            this.cbxWeight.Name = "cbxWeight";
            this.cbxWeight.Size = new System.Drawing.Size(121, 23);
            this.cbxWeight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "PURCHASE ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "PRODUCT NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "SUPPLIER ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "SUPPLIER CONTACTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "WEIGHT [PER UNIT](units: kg,pages, litres ,etc.)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "QUANTITY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "BUYING PRICE PER UNIT [COST]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "PRODUCT NUMBER";
            // 
            // txtAmnt
            // 
            this.txtAmnt.Location = new System.Drawing.Point(449, 176);
            this.txtAmnt.Name = "txtAmnt";
            this.txtAmnt.Size = new System.Drawing.Size(141, 21);
            this.txtAmnt.TabIndex = 13;
            this.txtAmnt.TextChanged += new System.EventHandler(this.txtAmnt_TextChanged);
            // 
            // txtProid
            // 
            this.txtProid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtProid.Location = new System.Drawing.Point(449, 127);
            this.txtProid.Multiline = true;
            this.txtProid.Name = "txtProid";
            this.txtProid.Size = new System.Drawing.Size(169, 32);
            this.txtProid.TabIndex = 16;
            this.txtProid.TextChanged += new System.EventHandler(this.txtProid_TextChanged);
            // 
            // txtSuppco
            // 
            this.txtSuppco.Location = new System.Drawing.Point(449, 66);
            this.txtSuppco.Name = "txtSuppco";
            this.txtSuppco.Size = new System.Drawing.Size(169, 21);
            this.txtSuppco.TabIndex = 17;
            // 
            // txtSuppnam
            // 
            this.txtSuppnam.Location = new System.Drawing.Point(449, 32);
            this.txtSuppnam.Name = "txtSuppnam";
            this.txtSuppnam.Size = new System.Drawing.Size(169, 21);
            this.txtSuppnam.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(27, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "SAVE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Blue;
            this.btnClear.Location = new System.Drawing.Point(27, 85);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxProdnam
            // 
            this.cbxProdnam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProdnam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.cbxProdnam.FormattingEnabled = true;
            this.cbxProdnam.Location = new System.Drawing.Point(449, 98);
            this.cbxProdnam.Name = "cbxProdnam";
            this.cbxProdnam.Size = new System.Drawing.Size(169, 23);
            this.cbxProdnam.TabIndex = 22;
            // 
            // txtTotprice
            // 
            this.txtTotprice.Location = new System.Drawing.Point(449, 296);
            this.txtTotprice.Name = "txtTotprice";
            this.txtTotprice.Size = new System.Drawing.Size(141, 21);
            this.txtTotprice.TabIndex = 24;
            this.txtTotprice.TextChanged += new System.EventHandler(this.txtTotprice_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "TOTAL COST";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(711, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 21);
            this.dtpDate.TabIndex = 25;
            // 
            // gbxTasks
            // 
            this.gbxTasks.BackColor = System.Drawing.Color.Honeydew;
            this.gbxTasks.Controls.Add(this.btnNew);
            this.gbxTasks.Controls.Add(this.btnHome);
            this.gbxTasks.Controls.Add(this.btnAdd);
            this.gbxTasks.Controls.Add(this.btnClear);
            this.gbxTasks.ForeColor = System.Drawing.Color.Blue;
            this.gbxTasks.Location = new System.Drawing.Point(795, 94);
            this.gbxTasks.Name = "gbxTasks";
            this.gbxTasks.Size = new System.Drawing.Size(134, 268);
            this.gbxTasks.TabIndex = 28;
            this.gbxTasks.TabStop = false;
            this.gbxTasks.Text = "TASKS";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Blue;
            this.btnNew.Location = new System.Drawing.Point(27, 214);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 23);
            this.btnNew.TabIndex = 28;
            this.btnNew.Text = "ADD NEW";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.cbxCategory);
            this.gbxDetails.Controls.Add(this.txtQnty);
            this.gbxDetails.Controls.Add(this.label10);
            this.gbxDetails.Controls.Add(this.label3);
            this.gbxDetails.Controls.Add(this.cbxWeight);
            this.gbxDetails.Controls.Add(this.txtTotprice);
            this.gbxDetails.Controls.Add(this.label2);
            this.gbxDetails.Controls.Add(this.label8);
            this.gbxDetails.Controls.Add(this.label4);
            this.gbxDetails.Controls.Add(this.label5);
            this.gbxDetails.Controls.Add(this.label6);
            this.gbxDetails.Controls.Add(this.cbxProdnam);
            this.gbxDetails.Controls.Add(this.label7);
            this.gbxDetails.Controls.Add(this.txtSuppnam);
            this.gbxDetails.Controls.Add(this.label9);
            this.gbxDetails.Controls.Add(this.txtSuppco);
            this.gbxDetails.Controls.Add(this.txtAmnt);
            this.gbxDetails.Controls.Add(this.txtProid);
            this.gbxDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxDetails.Location = new System.Drawing.Point(27, 65);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(762, 383);
            this.gbxDetails.TabIndex = 29;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "DETAILS";
            this.gbxDetails.Enter += new System.EventHandler(this.gbxDetails_Enter);
            // 
            // cbxCategory
            // 
            this.cbxCategory.Location = new System.Drawing.Point(449, 336);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(141, 21);
            this.cbxCategory.TabIndex = 30;
            // 
            // txtQnty
            // 
            this.txtQnty.Location = new System.Drawing.Point(449, 211);
            this.txtQnty.Name = "txtQnty";
            this.txtQnty.Size = new System.Drawing.Size(141, 21);
            this.txtQnty.TabIndex = 29;
            this.txtQnty.TextChanged += new System.EventHandler(this.txtQnty_TextChanged_1);
            this.txtQnty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQnty_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "CATEGORY";
            // 
            // cATEGORYBindingSource1
            // 
            this.cATEGORYBindingSource1.DataMember = "CATEGORY";
            this.cATEGORYBindingSource1.DataSource = this.pURCHASDataSet1;
            // 
            // pURCHASDataSet1
            // 
            this.pURCHASDataSet1.DataSetName = "PURCHASDataSet1";
            this.pURCHASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.pURCHASDataSet1;
            // 
            // lblTimee
            // 
            this.lblTimee.BackColor = System.Drawing.Color.Black;
            this.lblTimee.ForeColor = System.Drawing.Color.Lime;
            this.lblTimee.Location = new System.Drawing.Point(12, 24);
            this.lblTimee.Name = "lblTimee";
            this.lblTimee.Size = new System.Drawing.Size(136, 32);
            this.lblTimee.TabIndex = 30;
            this.lblTimee.Click += new System.EventHandler(this.lblTimee_Click);
            // 
            // pURCHTBBindingSource
            // 
            this.pURCHTBBindingSource.DataMember = "PURCHTB";
            this.pURCHTBBindingSource.DataSource = this.pURCHASDataSet1;
            // 
            // pURCHTBTableAdapter
            // 
            this.pURCHTBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.emloyeesTableAdapter = null;
            this.tableAdapterManager.PASSWORDTableAdapter = null;
            this.tableAdapterManager.PURCHTBTableAdapter = this.pURCHTBTableAdapter;
            this.tableAdapterManager.SALESTableAdapter = null;
            this.tableAdapterManager.STOCKTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pURCHTBDataGridView
            // 
            this.pURCHTBDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.pURCHTBDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pURCHTBDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.pURCHTBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pURCHTBDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.pURCHTBDataGridView.Location = new System.Drawing.Point(15, 453);
            this.pURCHTBDataGridView.Name = "pURCHTBDataGridView";
            this.pURCHTBDataGridView.ReadOnly = true;
            this.pURCHTBDataGridView.Size = new System.Drawing.Size(927, 204);
            this.pURCHTBDataGridView.TabIndex = 30;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCategory);
            this.groupBox1.Location = new System.Drawing.Point(935, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 268);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT CATEGORY";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToOrderColumns = true;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(6, 45);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.Size = new System.Drawing.Size(201, 217);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategory_RowHeaderMouseClick);
            // 
            // PURCH
            // 
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::MANZLEE_RETAIL_MANAGEMENT_SYSTEM.Properties.Resources.light_blue_green_abstract_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pURCHTBDataGridView);
            this.Controls.Add(this.lblTimee);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.gbxTasks);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PURCH";
            this.Load += new System.EventHandler(this.PURCH_Load_1);
            this.gbxTasks.ResumeLayout(false);
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtAmnt.Text=="")
            {
                MessageBox.Show("PLEASE ENTER ALL REQUIRED FIELDS");
                txtAmnt.Focus();
            }
            if (txtProid.Text == "")
            {
                MessageBox.Show("PLEASE ENTER ALL REQUIRED FIELDS");
                txtProid.Focus();
            }
            if (txtQnty.Text == "")
            {
                MessageBox.Show("PLEASE ENTER ALL REQUIRED FIELDS");
                txtQnty.Focus();
            }
            if (txtSuppco.Text == "")
            {
                MessageBox.Show("PLEASE ENTER ALL REQUIRED FIELDS");
                txtSuppco.Focus();
            }
            if (txtSuppnam.Text == "")
            {
                MessageBox.Show("PLEASE ENTER ALL REQUIRED FIELDS");
               txtSuppnam.Focus();
            }
            if (txtTotprice.Text == "")
            {
                MessageBox.Show("PLEASE ENTER ALL REQUIRED FIELDS");
                txtTotprice.Focus();
            }
            
            try
            {
                SqlConnection conn = new SqlConnection(cs.dbcon);
              //  SqlConnection conn = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lap top\Documents\Visual Studio 2015\Projects\MANZLEE RETAIL MANAGEMENT SYSTEM\MANZLEE RETAIL MANAGEMENT SYSTEM\PURCHAS.mdf;");
                conn.Open();
                string ct = "select PRODUCT_id, PRODUCT_NAME from PURCHTB where PRODUCT_id='" + txtProid.Text + "'";
             SqlCommand  cmd;
              SqlDataReader rdr;
                cmd = new SqlCommand(ct);
                //cmd = new OleDbCommand(ct);
                cmd.Connection = conn;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Product NAME Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxProdnam.Focus();
                    MessageBox.Show("Product ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProid.Text = "";
                                     
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    rdr.Close();
                    return;
                    
                }conn.Close();
                conn.Open();


               

                cmd = new SqlCommand("INSERT into PURCHTB(PRODUCT_id,PRODUCT_NAME, PRICE_PER_UNIT, QUANTITY, WEIGHT_KG_LTRES, SUPPLIER, SUPPLIER_CONTACT, DATE, CATEGORY) Values(@id,@nam,@pr,@qnt,@wkg,@supp,@suppc,@tm, @cat)", conn);
                
                cmd.Parameters.AddWithValue("@id", txtProid.Text);
                cmd.Parameters.AddWithValue("@nam", cbxProdnam.Text);
                cmd.Parameters.AddWithValue("@pr", txtAmnt.Text);
                cmd.Parameters.AddWithValue("@qnt", txtQnty.Text);
                cmd.Parameters.AddWithValue("@wkg", cbxWeight.Text);
                cmd.Parameters.AddWithValue("@supp", txtSuppnam.Text);
                cmd.Parameters.AddWithValue("@suppc", txtSuppco.Text);
                cmd.Parameters.AddWithValue("@tm", dtpDate.Text);
                cmd.Parameters.AddWithValue("@cat", cbxCategory.Text);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("DATA SUCCESSFULY ADDED");

                conn.Close();
                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select * FROM PURCHTB where PRODUCT_id='"+txtProid.Text+"'", conn);
                DataTable DR;
                DR = new DataTable();
                sda.Fill(DR);
                pURCHTBDataGridView.DataSource = DR;
                //GetData();
               
                conn.Close();
                clear();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"ERROR" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void txtQnty_TextChanged(object sender, EventArgs e)
        {
           /* int val1 = 0;
            int val2 = 0;
            int.TryParse(txtAmnt.Text, out val1);
            int.TryParse(nudQnty.Text, out val2);
            int I = (val1 * val2);
            txtTotprice.Text = I.ToString();*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxCategory.Text = "";
            txtSuppnam.Text = "";
            txtAmnt.Clear();
            txtProid.Clear();
            txtSuppco.Clear();
            txtTotprice.Clear();
            txtQnty.Text = "";
            cbxProdnam.Text="";
            cbxWeight.Text = "";

            btnNew.Enabled = true;
            gbxDetails.Enabled = false;
        }
        private void clear()
        {
            cbxCategory.Text = "";
            txtSuppnam.Text = "";
            txtAmnt.Clear();
            txtProid.Clear();
            txtSuppco.Clear();
            txtTotprice.Clear();
            txtQnty.Text = "";
            cbxProdnam.Text = "";
            cbxWeight.Text = "";

            btnNew.Enabled = true;
            gbxDetails.Enabled = false;
        }


        private void txtProid_TextChanged(object sender, EventArgs e)
        {
            if(!System.Text.RegularExpressions.Regex.IsMatch(txtProid.Text,"^[0-9]"))
            {
                txtProid.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = id + 1;
            txtProid.Text = id.ToString();
            btnNew.Enabled = false;
            gbxDetails.Enabled = true;
           

        }

        private void gbxDetails_Enter(object sender, EventArgs e)
        {
            
        }

        private void dudQnty_KeyDown(object sender, KeyEventArgs e)
        {
           // int c=0;
           // c=c-1;
           // dudQnty.Text = c.ToString();
        }

        private void dudQnty_KeyUp(object sender, KeyEventArgs e)
        {
           // int c = 0;
           // c = c + 1;
           // dudQnty.Text = c.ToString();
        }


       

        private void dudQnty_SelectedItemChanged(object sender, EventArgs e)
        {
           
        }

        private void PURCH_Load_1(object sender, EventArgs e)
        {
            GetDatac();
           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTimee.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lblTimee_Click(object sender, EventArgs e)
        {

        }

        private void nudQnty_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTotprice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQnty_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                /*int val1 = 0;
                int val2 = 0;
                int.TryParse(txtAmnt.Text, out val1);
                int.TryParse(txtQnty.Text, out val2);
                int I = (val1 * val2);
                txtTotprice.Text = I.ToString();*/
                int pr, s, q;
                pr = 0;
                s = 0;
                q = 0;

                /* pr = Convert.ToDouble(txtAmnt.Text);
                 q = Convert.ToDouble(txtQnty.Text);
                 s = Convert.ToDouble(txtTotprice.Text);*/
                int.TryParse(txtAmnt.Text, out pr);
                int.TryParse(txtQnty.Text, out q);
                int.TryParse(txtTotprice.Text, out s);
                s = pr * q;
                txtTotprice.Text = s.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);


            }
        }

       
       
        private void cbxCatgory_SelectedIndexChanged(object sender, EventArgs e)
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
                dgvCategory.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCategory.Refresh();
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

        private void txtAmnt_TextChanged(object sender, EventArgs e)
        {
            double amt=0.0;
            txtAmnt.Text = amt.ToString("0:C");
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtProid.Text, "^[A-Z,$] [0-9]"))
            {
                txtProid.Text = "";
            }
        }

        private void txtQnty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&(e.KeyChar!='.'))
            {
                e.Handled = true;
            }
                    
        }
    }
}
    

