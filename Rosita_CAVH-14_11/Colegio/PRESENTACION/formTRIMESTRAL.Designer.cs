namespace Colegio.PRESENTACION
{
    partial class formTRIMESTRAL
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
            System.Windows.Forms.Label iD_TRIMESTRELabel;
            System.Windows.Forms.Label nOMBRE_TRIMESTRELabel;
            System.Windows.Forms.Label iD_ALUMNOLabel;
            System.Windows.Forms.Label cURSOLabel;
            System.Windows.Forms.Label mATERIALabel;
            System.Windows.Forms.Label pUNTAJE_CONOCIMIENTOLabel;
            System.Windows.Forms.Label pUNTAJE_DPSLabel;
            System.Windows.Forms.Label pUNTAJE_TRIMESTRELabel;
            System.Windows.Forms.Label iD_LIBRETALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTRIMESTRAL));
            this.cAVH3DataSet = new Colegio.CAVH3DataSet();
            this.bOLETIN_TRIMESTRALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOLETIN_TRIMESTRALTableAdapter = new Colegio.CAVH3DataSetTableAdapters.BOLETIN_TRIMESTRALTableAdapter();
            this.tableAdapterManager = new Colegio.CAVH3DataSetTableAdapters.TableAdapterManager();
            this.bOLETIN_TRIMESTRALBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bOLETIN_TRIMESTRALBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_TRIMESTRETextBox = new System.Windows.Forms.TextBox();
            this.nOMBRE_TRIMESTRETextBox = new System.Windows.Forms.TextBox();
            this.iD_ALUMNOTextBox = new System.Windows.Forms.TextBox();
            this.cURSOTextBox = new System.Windows.Forms.TextBox();
            this.mATERIATextBox = new System.Windows.Forms.TextBox();
            this.pUNTAJE_CONOCIMIENTOTextBox = new System.Windows.Forms.TextBox();
            this.pUNTAJE_DPSTextBox = new System.Windows.Forms.TextBox();
            this.pUNTAJE_TRIMESTRETextBox = new System.Windows.Forms.TextBox();
            this.iD_LIBRETATextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            iD_TRIMESTRELabel = new System.Windows.Forms.Label();
            nOMBRE_TRIMESTRELabel = new System.Windows.Forms.Label();
            iD_ALUMNOLabel = new System.Windows.Forms.Label();
            cURSOLabel = new System.Windows.Forms.Label();
            mATERIALabel = new System.Windows.Forms.Label();
            pUNTAJE_CONOCIMIENTOLabel = new System.Windows.Forms.Label();
            pUNTAJE_DPSLabel = new System.Windows.Forms.Label();
            pUNTAJE_TRIMESTRELabel = new System.Windows.Forms.Label();
            iD_LIBRETALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cAVH3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLETIN_TRIMESTRALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLETIN_TRIMESTRALBindingNavigator)).BeginInit();
            this.bOLETIN_TRIMESTRALBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_TRIMESTRELabel
            // 
            iD_TRIMESTRELabel.AutoSize = true;
            iD_TRIMESTRELabel.Location = new System.Drawing.Point(162, 57);
            iD_TRIMESTRELabel.Name = "iD_TRIMESTRELabel";
            iD_TRIMESTRELabel.Size = new System.Drawing.Size(87, 13);
            iD_TRIMESTRELabel.TabIndex = 1;
            iD_TRIMESTRELabel.Text = "ID TRIMESTRE:";
            // 
            // nOMBRE_TRIMESTRELabel
            // 
            nOMBRE_TRIMESTRELabel.AutoSize = true;
            nOMBRE_TRIMESTRELabel.Location = new System.Drawing.Point(162, 83);
            nOMBRE_TRIMESTRELabel.Name = "nOMBRE_TRIMESTRELabel";
            nOMBRE_TRIMESTRELabel.Size = new System.Drawing.Size(123, 13);
            nOMBRE_TRIMESTRELabel.TabIndex = 3;
            nOMBRE_TRIMESTRELabel.Text = "NOMBRE TRIMESTRE:";
            // 
            // iD_ALUMNOLabel
            // 
            iD_ALUMNOLabel.AutoSize = true;
            iD_ALUMNOLabel.Location = new System.Drawing.Point(162, 109);
            iD_ALUMNOLabel.Name = "iD_ALUMNOLabel";
            iD_ALUMNOLabel.Size = new System.Drawing.Size(70, 13);
            iD_ALUMNOLabel.TabIndex = 5;
            iD_ALUMNOLabel.Text = "ID ALUMNO:";
            // 
            // cURSOLabel
            // 
            cURSOLabel.AutoSize = true;
            cURSOLabel.Location = new System.Drawing.Point(162, 135);
            cURSOLabel.Name = "cURSOLabel";
            cURSOLabel.Size = new System.Drawing.Size(48, 13);
            cURSOLabel.TabIndex = 7;
            cURSOLabel.Text = "CURSO:";
            // 
            // mATERIALabel
            // 
            mATERIALabel.AutoSize = true;
            mATERIALabel.Location = new System.Drawing.Point(162, 161);
            mATERIALabel.Name = "mATERIALabel";
            mATERIALabel.Size = new System.Drawing.Size(58, 13);
            mATERIALabel.TabIndex = 9;
            mATERIALabel.Text = "MATERIA:";
            // 
            // pUNTAJE_CONOCIMIENTOLabel
            // 
            pUNTAJE_CONOCIMIENTOLabel.AutoSize = true;
            pUNTAJE_CONOCIMIENTOLabel.Location = new System.Drawing.Point(162, 187);
            pUNTAJE_CONOCIMIENTOLabel.Name = "pUNTAJE_CONOCIMIENTOLabel";
            pUNTAJE_CONOCIMIENTOLabel.Size = new System.Drawing.Size(145, 13);
            pUNTAJE_CONOCIMIENTOLabel.TabIndex = 11;
            pUNTAJE_CONOCIMIENTOLabel.Text = "PUNTAJE CONOCIMIENTO:";
            // 
            // pUNTAJE_DPSLabel
            // 
            pUNTAJE_DPSLabel.AutoSize = true;
            pUNTAJE_DPSLabel.Location = new System.Drawing.Point(162, 213);
            pUNTAJE_DPSLabel.Name = "pUNTAJE_DPSLabel";
            pUNTAJE_DPSLabel.Size = new System.Drawing.Size(84, 13);
            pUNTAJE_DPSLabel.TabIndex = 13;
            pUNTAJE_DPSLabel.Text = "PUNTAJE DPS:";
            // 
            // pUNTAJE_TRIMESTRELabel
            // 
            pUNTAJE_TRIMESTRELabel.AutoSize = true;
            pUNTAJE_TRIMESTRELabel.Location = new System.Drawing.Point(162, 239);
            pUNTAJE_TRIMESTRELabel.Name = "pUNTAJE_TRIMESTRELabel";
            pUNTAJE_TRIMESTRELabel.Size = new System.Drawing.Size(125, 13);
            pUNTAJE_TRIMESTRELabel.TabIndex = 15;
            pUNTAJE_TRIMESTRELabel.Text = "PUNTAJE TRIMESTRE:";
            // 
            // iD_LIBRETALabel
            // 
            iD_LIBRETALabel.AutoSize = true;
            iD_LIBRETALabel.Location = new System.Drawing.Point(162, 265);
            iD_LIBRETALabel.Name = "iD_LIBRETALabel";
            iD_LIBRETALabel.Size = new System.Drawing.Size(69, 13);
            iD_LIBRETALabel.TabIndex = 17;
            iD_LIBRETALabel.Text = "ID LIBRETA:";
            // 
            // cAVH3DataSet
            // 
            this.cAVH3DataSet.DataSetName = "CAVH3DataSet";
            this.cAVH3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOLETIN_TRIMESTRALBindingSource
            // 
            this.bOLETIN_TRIMESTRALBindingSource.DataMember = "BOLETIN_TRIMESTRAL";
            this.bOLETIN_TRIMESTRALBindingSource.DataSource = this.cAVH3DataSet;
            // 
            // bOLETIN_TRIMESTRALTableAdapter
            // 
            this.bOLETIN_TRIMESTRALTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALUMNO_APODERADOTableAdapter = null;
            this.tableAdapterManager.ALUMNOTableAdapter = null;
            this.tableAdapterManager.APODERADOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOLETIN_TRIMESTRALTableAdapter = this.bOLETIN_TRIMESTRALTableAdapter;
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
            this.tableAdapterManager.RUDETableAdapter = null;
            this.tableAdapterManager.SEGUROTableAdapter = null;
            this.tableAdapterManager.TIENETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Colegio.CAVH3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bOLETIN_TRIMESTRALBindingNavigator
            // 
            this.bOLETIN_TRIMESTRALBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bOLETIN_TRIMESTRALBindingNavigator.BindingSource = this.bOLETIN_TRIMESTRALBindingSource;
            this.bOLETIN_TRIMESTRALBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bOLETIN_TRIMESTRALBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bOLETIN_TRIMESTRALBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bOLETIN_TRIMESTRALBindingNavigatorSaveItem});
            this.bOLETIN_TRIMESTRALBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bOLETIN_TRIMESTRALBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bOLETIN_TRIMESTRALBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bOLETIN_TRIMESTRALBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bOLETIN_TRIMESTRALBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bOLETIN_TRIMESTRALBindingNavigator.Name = "bOLETIN_TRIMESTRALBindingNavigator";
            this.bOLETIN_TRIMESTRALBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bOLETIN_TRIMESTRALBindingNavigator.Size = new System.Drawing.Size(554, 25);
            this.bOLETIN_TRIMESTRALBindingNavigator.TabIndex = 0;
            this.bOLETIN_TRIMESTRALBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bOLETIN_TRIMESTRALBindingNavigatorSaveItem
            // 
            this.bOLETIN_TRIMESTRALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bOLETIN_TRIMESTRALBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bOLETIN_TRIMESTRALBindingNavigatorSaveItem.Image")));
            this.bOLETIN_TRIMESTRALBindingNavigatorSaveItem.Name = "bOLETIN_TRIMESTRALBindingNavigatorSaveItem";
            this.bOLETIN_TRIMESTRALBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bOLETIN_TRIMESTRALBindingNavigatorSaveItem.Text = "Guardar datos";
            this.bOLETIN_TRIMESTRALBindingNavigatorSaveItem.Click += new System.EventHandler(this.bOLETIN_TRIMESTRALBindingNavigatorSaveItem_Click);
            // 
            // iD_TRIMESTRETextBox
            // 
            this.iD_TRIMESTRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOLETIN_TRIMESTRALBindingSource, "ID_TRIMESTRE", true));
            this.iD_TRIMESTRETextBox.Location = new System.Drawing.Point(313, 54);
            this.iD_TRIMESTRETextBox.Name = "iD_TRIMESTRETextBox";
            this.iD_TRIMESTRETextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_TRIMESTRETextBox.TabIndex = 2;
            // 
            // nOMBRE_TRIMESTRETextBox
            // 
            this.nOMBRE_TRIMESTRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOLETIN_TRIMESTRALBindingSource, "NOMBRE_TRIMESTRE", true));
            this.nOMBRE_TRIMESTRETextBox.Location = new System.Drawing.Point(313, 80);
            this.nOMBRE_TRIMESTRETextBox.Name = "nOMBRE_TRIMESTRETextBox";
            this.nOMBRE_TRIMESTRETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMBRE_TRIMESTRETextBox.TabIndex = 4;
            // 
            // iD_ALUMNOTextBox
            // 
            this.iD_ALUMNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOLETIN_TRIMESTRALBindingSource, "ID_ALUMNO", true));
            this.iD_ALUMNOTextBox.Location = new System.Drawing.Point(313, 106);
            this.iD_ALUMNOTextBox.Name = "iD_ALUMNOTextBox";
            this.iD_ALUMNOTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ALUMNOTextBox.TabIndex = 6;
            // 
            // cURSOTextBox
            // 
            this.cURSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOLETIN_TRIMESTRALBindingSource, "CURSO", true));
            this.cURSOTextBox.Location = new System.Drawing.Point(313, 132);
            this.cURSOTextBox.Name = "cURSOTextBox";
            this.cURSOTextBox.Size = new System.Drawing.Size(100, 20);
            this.cURSOTextBox.TabIndex = 8;
            // 
            // mATERIATextBox
            // 
            this.mATERIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOLETIN_TRIMESTRALBindingSource, "MATERIA", true));
            this.mATERIATextBox.Location = new System.Drawing.Point(313, 158);
            this.mATERIATextBox.Name = "mATERIATextBox";
            this.mATERIATextBox.Size = new System.Drawing.Size(100, 20);
            this.mATERIATextBox.TabIndex = 10;
            // 
            // pUNTAJE_CONOCIMIENTOTextBox
            // 
            this.pUNTAJE_CONOCIMIENTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOLETIN_TRIMESTRALBindingSource, "PUNTAJE_CONOCIMIENTO", true));
            this.pUNTAJE_CONOCIMIENTOTextBox.Location = new System.Drawing.Point(313, 184);
            this.pUNTAJE_CONOCIMIENTOTextBox.Name = "pUNTAJE_CONOCIMIENTOTextBox";
            this.pUNTAJE_CONOCIMIENTOTextBox.Size = new System.Drawing.Size(100, 20);
            this.pUNTAJE_CONOCIMIENTOTextBox.TabIndex = 12;
            // 
            // pUNTAJE_DPSTextBox
            // 
            this.pUNTAJE_DPSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOLETIN_TRIMESTRALBindingSource, "PUNTAJE_DPS", true));
            this.pUNTAJE_DPSTextBox.Location = new System.Drawing.Point(313, 210);
            this.pUNTAJE_DPSTextBox.Name = "pUNTAJE_DPSTextBox";
            this.pUNTAJE_DPSTextBox.Size = new System.Drawing.Size(100, 20);
            this.pUNTAJE_DPSTextBox.TabIndex = 14;
            // 
            // pUNTAJE_TRIMESTRETextBox
            // 
            this.pUNTAJE_TRIMESTRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOLETIN_TRIMESTRALBindingSource, "PUNTAJE_TRIMESTRE", true));
            this.pUNTAJE_TRIMESTRETextBox.Location = new System.Drawing.Point(313, 236);
            this.pUNTAJE_TRIMESTRETextBox.Name = "pUNTAJE_TRIMESTRETextBox";
            this.pUNTAJE_TRIMESTRETextBox.Size = new System.Drawing.Size(100, 20);
            this.pUNTAJE_TRIMESTRETextBox.TabIndex = 16;
            // 
            // iD_LIBRETATextBox
            // 
            this.iD_LIBRETATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOLETIN_TRIMESTRALBindingSource, "ID_LIBRETA", true));
            this.iD_LIBRETATextBox.Location = new System.Drawing.Point(313, 262);
            this.iD_LIBRETATextBox.Name = "iD_LIBRETATextBox";
            this.iD_LIBRETATextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_LIBRETATextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "PUNTAJE CONOCIMIENTO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formTRIMESTRAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_TRIMESTRELabel);
            this.Controls.Add(this.iD_TRIMESTRETextBox);
            this.Controls.Add(nOMBRE_TRIMESTRELabel);
            this.Controls.Add(this.nOMBRE_TRIMESTRETextBox);
            this.Controls.Add(iD_ALUMNOLabel);
            this.Controls.Add(this.iD_ALUMNOTextBox);
            this.Controls.Add(cURSOLabel);
            this.Controls.Add(this.cURSOTextBox);
            this.Controls.Add(mATERIALabel);
            this.Controls.Add(this.mATERIATextBox);
            this.Controls.Add(pUNTAJE_CONOCIMIENTOLabel);
            this.Controls.Add(this.pUNTAJE_CONOCIMIENTOTextBox);
            this.Controls.Add(pUNTAJE_DPSLabel);
            this.Controls.Add(this.pUNTAJE_DPSTextBox);
            this.Controls.Add(pUNTAJE_TRIMESTRELabel);
            this.Controls.Add(this.pUNTAJE_TRIMESTRETextBox);
            this.Controls.Add(iD_LIBRETALabel);
            this.Controls.Add(this.iD_LIBRETATextBox);
            this.Controls.Add(this.bOLETIN_TRIMESTRALBindingNavigator);
            this.Name = "formTRIMESTRAL";
            this.Text = "formTRIMESTRAL";
            this.Load += new System.EventHandler(this.formTRIMESTRAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAVH3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLETIN_TRIMESTRALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLETIN_TRIMESTRALBindingNavigator)).EndInit();
            this.bOLETIN_TRIMESTRALBindingNavigator.ResumeLayout(false);
            this.bOLETIN_TRIMESTRALBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CAVH3DataSet cAVH3DataSet;
        private System.Windows.Forms.BindingSource bOLETIN_TRIMESTRALBindingSource;
        private CAVH3DataSetTableAdapters.BOLETIN_TRIMESTRALTableAdapter bOLETIN_TRIMESTRALTableAdapter;
        private CAVH3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bOLETIN_TRIMESTRALBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bOLETIN_TRIMESTRALBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_TRIMESTRETextBox;
        private System.Windows.Forms.TextBox nOMBRE_TRIMESTRETextBox;
        private System.Windows.Forms.TextBox iD_ALUMNOTextBox;
        private System.Windows.Forms.TextBox cURSOTextBox;
        private System.Windows.Forms.TextBox mATERIATextBox;
        private System.Windows.Forms.TextBox pUNTAJE_CONOCIMIENTOTextBox;
        private System.Windows.Forms.TextBox pUNTAJE_DPSTextBox;
        private System.Windows.Forms.TextBox pUNTAJE_TRIMESTRETextBox;
        private System.Windows.Forms.TextBox iD_LIBRETATextBox;
        private System.Windows.Forms.Button button1;
    }
}