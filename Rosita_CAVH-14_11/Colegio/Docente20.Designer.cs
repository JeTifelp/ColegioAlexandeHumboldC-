namespace Colegio
{
    partial class Docente20
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
            this.Docente200 = new Colegio.Docente200();
            this.DOCENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DOCENTETableAdapter = new Colegio.Docente200TableAdapters.DOCENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Docente200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DOCENTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Colegio.docente2000.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(615, 408);
            this.reportViewer1.TabIndex = 0;
            // 
            // Docente200
            // 
            this.Docente200.DataSetName = "Docente200";
            this.Docente200.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DOCENTEBindingSource
            // 
            this.DOCENTEBindingSource.DataMember = "DOCENTE";
            this.DOCENTEBindingSource.DataSource = this.Docente200;
            // 
            // DOCENTETableAdapter
            // 
            this.DOCENTETableAdapter.ClearBeforeFill = true;
            // 
            // Docente20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 408);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Docente20";
            this.Text = "Docente20";
            this.Load += new System.EventHandler(this.Docente20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Docente200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCENTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DOCENTEBindingSource;
        private Docente200 Docente200;
        private Docente200TableAdapters.DOCENTETableAdapter DOCENTETableAdapter;
    }
}