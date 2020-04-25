namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    partial class Viewcat
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
            this.label1 = new System.Windows.Forms.Label();
            this.pURCHASDataSet1 = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.TableAdapterManager();
            this.TASKS = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.cATEGORYTableAdapter = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.CATEGORYTableAdapter();
            this.cATEGORYDataGridView = new System.Windows.Forms.DataGridView();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            this.TASKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALL CATEGORIES";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.emloyeesTableAdapter = null;
            this.tableAdapterManager.PASSWORDTableAdapter = null;
            this.tableAdapterManager.PURCHTBTableAdapter = null;
            this.tableAdapterManager.SALESTableAdapter = null;
            this.tableAdapterManager.STOCKTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TASKS
            // 
            this.TASKS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TASKS.Controls.Add(this.btnupdate);
            this.TASKS.Controls.Add(this.btndelete);
            this.TASKS.Controls.Add(this.btnHome);
            this.TASKS.ForeColor = System.Drawing.Color.DarkBlue;
            this.TASKS.Location = new System.Drawing.Point(770, 93);
            this.TASKS.Margin = new System.Windows.Forms.Padding(2);
            this.TASKS.Name = "TASKS";
            this.TASKS.Padding = new System.Windows.Forms.Padding(2);
            this.TASKS.Size = new System.Drawing.Size(114, 197);
            this.TASKS.TabIndex = 3;
            this.TASKS.TabStop = false;
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnupdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(18, 135);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(78, 28);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(18, 84);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(78, 28);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(20, 38);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(78, 28);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // cATEGORYDataGridView
            // 
            this.cATEGORYDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cATEGORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cATEGORYDataGridView.Location = new System.Drawing.Point(71, 103);
            this.cATEGORYDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.cATEGORYDataGridView.Name = "cATEGORYDataGridView";
            this.cATEGORYDataGridView.ReadOnly = true;
            this.cATEGORYDataGridView.Size = new System.Drawing.Size(359, 187);
            this.cATEGORYDataGridView.TabIndex = 3;
            this.cATEGORYDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cATEGORYDataGridView_CellContentClick);
            this.cATEGORYDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cATEGORYDataGridView_RowHeaderMouseClick);
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(616, 103);
            this.txtnam.Multiline = true;
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(114, 37);
            this.txtnam.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "CATEGORY ID";
            // 
            // txtcid
            // 
            this.txtcid.Location = new System.Drawing.Point(616, 162);
            this.txtcid.Multiline = true;
            this.txtcid.Name = "txtcid";
            this.txtcid.ReadOnly = true;
            this.txtcid.Size = new System.Drawing.Size(114, 37);
            this.txtcid.TabIndex = 7;
            // 
            // Viewcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::MANZLEE_RETAIL_MANAGEMENT_SYSTEM.Properties.Resources.light_blue_green_abstract_image;
            this.ClientSize = new System.Drawing.Size(949, 349);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.cATEGORYDataGridView);
            this.Controls.Add(this.TASKS);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Viewcat";
            this.Text = "Viewcat";
            this.Load += new System.EventHandler(this.Viewcat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            this.TASKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private PURCHASDataSet1 pURCHASDataSet1;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private PURCHASDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox TASKS;
        private System.Windows.Forms.Button btnHome;
        private PURCHASDataSet1TableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private System.Windows.Forms.DataGridView cATEGORYDataGridView;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcid;
    }
}