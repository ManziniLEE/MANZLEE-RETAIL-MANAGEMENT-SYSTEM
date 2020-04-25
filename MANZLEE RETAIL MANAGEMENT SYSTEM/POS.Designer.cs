namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    partial class POS
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
            this.sTOCKTableAdapter = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.STOCKTableAdapter();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHASDataSet1 = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1();
            this.lnlcalculat = new System.Windows.Forms.LinkLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQnty = new System.Windows.Forms.TextBox();
            this.txtTotprice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNma = new System.Windows.Forms.TextBox();
            this.qntyAvailable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoneypaid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.txtItempri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemno = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sTOCKTableAdapter
            // 
            this.sTOCKTableAdapter.ClearBeforeFill = true;
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
            // lnlcalculat
            // 
            this.lnlcalculat.AutoSize = true;
            this.lnlcalculat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlcalculat.Location = new System.Drawing.Point(1079, 322);
            this.lnlcalculat.Name = "lnlcalculat";
            this.lnlcalculat.Size = new System.Drawing.Size(126, 20);
            this.lnlcalculat.TabIndex = 32;
            this.lnlcalculat.TabStop = true;
            this.lnlcalculat.Text = "CALCULATOR";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listView1.Location = new System.Drawing.Point(150, 449);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(881, 197);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(33, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(131, 30);
            this.lblTime.TabIndex = 30;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(46, 193);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 41);
            this.btnPay.TabIndex = 17;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Controls.Add(this.btnConf);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnCanc);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(1083, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 313);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // btnConf
            // 
            this.btnConf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConf.Location = new System.Drawing.Point(28, 66);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(106, 61);
            this.btnConf.TabIndex = 0;
            this.btnConf.Text = "CONFIRM /SAVE AS PDF";
            this.btnConf.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "PRINT RECEIPT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCanc
            // 
            this.btnCanc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCanc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanc.Location = new System.Drawing.Point(49, 254);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 41);
            this.btnCanc.TabIndex = 6;
            this.btnCanc.Text = "CANCEL";
            this.btnCanc.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(47, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 41);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD ITEM";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "ITEM NUMBER";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(564, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "TOTAL PRICE";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(711, 112);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 30);
            this.txtTotal.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "QUANTITY ";
            // 
            // txtQnty
            // 
            this.txtQnty.Location = new System.Drawing.Point(297, 282);
            this.txtQnty.MaxLength = 5;
            this.txtQnty.Multiline = true;
            this.txtQnty.Name = "txtQnty";
            this.txtQnty.Size = new System.Drawing.Size(172, 30);
            this.txtQnty.TabIndex = 27;
            // 
            // txtTotprice
            // 
            this.txtTotprice.Location = new System.Drawing.Point(711, 291);
            this.txtTotprice.Multiline = true;
            this.txtTotprice.Name = "txtTotprice";
            this.txtTotprice.Size = new System.Drawing.Size(178, 31);
            this.txtTotprice.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(569, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "TOTAL PRICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(544, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "POINT OF SALE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "ITEM NAME";
            // 
            // txtNma
            // 
            this.txtNma.Location = new System.Drawing.Point(299, 156);
            this.txtNma.MaxLength = 5;
            this.txtNma.Multiline = true;
            this.txtNma.Name = "txtNma";
            this.txtNma.ReadOnly = true;
            this.txtNma.Size = new System.Drawing.Size(172, 30);
            this.txtNma.TabIndex = 23;
            // 
            // qntyAvailable
            // 
            this.qntyAvailable.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.qntyAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qntyAvailable.Location = new System.Drawing.Point(708, 41);
            this.qntyAvailable.Name = "qntyAvailable";
            this.qntyAvailable.Size = new System.Drawing.Size(90, 30);
            this.qntyAvailable.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(583, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "AVAILABLE ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(564, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "MONEY PAID";
            // 
            // txtMoneypaid
            // 
            this.txtMoneypaid.Location = new System.Drawing.Point(711, 174);
            this.txtMoneypaid.Multiline = true;
            this.txtMoneypaid.Name = "txtMoneypaid";
            this.txtMoneypaid.Size = new System.Drawing.Size(178, 30);
            this.txtMoneypaid.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "INVOICE NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "ITEM DETAILS";
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(299, 98);
            this.txtInvoice.MaxLength = 5;
            this.txtInvoice.Multiline = true;
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.ReadOnly = true;
            this.txtInvoice.Size = new System.Drawing.Size(172, 30);
            this.txtInvoice.TabIndex = 15;
            // 
            // txtItempri
            // 
            this.txtItempri.Location = new System.Drawing.Point(297, 218);
            this.txtItempri.Multiline = true;
            this.txtItempri.Name = "txtItempri";
            this.txtItempri.Size = new System.Drawing.Size(174, 31);
            this.txtItempri.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "ITEM PRICE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQnty);
            this.groupBox1.Controls.Add(this.txtTotprice);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNma);
            this.groupBox1.Controls.Add(this.qntyAvailable);
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
            this.groupBox1.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(87, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 340);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALE ITEM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "CHANGE";
            // 
            // txtItemno
            // 
            this.txtItemno.Location = new System.Drawing.Point(301, 47);
            this.txtItemno.Multiline = true;
            this.txtItemno.Name = "txtItemno";
            this.txtItemno.Size = new System.Drawing.Size(172, 24);
            this.txtItemno.TabIndex = 2;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(711, 237);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(133, 30);
            this.txtChange.TabIndex = 13;
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(1027, 47);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 20);
            this.dtpTime.TabIndex = 27;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 750);
            this.Controls.Add(this.lnlcalculat);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpTime);
            this.Name = "POS";
            this.Text = "POS";
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PURCHASDataSet1TableAdapters.STOCKTableAdapter sTOCKTableAdapter;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private PURCHASDataSet1 pURCHASDataSet1;
        private System.Windows.Forms.LinkLabel lnlcalculat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQnty;
        private System.Windows.Forms.TextBox txtTotprice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNma;
        private System.Windows.Forms.Label qntyAvailable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoneypaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.TextBox txtItempri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemno;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}