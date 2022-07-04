namespace OtobusOtomasyon
{
    partial class BiletRaporFormu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VeritabanimDataSet = new OtobusOtomasyon.VeritabanimDataSet();
            this.BiletlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BiletlerTableAdapter = new OtobusOtomasyon.VeritabanimDataSetTableAdapters.BiletlerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtseferidara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.VeritabanimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BiletlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.BiletlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtobusOtomasyon.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(905, 434);
            this.reportViewer1.TabIndex = 0;
            // 
            // VeritabanimDataSet
            // 
            this.VeritabanimDataSet.DataSetName = "VeritabanimDataSet";
            this.VeritabanimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BiletlerBindingSource
            // 
            this.BiletlerBindingSource.DataMember = "Biletler";
            this.BiletlerBindingSource.DataSource = this.VeritabanimDataSet;
            // 
            // BiletlerTableAdapter
            // 
            this.BiletlerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(299, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Filterle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(111, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sefer ID";
            // 
            // txtseferidara
            // 
            this.txtseferidara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtseferidara.Location = new System.Drawing.Point(193, 458);
            this.txtseferidara.Name = "txtseferidara";
            this.txtseferidara.Size = new System.Drawing.Size(100, 29);
            this.txtseferidara.TabIndex = 3;
            // 
            // BiletRaporFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 492);
            this.Controls.Add(this.txtseferidara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BiletRaporFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiletRaporFormu";
            this.Load += new System.EventHandler(this.BiletRaporFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeritabanimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BiletlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BiletlerBindingSource;
        private VeritabanimDataSet VeritabanimDataSet;
        private VeritabanimDataSetTableAdapters.BiletlerTableAdapter BiletlerTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtseferidara;
    }
}