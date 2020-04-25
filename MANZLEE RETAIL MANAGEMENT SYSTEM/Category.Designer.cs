namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    partial class Category
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
            this.btnRese = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCatnam = new System.Windows.Forms.TextBox();
            this.pURCHASDataSet1 = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.TableAdapterManager();
            this.dataGridViewcat = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRese
            // 
            this.btnRese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRese.ForeColor = System.Drawing.Color.Black;
            this.btnRese.Location = new System.Drawing.Point(289, 332);
            this.btnRese.Name = "btnRese";
            this.btnRese.Size = new System.Drawing.Size(75, 23);
            this.btnRese.TabIndex = 0;
            this.btnRese.Text = "RESET";
            this.btnRese.UseVisualStyleBackColor = true;
            this.btnRese.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER CATEGORY";
            // 
            // txtCatid
            // 
            this.txtCatid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCatid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCatid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatid.Location = new System.Drawing.Point(264, 98);
            this.txtCatid.MaxLength = 4;
            this.txtCatid.Multiline = true;
            this.txtCatid.Name = "txtCatid";
            this.txtCatid.Size = new System.Drawing.Size(100, 32);
            this.txtCatid.TabIndex = 2;
            this.txtCatid.TextChanged += new System.EventHandler(this.txtCatid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CATEGORY ID";
            // 
            // btnInser
            // 
            this.btnInser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInser.ForeColor = System.Drawing.Color.Black;
            this.btnInser.Location = new System.Drawing.Point(172, 332);
            this.btnInser.Name = "btnInser";
            this.btnInser.Size = new System.Drawing.Size(75, 23);
            this.btnInser.TabIndex = 4;
            this.btnInser.Text = "INSERT";
            this.btnInser.UseVisualStyleBackColor = true;
            this.btnInser.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CATEGORY NAME";
            // 
            // txtCatnam
            // 
            this.txtCatnam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCatnam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txtCatnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatnam.Location = new System.Drawing.Point(264, 178);
            this.txtCatnam.Multiline = true;
            this.txtCatnam.Name = "txtCatnam";
            this.txtCatnam.Size = new System.Drawing.Size(155, 34);
            this.txtCatnam.TabIndex = 5;
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
            // dataGridViewcat
            // 
            this.dataGridViewcat.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcat.Location = new System.Drawing.Point(533, 62);
            this.dataGridViewcat.Name = "dataGridViewcat";
            this.dataGridViewcat.Size = new System.Drawing.Size(345, 293);
            this.dataGridViewcat.TabIndex = 8;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(418, 332);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(916, 377);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dataGridViewcat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCatnam);
            this.Controls.Add(this.btnInser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCatid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRese);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCatnam;
        private PURCHASDataSet1 pURCHASDataSet1;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private PURCHASDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridViewcat;
        private System.Windows.Forms.Button btnHome;
    }
}