namespace OtobusOtomasyon
{
    partial class BiletKesRaporuFormu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VeritabanimDataSet = new OtobusOtomasyon.VeritabanimDataSet();
            this.BiletlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BiletlerTableAdapter = new OtobusOtomasyon.VeritabanimDataSetTableAdapters.BiletlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VeritabanimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BiletlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BiletlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtobusOtomasyon.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1081, 265);
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
            // BiletKesRaporuFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BiletKesRaporuFormu";
            this.Text = "BiletKesRaporuFormu";
            this.Load += new System.EventHandler(this.BiletKesRaporuFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeritabanimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BiletlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BiletlerBindingSource;
        private VeritabanimDataSet VeritabanimDataSet;
        private VeritabanimDataSetTableAdapters.BiletlerTableAdapter BiletlerTableAdapter;
    }
}