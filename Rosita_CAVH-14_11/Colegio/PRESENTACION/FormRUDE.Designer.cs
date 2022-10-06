namespace Colegio.PRESENTACION
{
    partial class FormRUDE
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
            System.Windows.Forms.Label cOD_RUDELabel;
            System.Windows.Forms.Label nOMBRE_UELabel;
            System.Windows.Forms.Label cODIGO_SIELabel;
            System.Windows.Forms.Label cODIGO_PROCEDENCIALabel;
            System.Windows.Forms.Label dEPENDENCIA_UELabel;
            System.Windows.Forms.Label nOMBRE_UE_PROCEDENCIALabel;
            System.Windows.Forms.Label iD_ALUMNOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRUDE));
            this.cAVH2DataSet = new Colegio.CAVH3DataSet();
            this.rUDEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUDETableAdapter = new Colegio.CAVH3DataSetTableAdapters.RUDETableAdapter();
            this.tableAdapterManager = new Colegio.CAVH3DataSetTableAdapters.TableAdapterManager();
            this.rUDEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cOD_RUDETextBox = new System.Windows.Forms.TextBox();
            this.nOMBRE_UETextBox = new System.Windows.Forms.TextBox();
            this.cODIGO_SIETextBox = new System.Windows.Forms.TextBox();
            this.cODIGO_PROCEDENCIATextBox = new System.Windows.Forms.TextBox();
            this.dEPENDENCIA_UETextBox = new System.Windows.Forms.TextBox();
            this.nOMBRE_UE_PROCEDENCIATextBox = new System.Windows.Forms.TextBox();
            this.iD_ALUMNOTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            cOD_RUDELabel = new System.Windows.Forms.Label();
            nOMBRE_UELabel = new System.Windows.Forms.Label();
            cODIGO_SIELabel = new System.Windows.Forms.Label();
            cODIGO_PROCEDENCIALabel = new System.Windows.Forms.Label();
            dEPENDENCIA_UELabel = new System.Windows.Forms.Label();
            nOMBRE_UE_PROCEDENCIALabel = new System.Windows.Forms.Label();
            iD_ALUMNOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cAVH2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUDEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUDEBindingNavigator)).BeginInit();
            this.rUDEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cOD_RUDELabel
            // 
            cOD_RUDELabel.AutoSize = true;
            cOD_RUDELabel.Location = new System.Drawing.Point(79, 67);
            cOD_RUDELabel.Name = "cOD_RUDELabel";
            cOD_RUDELabel.Size = new System.Drawing.Size(67, 13);
            cOD_RUDELabel.TabIndex = 1;
            cOD_RUDELabel.Text = "COD RUDE:";
            // 
            // nOMBRE_UELabel
            // 
            nOMBRE_UELabel.AutoSize = true;
            nOMBRE_UELabel.Location = new System.Drawing.Point(79, 93);
            nOMBRE_UELabel.Name = "nOMBRE_UELabel";
            nOMBRE_UELabel.Size = new System.Drawing.Size(75, 13);
            nOMBRE_UELabel.TabIndex = 3;
            nOMBRE_UELabel.Text = "NOMBRE UE:";
            // 
            // cODIGO_SIELabel
            // 
            cODIGO_SIELabel.AutoSize = true;
            cODIGO_SIELabel.Location = new System.Drawing.Point(79, 119);
            cODIGO_SIELabel.Name = "cODIGO_SIELabel";
            cODIGO_SIELabel.Size = new System.Drawing.Size(72, 13);
            cODIGO_SIELabel.TabIndex = 5;
            cODIGO_SIELabel.Text = "CODIGO SIE:";
            // 
            // cODIGO_PROCEDENCIALabel
            // 
            cODIGO_PROCEDENCIALabel.AutoSize = true;
            cODIGO_PROCEDENCIALabel.Location = new System.Drawing.Point(79, 145);
            cODIGO_PROCEDENCIALabel.Name = "cODIGO_PROCEDENCIALabel";
            cODIGO_PROCEDENCIALabel.Size = new System.Drawing.Size(132, 13);
            cODIGO_PROCEDENCIALabel.TabIndex = 7;
            cODIGO_PROCEDENCIALabel.Text = "CODIGO PROCEDENCIA:";
            // 
            // dEPENDENCIA_UELabel
            // 
            dEPENDENCIA_UELabel.AutoSize = true;
            dEPENDENCIA_UELabel.Location = new System.Drawing.Point(79, 171);
            dEPENDENCIA_UELabel.Name = "dEPENDENCIA_UELabel";
            dEPENDENCIA_UELabel.Size = new System.Drawing.Size(105, 13);
            dEPENDENCIA_UELabel.TabIndex = 9;
            dEPENDENCIA_UELabel.Text = "DEPENDENCIA UE:";
            // 
            // nOMBRE_UE_PROCEDENCIALabel
            // 
            nOMBRE_UE_PROCEDENCIALabel.AutoSize = true;
            nOMBRE_UE_PROCEDENCIALabel.Location = new System.Drawing.Point(79, 197);
            nOMBRE_UE_PROCEDENCIALabel.Name = "nOMBRE_UE_PROCEDENCIALabel";
            nOMBRE_UE_PROCEDENCIALabel.Size = new System.Drawing.Size(155, 13);
            nOMBRE_UE_PROCEDENCIALabel.TabIndex = 11;
            nOMBRE_UE_PROCEDENCIALabel.Text = "NOMBRE UE PROCEDENCIA:";
            // 
            // iD_ALUMNOLabel
            // 
            iD_ALUMNOLabel.AutoSize = true;
            iD_ALUMNOLabel.Location = new System.Drawing.Point(79, 223);
            iD_ALUMNOLabel.Name = "iD_ALUMNOLabel";
            iD_ALUMNOLabel.Size = new System.Drawing.Size(70, 13);
            iD_ALUMNOLabel.TabIndex = 13;
            iD_ALUMNOLabel.Text = "ID ALUMNO:";
            // 
            // cAVH2DataSet
            // 
            this.cAVH2DataSet.DataSetName = "CAVH2DataSet";
            this.cAVH2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rUDEBindingSource
            // 
            this.rUDEBindingSource.DataMember = "RUDE";
            this.rUDEBindingSource.DataSource = this.cAVH2DataSet;
            // 
            // rUDETableAdapter
            // 
            this.rUDETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALUMNO_APODERADOTableAdapter = null;
            this.tableAdapterManager.ALUMNOTableAdapter = null;
            this.tableAdapterManager.APODERADOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOLETIN_TRIMESTRALTableAdapter = null;
            this.tableAdapterManager.CARGOTableAdapter = null;
            this.tableAdapterManager.CERTIFICADO_NACIMIENTOTableAdapter = null;
            this.tableAdapterManager.CURSOTableAdapter = null;
            this.tableAdapterManager.DICTATableAdapter = null;
            this.tableAdapterManager.DOCENTE_ESPECIALIDADTableAdapter = null;
            this.tableAdapterManager.DOCENTETableAdapter = null;
            this.tableAdapterManager.EMPLEADOTableAdapter = null;
            this.tableAdapterManager.ESPECIALIDADTableAdapter = null;
            this.tableAdapterManager.FOTOGRAFIATableAdapter = null;
            this.tableAdapterManager.GESTIONTableAdapter = null;
            this.tableAdapterManager.HORARIOTableAdapter = null;
            this.tableAdapterManager.INSCRIPCIONTableAdapter = null;
            this.tableAdapterManager.LIBRETATableAdapter = null;
            this.tableAdapterManager.LUGAR_NACIMIENTOTableAdapter = null;
            this.tableAdapterManager.MATERIA_CURSOTableAdapter = null;
            this.tableAdapterManager.MATERIATableAdapter = null;
            this.tableAdapterManager.NIVELTableAdapter = null;
            this.tableAdapterManager.NOTASTableAdapter = null;
            this.tableAdapterManager.PARALELOTableAdapter = null;
            this.tableAdapterManager.RUDETableAdapter = this.rUDETableAdapter;
            this.tableAdapterManager.SEGUROTableAdapter = null;
            this.tableAdapterManager.TIENETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Colegio.CAVH3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rUDEBindingNavigator
            // 
            this.rUDEBindingNavigator.AddNewItem = null;
            this.rUDEBindingNavigator.BindingSource = this.rUDEBindingSource;
            this.rUDEBindingNavigator.CountItem = null;
            this.rUDEBindingNavigator.DeleteItem = null;
            this.rUDEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton1});
            this.rUDEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rUDEBindingNavigator.MoveFirstItem = null;
            this.rUDEBindingNavigator.MoveLastItem = null;
            this.rUDEBindingNavigator.MoveNextItem = null;
            this.rUDEBindingNavigator.MovePreviousItem = null;
            this.rUDEBindingNavigator.Name = "rUDEBindingNavigator";
            this.rUDEBindingNavigator.PositionItem = null;
            this.rUDEBindingNavigator.Size = new System.Drawing.Size(634, 25);
            this.rUDEBindingNavigator.TabIndex = 0;
            this.rUDEBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Guardar datos";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Eliminar";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Agregar nuevo";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Colegio.Properties.Resources._1381811072_34608;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // cOD_RUDETextBox
            // 
            this.cOD_RUDETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rUDEBindingSource, "COD_RUDE", true));
            this.cOD_RUDETextBox.Location = new System.Drawing.Point(240, 64);
            this.cOD_RUDETextBox.Name = "cOD_RUDETextBox";
            this.cOD_RUDETextBox.Size = new System.Drawing.Size(100, 20);
            this.cOD_RUDETextBox.TabIndex = 2;
            // 
            // nOMBRE_UETextBox
            // 
            this.nOMBRE_UETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rUDEBindingSource, "NOMBRE_UE", true));
            this.nOMBRE_UETextBox.Location = new System.Drawing.Point(240, 90);
            this.nOMBRE_UETextBox.Name = "nOMBRE_UETextBox";
            this.nOMBRE_UETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMBRE_UETextBox.TabIndex = 4;
            // 
            // cODIGO_SIETextBox
            // 
            this.cODIGO_SIETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rUDEBindingSource, "CODIGO_SIE", true));
            this.cODIGO_SIETextBox.Location = new System.Drawing.Point(240, 116);
            this.cODIGO_SIETextBox.Name = "cODIGO_SIETextBox";
            this.cODIGO_SIETextBox.Size = new System.Drawing.Size(100, 20);
            this.cODIGO_SIETextBox.TabIndex = 6;
            // 
            // cODIGO_PROCEDENCIATextBox
            // 
            this.cODIGO_PROCEDENCIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rUDEBindingSource, "CODIGO_PROCEDENCIA", true));
            this.cODIGO_PROCEDENCIATextBox.Location = new System.Drawing.Point(240, 142);
            this.cODIGO_PROCEDENCIATextBox.Name = "cODIGO_PROCEDENCIATextBox";
            this.cODIGO_PROCEDENCIATextBox.Size = new System.Drawing.Size(100, 20);
            this.cODIGO_PROCEDENCIATextBox.TabIndex = 8;
            // 
            // dEPENDENCIA_UETextBox
            // 
            this.dEPENDENCIA_UETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rUDEBindingSource, "DEPENDENCIA_UE", true));
            this.dEPENDENCIA_UETextBox.Location = new System.Drawing.Point(240, 168);
            this.dEPENDENCIA_UETextBox.Name = "dEPENDENCIA_UETextBox";
            this.dEPENDENCIA_UETextBox.Size = new System.Drawing.Size(100, 20);
            this.dEPENDENCIA_UETextBox.TabIndex = 10;
            // 
            // nOMBRE_UE_PROCEDENCIATextBox
            // 
            this.nOMBRE_UE_PROCEDENCIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rUDEBindingSource, "NOMBRE_UE_PROCEDENCIA", true));
            this.nOMBRE_UE_PROCEDENCIATextBox.Location = new System.Drawing.Point(240, 194);
            this.nOMBRE_UE_PROCEDENCIATextBox.Name = "nOMBRE_UE_PROCEDENCIATextBox";
            this.nOMBRE_UE_PROCEDENCIATextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMBRE_UE_PROCEDENCIATextBox.TabIndex = 12;
            // 
            // iD_ALUMNOTextBox
            // 
            this.iD_ALUMNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rUDEBindingSource, "ID_ALUMNO", true));
            this.iD_ALUMNOTextBox.Location = new System.Drawing.Point(240, 220);
            this.iD_ALUMNOTextBox.Name = "iD_ALUMNOTextBox";
            this.iD_ALUMNOTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ALUMNOTextBox.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Image = global::Colegio.Properties.Resources._1381810697_22560;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(392, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 41);
            this.button3.TabIndex = 72;
            this.button3.Text = "Actualizar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormRUDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 431);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(cOD_RUDELabel);
            this.Controls.Add(this.cOD_RUDETextBox);
            this.Controls.Add(nOMBRE_UELabel);
            this.Controls.Add(this.nOMBRE_UETextBox);
            this.Controls.Add(cODIGO_SIELabel);
            this.Controls.Add(this.cODIGO_SIETextBox);
            this.Controls.Add(cODIGO_PROCEDENCIALabel);
            this.Controls.Add(this.cODIGO_PROCEDENCIATextBox);
            this.Controls.Add(dEPENDENCIA_UELabel);
            this.Controls.Add(this.dEPENDENCIA_UETextBox);
            this.Controls.Add(nOMBRE_UE_PROCEDENCIALabel);
            this.Controls.Add(this.nOMBRE_UE_PROCEDENCIATextBox);
            this.Controls.Add(iD_ALUMNOLabel);
            this.Controls.Add(this.iD_ALUMNOTextBox);
            this.Controls.Add(this.rUDEBindingNavigator);
            this.Name = "FormRUDE";
            this.Text = "FormRUDE";
            this.Load += new System.EventHandler(this.FormRUDE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAVH2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUDEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUDEBindingNavigator)).EndInit();
            this.rUDEBindingNavigator.ResumeLayout(false);
            this.rUDEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CAVH3DataSet cAVH2DataSet;
        private System.Windows.Forms.BindingSource rUDEBindingSource;
        private CAVH3DataSetTableAdapters.RUDETableAdapter rUDETableAdapter;
        private CAVH3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rUDEBindingNavigator;
        private System.Windows.Forms.TextBox cOD_RUDETextBox;
        private System.Windows.Forms.TextBox nOMBRE_UETextBox;
        private System.Windows.Forms.TextBox cODIGO_SIETextBox;
        private System.Windows.Forms.TextBox cODIGO_PROCEDENCIATextBox;
        private System.Windows.Forms.TextBox dEPENDENCIA_UETextBox;
        private System.Windows.Forms.TextBox nOMBRE_UE_PROCEDENCIATextBox;
        private System.Windows.Forms.TextBox iD_ALUMNOTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
    }
}