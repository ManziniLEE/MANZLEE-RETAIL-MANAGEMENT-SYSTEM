namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    partial class VIEWPURCH
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
            this.pURCHTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHTBTableAdapter = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.PURCHTBTableAdapter();
            this.tableAdapterManager = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.TableAdapterManager();
            this.pURCHTBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHTBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHTBComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnALL = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pURCHTBDataGridView = new System.Windows.Forms.DataGridView();
            this.pURCHTBBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHTBBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHTBBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHTBBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // pURCHASDataSet1
            // 
            this.pURCHASDataSet1.DataSetName = "PURCHASDataSet1";
            this.pURCHASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pURCHTBBindingSource2
            // 
            this.pURCHTBBindingSource2.DataMember = "PURCHTB";
            this.pURCHTBBindingSource2.DataSource = this.pURCHASDataSet1;
            // 
            // pURCHTBBindingSource1
            // 
            this.pURCHTBBindingSource1.DataMember = "PURCHTB";
            this.pURCHTBBindingSource1.DataSource = this.pURCHASDataSet1;
            // 
            // pURCHTBComboBox
            // 
            this.pURCHTBComboBox.DataSource = this.pURCHTBBindingSource1;
            this.pURCHTBComboBox.DisplayMember = "PRODUCT_NAME";
            this.pURCHTBComboBox.FormattingEnabled = true;
            this.pURCHTBComboBox.Location = new System.Drawing.Point(24, 123);
            this.pURCHTBComboBox.Name = "pURCHTBComboBox";
            this.pURCHTBComboBox.Size = new System.Drawing.Size(300, 21);
            this.pURCHTBComboBox.TabIndex = 2;
            this.pURCHTBComboBox.ValueMember = "ITEM_Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEARCH PRODUCT by NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(489, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "VIEW PURCHASES";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(29, 39);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 37);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnALL);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1048, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 249);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TASKS";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(29, 170);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(112, 37);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "UPDATE ";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnALL
            // 
            this.btnALL.Location = new System.Drawing.Point(29, 110);
            this.btnALL.Name = "btnALL";
            this.btnALL.Size = new System.Drawing.Size(112, 37);
            this.btnALL.TabIndex = 6;
            this.btnALL.Text = "VIEW ALL";
            this.btnALL.UseVisualStyleBackColor = true;
            this.btnALL.Click += new System.EventHandler(this.btnALL_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(741, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 36);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(434, 124);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "PRODUCT NAME";
            // 
            // pURCHTBDataGridView
            // 
            this.pURCHTBDataGridView.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.pURCHTBDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pURCHTBDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.pURCHTBDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.pURCHTBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pURCHTBDataGridView.Location = new System.Drawing.Point(25, 188);
            this.pURCHTBDataGridView.Name = "pURCHTBDataGridView";
            this.pURCHTBDataGridView.Size = new System.Drawing.Size(958, 371);
            this.pURCHTBDataGridView.TabIndex = 1;
            this.pURCHTBDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pURCHTBDataGridView_CellContentClick);
            // 
            // pURCHTBBindingSource6
            // 
            this.pURCHTBBindingSource6.DataMember = "PURCHTB";
            this.pURCHTBBindingSource6.DataSource = this.pURCHASDataSet1;
            // 
            // pURCHTBBindingSource5
            // 
            this.pURCHTBBindingSource5.DataMember = "PURCHTB";
            this.pURCHTBBindingSource5.DataSource = this.pURCHASDataSet1;
            // 
            // pURCHTBBindingSource3
            // 
            this.pURCHTBBindingSource3.DataMember = "PURCHTB";
            this.pURCHTBBindingSource3.DataSource = this.pURCHASDataSet1;
            // 
            // pURCHTBBindingSource4
            // 
            this.pURCHTBBindingSource4.DataMember = "PURCHTB";
            this.pURCHTBBindingSource4.DataSource = this.pURCHASDataSet1;
            // 
            // VIEWPURCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1234, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pURCHTBComboBox);
            this.Controls.Add(this.pURCHTBDataGridView);
            this.Name = "VIEWPURCH";
            this.Text = "VIEWPURCH";
            this.Load += new System.EventHandler(this.VIEWPURCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHTBBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PURCHASDataSet1 pURCHASDataSet1;
        private System.Windows.Forms.BindingSource pURCHTBBindingSource;
        private PURCHASDataSet1TableAdapters.PURCHTBTableAdapter pURCHTBTableAdapter;
        private PURCHASDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource pURCHTBBindingSource1;
        private System.Windows.Forms.ComboBox pURCHTBComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnALL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource pURCHTBBindingSource2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView pURCHTBDataGridView;
        private System.Windows.Forms.BindingSource pURCHTBBindingSource3;
        private System.Windows.Forms.BindingSource pURCHTBBindingSource4;
        private System.Windows.Forms.BindingSource pURCHTBBindingSource5;      
        private System.Windows.Forms.BindingSource pURCHTBBindingSource6;
    }
}