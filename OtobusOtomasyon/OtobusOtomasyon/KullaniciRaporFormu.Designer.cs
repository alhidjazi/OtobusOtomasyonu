﻿namespace OtobusOtomasyon
{
    partial class KullaniciRaporFormu
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
            this.YoneticilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.YoneticilerTableAdapter = new OtobusOtomasyon.VeritabanimDataSetTableAdapters.YoneticilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VeritabanimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YoneticilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.YoneticilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtobusOtomasyon.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(706, 328);
            this.reportViewer1.TabIndex = 0;
            // 
            // VeritabanimDataSet
            // 
            this.VeritabanimDataSet.DataSetName = "VeritabanimDataSet";
            this.VeritabanimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // YoneticilerBindingSource
            // 
            this.YoneticilerBindingSource.DataMember = "Yoneticiler";
            this.YoneticilerBindingSource.DataSource = this.VeritabanimDataSet;
            // 
            // YoneticilerTableAdapter
            // 
            this.YoneticilerTableAdapter.ClearBeforeFill = true;
            // 
            // KullaniciRaporFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 352);
            this.Controls.Add(this.reportViewer1);
            this.Name = "KullaniciRaporFormu";
            this.Text = "KullaniciRaporFormu";
            this.Load += new System.EventHandler(this.KullaniciRaporFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeritabanimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YoneticilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource YoneticilerBindingSource;
        private VeritabanimDataSet VeritabanimDataSet;
        private VeritabanimDataSetTableAdapters.YoneticilerTableAdapter YoneticilerTableAdapter;
    }
}