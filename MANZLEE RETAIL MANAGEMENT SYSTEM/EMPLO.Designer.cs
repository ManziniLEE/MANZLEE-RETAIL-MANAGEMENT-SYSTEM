namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    partial class EMPLO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMPLO));
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddre = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.txtDedu = new System.Windows.Forms.TextBox();
            this.txtNetsal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.pURCHASDataSet1 = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1();
            this.emloyeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emloyeesTableAdapter = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.emloyeesTableAdapter();
            this.tableAdapterManager = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.TableAdapterManager();
            this.emloyeesDataGridView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.cbxYr = new System.Windows.Forms.ComboBox();
            this.cbxMont = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxGEN = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDesign = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidnat = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloyeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloyeesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Aqua;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(16, 83);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 34);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(352, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLOYEE DETAILS";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(213, 46);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(226, 20);
            this.txtFname.TabIndex = 2;
            this.txtFname.Validated += new System.EventHandler(this.txtFname_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "FULL NAME";
            // 
            // txtAddre
            // 
            this.txtAddre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddre.Location = new System.Drawing.Point(213, 157);
            this.txtAddre.Multiline = true;
            this.txtAddre.Name = "txtAddre";
            this.txtAddre.Size = new System.Drawing.Size(226, 75);
            this.txtAddre.TabIndex = 5;
            // 
            // txtSal
            // 
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal.Location = new System.Drawing.Point(650, 150);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(129, 20);
            this.txtSal.TabIndex = 6;
            this.txtSal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSal_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DOB (dd/mm/yyyy)";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(898, 65);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(125, 30);
            this.lblTime.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "SALARY($)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "ADDRESS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(486, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "EMPLOYEE NUMBER";
            // 
            // txtEmpno
            // 
            this.txtEmpno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpno.Location = new System.Drawing.Point(650, 47);
            this.txtEmpno.MaxLength = 10;
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(129, 20);
            this.txtEmpno.TabIndex = 15;
            this.txtEmpno.TextChanged += new System.EventHandler(this.txtEmpno_TextChanged);
            // 
            // txtDedu
            // 
            this.txtDedu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDedu.Location = new System.Drawing.Point(650, 203);
            this.txtDedu.Name = "txtDedu";
            this.txtDedu.Size = new System.Drawing.Size(79, 20);
            this.txtDedu.TabIndex = 16;
            this.txtDedu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDedu_KeyPress);
            // 
            // txtNetsal
            // 
            this.txtNetsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetsal.Location = new System.Drawing.Point(650, 259);
            this.txtNetsal.Name = "txtNetsal";
            this.txtNetsal.Size = new System.Drawing.Size(111, 20);
            this.txtNetsal.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(486, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "DEDUCTIONS(%)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(486, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "NET SALARY($)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "DESIGNATION";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(16, 30);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 35);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(16, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 37);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(34, 65);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 24;
            // 
            // pURCHASDataSet1
            // 
            this.pURCHASDataSet1.DataSetName = "PURCHASDataSet1";
            this.pURCHASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emloyeesBindingSource
            // 
            this.emloyeesBindingSource.DataMember = "emloyees";
            this.emloyeesBindingSource.DataSource = this.pURCHASDataSet1;
            // 
            // emloyeesTableAdapter
            // 
            this.emloyeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.emloyeesTableAdapter = this.emloyeesTableAdapter;
            this.tableAdapterManager.PASSWORDTableAdapter = null;
            this.tableAdapterManager.PURCHTBTableAdapter = null;
            this.tableAdapterManager.SALESTableAdapter = null;
            this.tableAdapterManager.STOCKTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // emloyeesDataGridView
            // 
            this.emloyeesDataGridView.AllowUserToOrderColumns = true;
            this.emloyeesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.emloyeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emloyeesDataGridView.Location = new System.Drawing.Point(34, 477);
            this.emloyeesDataGridView.Name = "emloyeesDataGridView";
            this.emloyeesDataGridView.ReadOnly = true;
            this.emloyeesDataGridView.Size = new System.Drawing.Size(856, 166);
            this.emloyeesDataGridView.TabIndex = 26;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbxDay
            // 
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "11",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxDay.Location = new System.Drawing.Point(213, 113);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(51, 24);
            this.cbxDay.TabIndex = 30;
            // 
            // cbxYr
            // 
            this.cbxYr.FormattingEnabled = true;
            this.cbxYr.Location = new System.Drawing.Point(358, 113);
            this.cbxYr.MaxLength = 4;
            this.cbxYr.Name = "cbxYr";
            this.cbxYr.Size = new System.Drawing.Size(74, 24);
            this.cbxYr.TabIndex = 31;
            // 
            // cbxMont
            // 
            this.cbxMont.FormattingEnabled = true;
            this.cbxMont.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JUL",
            "AUG",
            "OCT",
            "NOV",
            "DEC"});
            this.cbxMont.Location = new System.Drawing.Point(270, 113);
            this.cbxMont.Name = "cbxMont";
            this.cbxMont.Size = new System.Drawing.Size(82, 24);
            this.cbxMont.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "ID NUMBER [eg 22-222222F22]";
            // 
            // cbxGEN
            // 
            this.cbxGEN.FormattingEnabled = true;
            this.cbxGEN.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cbxGEN.Location = new System.Drawing.Point(26, 27);
            this.cbxGEN.MaxLength = 2;
            this.cbxGEN.Name = "cbxGEN";
            this.cbxGEN.Size = new System.Drawing.Size(139, 24);
            this.cbxGEN.TabIndex = 35;
            this.cbxGEN.Text = "--SELECT ITEM--";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Location = new System.Drawing.Point(918, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 189);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TASKS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(733, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "GET NET SALARY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-106, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "GENDER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDesign);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtidnat);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtFname);
            this.groupBox2.Controls.Add(this.txtAddre);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtNetsal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDedu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbxDay);
            this.groupBox2.Controls.Add(this.cbxYr);
            this.groupBox2.Controls.Add(this.txtEmpno);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbxMont);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 354);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EMPLOYEE DETAILS";
            // 
            // txtDesign
            // 
            this.txtDesign.FormattingEnabled = true;
            this.txtDesign.Items.AddRange(new object[] {
            "TILL OPERATOR",
            "ADMINISTRATOR",
            "MANAGER",
            "SUPERVISOR",
            "JANITOR",
            "GUARD",
            "AUDITOR",
            "TECHNICIAN"});
            this.txtDesign.Location = new System.Drawing.Point(650, 95);
            this.txtDesign.MaxLength = 4;
            this.txtDesign.Name = "txtDesign";
            this.txtDesign.Size = new System.Drawing.Size(145, 24);
            this.txtDesign.TabIndex = 47;
            this.txtDesign.Text = "--SELECT ITEM--";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(213, 245);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(226, 20);
            this.txtemail.TabIndex = 46;
            this.txtemail.Validating += new System.ComponentModel.CancelEventHandler(this.txtemail_Validating);
            this.txtemail.Validated += new System.EventHandler(this.txtemail_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "EMAIL ADDRESS";
            // 
            // txtidnat
            // 
            this.txtidnat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidnat.Location = new System.Drawing.Point(213, 78);
            this.txtidnat.Name = "txtidnat";
            this.txtidnat.Size = new System.Drawing.Size(226, 20);
            this.txtidnat.TabIndex = 44;
            this.txtidnat.TextChanged += new System.EventHandler(this.txtidnat_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbxGEN);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(187, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 65);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GENDER";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EMPLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.emloyeesDataGridView);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Name = "EMPLO";
            this.Text = "EMPLO";
            this.Load += new System.EventHandler(this.EMPLO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloyeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloyeesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddre;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.TextBox txtDedu;
        private System.Windows.Forms.TextBox txtNetsal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private PURCHASDataSet1 pURCHASDataSet1;
        private System.Windows.Forms.BindingSource emloyeesBindingSource;
        private PURCHASDataSet1TableAdapters.emloyeesTableAdapter emloyeesTableAdapter;
        private PURCHASDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView emloyeesDataGridView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.ComboBox cbxYr;
        private System.Windows.Forms.ComboBox cbxMont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxGEN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtidnat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox txtDesign;
    }
}