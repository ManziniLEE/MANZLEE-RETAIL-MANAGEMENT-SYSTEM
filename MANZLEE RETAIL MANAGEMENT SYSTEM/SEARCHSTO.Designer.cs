namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    partial class SEARCHSTO
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
            this.pURCHASDataSet1 = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTOCKTableAdapter = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.STOCKTableAdapter();
            this.tableAdapterManager = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.TableAdapterManager();
            this.sTOCKDataGridView = new System.Windows.Forms.DataGridView();
            this.sTOCKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnALL = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtqua = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.txtitnam = new System.Windows.Forms.TextBox();
            this.txtpri = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btntxt = new System.Windows.Forms.Button();
            this.pURCHASDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pURCHASDataSet1
            // 
            this.pURCHASDataSet1.DataSetName = "PURCHASDataSet1";
            this.pURCHASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.pURCHASDataSet1;
            // 
            // sTOCKTableAdapter
            // 
            this.sTOCKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.emloyeesTableAdapter = null;
            this.tableAdapterManager.PASSWORDTableAdapter = null;
            this.tableAdapterManager.PURCHTBTableAdapter = null;
            this.tableAdapterManager.SALESTableAdapter = null;
            this.tableAdapterManager.STOCKTableAdapter = this.sTOCKTableAdapter;
            this.tableAdapterManager.UpdateOrder = MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sTOCKDataGridView
            // 
            this.sTOCKDataGridView.AllowUserToOrderColumns = true;
            this.sTOCKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sTOCKDataGridView.Location = new System.Drawing.Point(12, 208);
            this.sTOCKDataGridView.Name = "sTOCKDataGridView";
            this.sTOCKDataGridView.Size = new System.Drawing.Size(852, 220);
            this.sTOCKDataGridView.TabIndex = 1;
            this.sTOCKDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sTOCKDataGridView_RowHeaderMouseClick);
            // 
            // sTOCKBindingSource1
            // 
            this.sTOCKBindingSource1.DataMember = "STOCK";
            this.sTOCKBindingSource1.DataSource = this.pURCHASDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "SEARCH STOCK";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(8, 29);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(109, 45);
            this.btnHome.TabIndex = 19;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(846, 139);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(86, 45);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "SEARCH ITEM BY NAME";
            // 
            // btnALL
            // 
            this.btnALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALL.Location = new System.Drawing.Point(8, 104);
            this.btnALL.Name = "btnALL";
            this.btnALL.Size = new System.Drawing.Size(109, 45);
            this.btnALL.TabIndex = 23;
            this.btnALL.Text = "VIEW ALL";
            this.btnALL.UseVisualStyleBackColor = true;
            this.btnALL.Click += new System.EventHandler(this.btnALL_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(8, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 45);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnALL);
            this.groupBox1.Location = new System.Drawing.Point(894, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 323);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(6, 237);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(109, 45);
            this.btndelete.TabIndex = 25;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtcat);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtvat);
            this.groupBox2.Controls.Add(this.txtweight);
            this.groupBox2.Controls.Add(this.txtqua);
            this.groupBox2.Controls.Add(this.txttax);
            this.groupBox2.Controls.Add(this.txtitnam);
            this.groupBox2.Controls.Add(this.txtpri);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 225);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ITEMS TO UPDATE";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "CATEGORY";
            // 
            // txtcat
            // 
            this.txtcat.Location = new System.Drawing.Point(642, 51);
            this.txtcat.Multiline = true;
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(168, 38);
            this.txtcat.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "ITEM PRICE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "ITEM PRICE[PRICE]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "QUANTITY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "ITEM ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "TAX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "WEIGHT PER UNIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "ITEM NAME";
            // 
            // txtvat
            // 
            this.txtvat.Location = new System.Drawing.Point(175, 180);
            this.txtvat.Multiline = true;
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new System.Drawing.Size(168, 38);
            this.txtvat.TabIndex = 33;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(642, 95);
            this.txtweight.Multiline = true;
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(168, 38);
            this.txtweight.TabIndex = 32;
            // 
            // txtqua
            // 
            this.txtqua.Location = new System.Drawing.Point(642, 183);
            this.txtqua.Multiline = true;
            this.txtqua.Name = "txtqua";
            this.txtqua.Size = new System.Drawing.Size(168, 38);
            this.txtqua.TabIndex = 31;
            // 
            // txttax
            // 
            this.txttax.Location = new System.Drawing.Point(642, 139);
            this.txttax.Multiline = true;
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(168, 38);
            this.txttax.TabIndex = 30;
            // 
            // txtitnam
            // 
            this.txtitnam.Location = new System.Drawing.Point(175, 74);
            this.txtitnam.Multiline = true;
            this.txtitnam.Name = "txtitnam";
            this.txtitnam.Size = new System.Drawing.Size(168, 38);
            this.txtitnam.TabIndex = 29;
            // 
            // txtpri
            // 
            this.txtpri.Location = new System.Drawing.Point(173, 127);
            this.txtpri.Multiline = true;
            this.txtpri.Name = "txtpri";
            this.txtpri.Size = new System.Drawing.Size(168, 38);
            this.txtpri.TabIndex = 28;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(175, 21);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(168, 38);
            this.txtid.TabIndex = 27;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(555, 139);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(254, 38);
            this.txtSearch.TabIndex = 22;
            // 
            // btntxt
            // 
            this.btntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntxt.Location = new System.Drawing.Point(902, 561);
            this.btntxt.Name = "btntxt";
            this.btntxt.Size = new System.Drawing.Size(109, 45);
            this.btntxt.TabIndex = 26;
            this.btntxt.Text = "EXPORT TXT";
            this.btntxt.UseVisualStyleBackColor = true;
            this.btntxt.Click += new System.EventHandler(this.btntxt_Click);
            // 
            // pURCHASDataSet1BindingSource
            // 
            this.pURCHASDataSet1BindingSource.DataSource = this.pURCHASDataSet1;
            this.pURCHASDataSet1BindingSource.Position = 0;
            // 
            // SEARCHSTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1060, 671);
            this.Controls.Add(this.btntxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sTOCKDataGridView);
            this.Name = "SEARCHSTO";
            this.Text = "SEARCHSTO";
            this.Load += new System.EventHandler(this.SEARCHSTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PURCHASDataSet1 pURCHASDataSet1;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private PURCHASDataSet1TableAdapters.STOCKTableAdapter sTOCKTableAdapter;
        private PURCHASDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sTOCKDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnALL;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvat;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtqua;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.TextBox txtitnam;
        private System.Windows.Forms.TextBox txtpri;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btntxt;
        private System.Windows.Forms.BindingSource sTOCKBindingSource1;
        private System.Windows.Forms.BindingSource pURCHASDataSet1BindingSource;
    }
}