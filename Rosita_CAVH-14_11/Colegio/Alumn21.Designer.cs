namespace Colegio
{
    partial class Alumn21
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
            this.Alumnooo = new Colegio.Alumnooo();
            this.ALUMNOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ALUMNOTableAdapter = new Colegio.AlumnoooTableAdapters.ALUMNOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Alumnooo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALUMNOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ALUMNOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Colegio.Alumnooo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(435, 271);
            this.reportViewer1.TabIndex = 0;
            // 
            // Alumnooo
            // 
            this.Alumnooo.DataSetName = "Alumnooo";
            this.Alumnooo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ALUMNOBindingSource
            // 
            this.ALUMNOBindingSource.DataMember = "ALUMNO";
            this.ALUMNOBindingSource.DataSource = this.Alumnooo;
            // 
            // ALUMNOTableAdapter
            // 
            this.ALUMNOTableAdapter.ClearBeforeFill = true;
            // 
            // Alumn21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 271);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Alumn21";
            this.Text = "generarListadoDeAlumnos";
            this.Load += new System.EventHandler(this.Alumn21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Alumnooo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALUMNOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ALUMNOBindingSource;
        private Alumnooo Alumnooo;
        private AlumnoooTableAdapters.ALUMNOTableAdapter ALUMNOTableAdapter;
    }
}