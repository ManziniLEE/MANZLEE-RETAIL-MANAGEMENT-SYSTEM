namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    partial class REPORT
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REPORT));
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHASDataSet1 = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sALESBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sALESDataGridView = new System.Windows.Forms.DataGridView();
            this.sALESBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnall = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnday = new System.Windows.Forms.Button();
            this.btnmonth = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnpdf = new System.Windows.Forms.Button();
            this.sTOCKTableAdapter = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.STOCKTableAdapter();
            this.tableAdapterManager = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.TableAdapterManager();
            this.sALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALESTableAdapter = new MANZLEE_RETAIL_MANAGEMENT_SYSTEM.PURCHASDataSet1TableAdapters.SALESTableAdapter();
            this.sALESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sALESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource2)).BeginInit();
            this.SuspendLayout();
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
            // chart1
            // 
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.sALESBindingSource3;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(808, 170);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderColor = System.Drawing.Color.Green;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SALES";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(440, 348);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "Sales Chart";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // sALESBindingSource3
            // 
            this.sALESBindingSource3.DataMember = "SALES";
            this.sALESBindingSource3.DataSource = this.pURCHASDataSet1;
            // 
            // sALESDataGridView
            // 
            this.sALESDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.sALESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sALESDataGridView.Location = new System.Drawing.Point(13, 155);
            this.sALESDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sALESDataGridView.Name = "sALESDataGridView";
            this.sALESDataGridView.Size = new System.Drawing.Size(787, 416);
            this.sALESDataGridView.TabIndex = 4;
            // 
            // sALESBindingSource4
            // 
            this.sALESBindingSource4.DataMember = "SALES";
            this.sALESBindingSource4.DataSource = this.pURCHASDataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1386, 536);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1528, 79);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(536, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "SALES REPORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 590);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "TOTAL CURRENT SALES";
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltotal.Location = new System.Drawing.Point(328, 574);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(170, 39);
            this.lbltotal.TabIndex = 10;
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(6, 153);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(130, 38);
            this.btnall.TabIndex = 11;
            this.btnall.Text = "VIEW ALL";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(6, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "HOME";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 581);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "VIEW TOTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnday
            // 
            this.btnday.Location = new System.Drawing.Point(6, 109);
            this.btnday.Name = "btnday";
            this.btnday.Size = new System.Drawing.Size(130, 38);
            this.btnday.TabIndex = 14;
            this.btnday.Text = "VIEW TODAY\'S SALES";
            this.btnday.UseVisualStyleBackColor = true;
            this.btnday.Click += new System.EventHandler(this.btnday_Click);
            // 
            // btnmonth
            // 
            this.btnmonth.Location = new System.Drawing.Point(6, 65);
            this.btnmonth.Name = "btnmonth";
            this.btnmonth.Size = new System.Drawing.Size(130, 38);
            this.btnmonth.TabIndex = 15;
            this.btnmonth.Text = "VIEW SALES FOR THE MONTH";
            this.btnmonth.UseVisualStyleBackColor = true;
            this.btnmonth.Click += new System.EventHandler(this.btnmonth_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1048, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(142, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 38);
            this.button4.TabIndex = 17;
            this.button4.Text = "LOAD CHART";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnmonth);
            this.groupBox1.Controls.Add(this.btnall);
            this.groupBox1.Controls.Add(this.btnday);
            this.groupBox1.Location = new System.Drawing.Point(818, 524);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 200);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "19 May 2016";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(142, 71);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 16;
            this.dateTimePicker3.Value = new System.DateTime(2016, 5, 19, 21, 12, 38, 0);
            // 
            // btnpdf
            // 
            this.btnpdf.Location = new System.Drawing.Point(648, 581);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(130, 38);
            this.btnpdf.TabIndex = 18;
            this.btnpdf.Text = "EXPORT TXT";
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
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
            // sALESBindingSource
            // 
            this.sALESBindingSource.DataMember = "SALES";
            this.sALESBindingSource.DataSource = this.pURCHASDataSet1;
            // 
            // sALESTableAdapter
            // 
            this.sALESTableAdapter.ClearBeforeFill = true;
            // 
            // sALESBindingSource1
            // 
            this.sALESBindingSource1.DataMember = "SALES";
            this.sALESBindingSource1.DataSource = this.pURCHASDataSet1;
            // 
            // sALESBindingSource2
            // 
            this.sALESBindingSource2.DataMember = "SALES";
            this.sALESBindingSource2.DataSource = this.pURCHASDataSet1;
            // 
            // REPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::MANZLEE_RETAIL_MANAGEMENT_SYSTEM.Properties.Resources._1048265__vista_wallpapers_wallpaper_blue_backround_system_background_software_operating_p;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 736);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sALESDataGridView);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "REPORT";
            this.Text = "REPORT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.REPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PURCHASDataSet1 pURCHASDataSet1;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private PURCHASDataSet1TableAdapters.STOCKTableAdapter sTOCKTableAdapter;
        private PURCHASDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sALESBindingSource;
        private PURCHASDataSet1TableAdapters.SALESTableAdapter sALESTableAdapter;
        private System.Windows.Forms.BindingSource sALESBindingSource1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView sALESDataGridView;
        private System.Windows.Forms.BindingSource sALESBindingSource2;
        private System.Windows.Forms.BindingSource sALESBindingSource3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnday;
        private System.Windows.Forms.Button btnmonth;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.BindingSource sALESBindingSource4;
    }
}