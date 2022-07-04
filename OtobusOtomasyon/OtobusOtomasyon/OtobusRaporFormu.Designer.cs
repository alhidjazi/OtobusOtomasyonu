namespace OtobusOtomasyon
{
    partial class OtobusRaporFormu
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
            this.OtobuslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OtobuslerTableAdapter = new OtobusOtomasyon.VeritabanimDataSetTableAdapters.OtobuslerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VeritabanimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtobuslerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OtobuslerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtobusOtomasyon.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(666, 343);
            this.reportViewer1.TabIndex = 0;
            // 
            // VeritabanimDataSet
            // 
            this.VeritabanimDataSet.DataSetName = "VeritabanimDataSet";
            this.VeritabanimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OtobuslerBindingSource
            // 
            this.OtobuslerBindingSource.DataMember = "Otobusler";
            this.OtobuslerBindingSource.DataSource = this.VeritabanimDataSet;
            // 
            // OtobuslerTableAdapter
            // 
            this.OtobuslerTableAdapter.ClearBeforeFill = true;
            // 
            // OtobusRaporFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 367);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OtobusRaporFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtobusRaporFormu";
            this.Load += new System.EventHandler(this.OtobusRaporFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeritabanimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtobuslerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OtobuslerBindingSource;
        private VeritabanimDataSet VeritabanimDataSet;
        private VeritabanimDataSetTableAdapters.OtobuslerTableAdapter OtobuslerTableAdapter;
    }
}