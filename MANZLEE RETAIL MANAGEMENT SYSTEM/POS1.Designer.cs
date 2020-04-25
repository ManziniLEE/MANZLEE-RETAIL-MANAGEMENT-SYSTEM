namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    partial class POS1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS1));
            this.btnConf = new System.Windows.Forms.Button();
            this.txtItemno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtnames = new System.Windows.Forms.TextBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtweigth = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOT_AMNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntyAvailable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQnty = new System.Windows.Forms.TextBox();
            this.txtTotprice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoneypaid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.txtItempri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lnlcalculat = new System.Windows.Forms.LinkLabel();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHASDataSet1 = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1();
            this.sTOCKTableAdapter = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.STOCKTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.datesave = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConf
            // 
            this.btnConf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConf.Location = new System.Drawing.Point(26, 123);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(106, 51);
            this.btnConf.TabIndex = 0;
            this.btnConf.Text = "CONFIRM  ";
            this.btnConf.UseVisualStyleBackColor = false;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // txtItemno
            // 
            this.txtItemno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemno.Location = new System.Drawing.Point(206, 36);
            this.txtItemno.Multiline = true;
            this.txtItemno.Name = "txtItemno";
            this.txtItemno.Size = new System.Drawing.Size(172, 24);
            this.txtItemno.TabIndex = 2;
            this.txtItemno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(487, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "POINT OF SALE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ITEM DETAILS";
            // 
            // btnCanc
            // 
            this.btnCanc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCanc.BackColor = System.Drawing.Color.Lime;
            this.btnCanc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCanc.Location = new System.Drawing.Point(95, 241);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(106, 41);
            this.btnCanc.TabIndex = 6;
            this.btnCanc.Text = "HOME";
            this.btnCanc.UseVisualStyleBackColor = false;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdd.Location = new System.Drawing.Point(26, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 41);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "GET ITEM";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(1006, 41);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 20);
            this.dtpTime.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(749, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "CHANGE";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtChange
            // 
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChange.Location = new System.Drawing.Point(889, 63);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(111, 30);
            this.txtChange.TabIndex = 13;
            this.txtChange.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtcategory);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtnames);
            this.groupBox1.Controls.Add(this.btnseach);
            this.groupBox1.Controls.Add(this.btnremove);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtweigth);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.qntyAvailable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQnty);
            this.groupBox1.Controls.Add(this.txtTotprice);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNma);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMoneypaid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtInvoice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtItemno);
            this.groupBox1.Controls.Add(this.txtChange);
            this.groupBox1.Controls.Add(this.txtItempri);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 481);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALE ITEM";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(408, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "CATEGORY";
            // 
            // txtcategory
            // 
            this.txtcategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcategory.Location = new System.Drawing.Point(506, 200);
            this.txtcategory.MaxLength = 5;
            this.txtcategory.Multiline = true;
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.ReadOnly = true;
            this.txtcategory.Size = new System.Drawing.Size(117, 30);
            this.txtcategory.TabIndex = 40;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(926, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 59);
            this.button3.TabIndex = 20;
            this.button3.Text = "GET SUBTOTAL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(6, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
            this.button1.TabIndex = 39;
            this.button1.Text = "REMOVE ALL ITEMS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 421);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 14);
            this.label14.TabIndex = 38;
            this.label14.Text = "enter name here";
            // 
            // txtnames
            // 
            this.txtnames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnames.Location = new System.Drawing.Point(6, 444);
            this.txtnames.Multiline = true;
            this.txtnames.Name = "txtnames";
            this.txtnames.Size = new System.Drawing.Size(162, 31);
            this.txtnames.TabIndex = 37;
            this.txtnames.TextChanged += new System.EventHandler(this.txtnames_TextChanged);
            // 
            // btnseach
            // 
            this.btnseach.BackColor = System.Drawing.Color.AliceBlue;
            this.btnseach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnseach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnseach.Location = new System.Drawing.Point(6, 377);
            this.btnseach.Name = "btnseach";
            this.btnseach.Size = new System.Drawing.Size(133, 41);
            this.btnseach.TabIndex = 36;
            this.btnseach.Text = "SEARCH ITEM";
            this.btnseach.UseVisualStyleBackColor = false;
            this.btnseach.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.AliceBlue;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnremove.Location = new System.Drawing.Point(6, 287);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(133, 41);
            this.btnremove.TabIndex = 19;
            this.btnremove.Text = "DELETE ITEM FROM LIST";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(411, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "WEIGHT";
            // 
            // txtweigth
            // 
            this.txtweigth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtweigth.Location = new System.Drawing.Point(506, 88);
            this.txtweigth.MaxLength = 5;
            this.txtweigth.Multiline = true;
            this.txtweigth.Name = "txtweigth";
            this.txtweigth.ReadOnly = true;
            this.txtweigth.Size = new System.Drawing.Size(117, 30);
            this.txtweigth.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.ITEMNAME,
            this.COST,
            this.TOT_AMNT,
            this.QUAN,
            this.MAS,
            this.CATE,
            this.date,
            this.invoice});
            this.helpProvider1.SetHelpNavigator(this.dataGridView1, System.Windows.Forms.HelpNavigator.Index);
            this.dataGridView1.Location = new System.Drawing.Point(175, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowTemplate.Height = 20;
            this.helpProvider1.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(863, 231);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // CODE
            // 
            this.CODE.HeaderText = "ITEM CODE";
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            // 
            // ITEMNAME
            // 
            this.ITEMNAME.HeaderText = "ITEM NAME";
            this.ITEMNAME.Name = "ITEMNAME";
            this.ITEMNAME.ReadOnly = true;
            // 
            // COST
            // 
            this.COST.HeaderText = "PRICE";
            this.COST.Name = "COST";
            this.COST.ReadOnly = true;
            // 
            // TOT_AMNT
            // 
            this.TOT_AMNT.HeaderText = "TOTAL AMOUNT";
            this.TOT_AMNT.Name = "TOT_AMNT";
            this.TOT_AMNT.ReadOnly = true;
            // 
            // QUAN
            // 
            this.QUAN.HeaderText = "QUANTITY";
            this.QUAN.Name = "QUAN";
            this.QUAN.ReadOnly = true;
            // 
            // MAS
            // 
            this.MAS.HeaderText = "MASS";
            this.MAS.Name = "MAS";
            this.MAS.ReadOnly = true;
            // 
            // CATE
            // 
            this.CATE.HeaderText = "CATEGORY";
            this.CATE.Name = "CATE";
            this.CATE.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // invoice
            // 
            this.invoice.HeaderText = "INVOICE NUMBER";
            this.invoice.Name = "invoice";
            this.invoice.ReadOnly = true;
            this.invoice.ToolTipText = "Invoice number";
            // 
            // qntyAvailable
            // 
            this.qntyAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qntyAvailable.Location = new System.Drawing.Point(506, 36);
            this.qntyAvailable.Multiline = true;
            this.qntyAvailable.Name = "qntyAvailable";
            this.qntyAvailable.ReadOnly = true;
            this.qntyAvailable.Size = new System.Drawing.Size(117, 30);
            this.qntyAvailable.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "ITEM NUMBER";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(738, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "TOTAL COST";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(889, 114);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(111, 30);
            this.txtTotal.TabIndex = 29;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "QUANTITY ";
            // 
            // txtQnty
            // 
            this.txtQnty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQnty.Location = new System.Drawing.Point(506, 145);
            this.txtQnty.MaxLength = 5;
            this.txtQnty.Multiline = true;
            this.txtQnty.Name = "txtQnty";
            this.txtQnty.Size = new System.Drawing.Size(117, 30);
            this.txtQnty.TabIndex = 27;
            this.txtQnty.TextChanged += new System.EventHandler(this.txtQnty_TextChanged);
            this.txtQnty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQnty_KeyUp);
            // 
            // txtTotprice
            // 
            this.txtTotprice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTotprice.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotprice.Location = new System.Drawing.Point(812, 173);
            this.txtTotprice.Multiline = true;
            this.txtTotprice.Name = "txtTotprice";
            this.txtTotprice.ReadOnly = true;
            this.txtTotprice.Size = new System.Drawing.Size(108, 68);
            this.txtTotprice.TabIndex = 25;
            this.txtTotprice.TextChanged += new System.EventHandler(this.txtTotprice_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(669, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "SUBTOTAL PRICE";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "ITEM NAME";
            // 
            // txtNma
            // 
            this.txtNma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNma.Location = new System.Drawing.Point(204, 145);
            this.txtNma.MaxLength = 5;
            this.txtNma.Multiline = true;
            this.txtNma.Name = "txtNma";
            this.txtNma.ReadOnly = true;
            this.txtNma.Size = new System.Drawing.Size(172, 30);
            this.txtNma.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(408, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "AVAILABLE ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(749, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "MONEY PAID";
            // 
            // txtMoneypaid
            // 
            this.txtMoneypaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoneypaid.Location = new System.Drawing.Point(889, 16);
            this.txtMoneypaid.Multiline = true;
            this.txtMoneypaid.Name = "txtMoneypaid";
            this.txtMoneypaid.Size = new System.Drawing.Size(111, 30);
            this.txtMoneypaid.TabIndex = 19;
            this.txtMoneypaid.TextChanged += new System.EventHandler(this.txtMoneypaid_TextChanged);
            this.txtMoneypaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoneypaid_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "INVOICE NUMBER";
            // 
            // txtInvoice
            // 
            this.txtInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoice.Location = new System.Drawing.Point(204, 87);
            this.txtInvoice.MaxLength = 5;
            this.txtInvoice.Multiline = true;
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.ReadOnly = true;
            this.txtInvoice.Size = new System.Drawing.Size(172, 30);
            this.txtInvoice.TabIndex = 15;
            this.txtInvoice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtItempri
            // 
            this.txtItempri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItempri.Location = new System.Drawing.Point(202, 207);
            this.txtItempri.Multiline = true;
            this.txtItempri.Name = "txtItempri";
            this.txtItempri.ReadOnly = true;
            this.txtItempri.Size = new System.Drawing.Size(174, 31);
            this.txtItempri.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "ITEM PRICE";
            // 
            // dgvPos
            // 
            this.dgvPos.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPos.Location = new System.Drawing.Point(125, 565);
            this.dgvPos.Name = "dgvPos";
            this.dgvPos.Size = new System.Drawing.Size(931, 104);
            this.dgvPos.TabIndex = 33;
            this.dgvPos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPos_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.btnprint);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Controls.Add(this.btnConf);
            this.groupBox2.Controls.Add(this.btnCanc);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(1062, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 323);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnprint
            // 
            this.btnprint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnprint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnprint.Location = new System.Drawing.Point(138, 123);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(89, 51);
            this.btnprint.TabIndex = 19;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(138, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 41);
            this.button2.TabIndex = 18;
            this.button2.Text = "ADD ITEM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPay
            // 
            this.btnPay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPay.Location = new System.Drawing.Point(26, 70);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(106, 41);
            this.btnPay.TabIndex = 17;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(12, 31);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(131, 30);
            this.lblTime.TabIndex = 19;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lnlcalculat
            // 
            this.lnlcalculat.AutoSize = true;
            this.lnlcalculat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlcalculat.Location = new System.Drawing.Point(1068, 319);
            this.lnlcalculat.Name = "lnlcalculat";
            this.lnlcalculat.Size = new System.Drawing.Size(145, 24);
            this.lnlcalculat.TabIndex = 24;
            this.lnlcalculat.TabStop = true;
            this.lnlcalculat.Text = "CALCULATOR";
            this.lnlcalculat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlcalculat_LinkClicked);
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.pURCHASDataSet1;
            // 
            // pURCHASDataSet1
            // 
            this.pURCHASDataSet1.DataSetName = "PURCHASDataSet1";
            this.pURCHASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOCKTableAdapter
            // 
            this.sTOCKTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1068, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Sale";
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Visible = false;
            // 
            // datesave
            // 
            this.datesave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datesave.Location = new System.Drawing.Point(163, 31);
            this.datesave.Multiline = true;
            this.datesave.Name = "datesave";
            this.datesave.Size = new System.Drawing.Size(172, 30);
            this.datesave.TabIndex = 42;
            this.datesave.Visible = false;
            // 
            // POS1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1307, 681);
            this.Controls.Add(this.datesave);
            this.Controls.Add(this.dgvPos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnlcalculat);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POS1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.TextBox txtItemno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoneypaid;
        private PURCHASDataSet1 pURCHASDataSet1;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private PURCHASDataSet1TableAdapters.STOCKTableAdapter sTOCKTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotprice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel lnlcalculat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qntyAvailable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvPos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtnames;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtweigth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQnty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNma;
        private System.Windows.Forms.TextBox txtItempri;
        private System.Windows.Forms.Label label4;
   
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.TextBox datesave;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COST;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOT_AMNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice;
    }
}