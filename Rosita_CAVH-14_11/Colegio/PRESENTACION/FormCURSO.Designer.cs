namespace Colegio.PRESENTACION
{
    partial class FormCURSO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCURSO));
            System.Windows.Forms.Label iD_CURSOLabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label iD_NIVELLabel;
            this.cAVH3DataSet = new Colegio.CAVH3DataSet();
            this.cURSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cURSOTableAdapter = new Colegio.CAVH3DataSetTableAdapters.CURSOTableAdapter();
            this.tableAdapterManager = new Colegio.CAVH3DataSetTableAdapters.TableAdapterManager();
            this.cURSOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cURSOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CURSOTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.iD_NIVELTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            iD_CURSOLabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            iD_NIVELLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cAVH3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOBindingNavigator)).BeginInit();
            this.cURSOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cAVH3DataSet
            // 
            this.cAVH3DataSet.DataSetName = "CAVH3DataSet";
            this.cAVH3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cURSOBindingSource
            // 
            this.cURSOBindingSource.DataMember = "CURSO";
            this.cURSOBindingSource.DataSource = this.cAVH3DataSet;
            // 
            // cURSOTableAdapter
            // 
            this.cURSOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CURSOTableAdapter = this.cURSOTableAdapter;
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
            // cURSOBindingNavigator
            // 
            this.cURSOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cURSOBindingNavigator.BindingSource = this.cURSOBindingSource;
            this.cURSOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cURSOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cURSOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cURSOBindingNavigatorSaveItem});
            this.cURSOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cURSOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cURSOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cURSOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cURSOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cURSOBindingNavigator.Name = "cURSOBindingNavigator";
            this.cURSOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cURSOBindingNavigator.Size = new System.Drawing.Size(476, 25);
            this.cURSOBindingNavigator.TabIndex = 0;
            this.cURSOBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // cURSOBindingNavigatorSaveItem
            // 
            this.cURSOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cURSOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cURSOBindingNavigatorSaveItem.Image")));
            this.cURSOBindingNavigatorSaveItem.Name = "cURSOBindingNavigatorSaveItem";
            this.cURSOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cURSOBindingNavigatorSaveItem.Text = "Guardar datos";
            this.cURSOBindingNavigatorSaveItem.Click += new System.EventHandler(this.cURSOBindingNavigatorSaveItem_Click);
            // 
            // iD_CURSOLabel
            // 
            iD_CURSOLabel.AutoSize = true;
            iD_CURSOLabel.Location = new System.Drawing.Point(147, 42);
            iD_CURSOLabel.Name = "iD_CURSOLabel";
            iD_CURSOLabel.Size = new System.Drawing.Size(62, 13);
            iD_CURSOLabel.TabIndex = 1;
            iD_CURSOLabel.Text = "ID CURSO:";
            // 
            // iD_CURSOTextBox
            // 
            this.iD_CURSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cURSOBindingSource, "ID_CURSO", true));
            this.iD_CURSOTextBox.Location = new System.Drawing.Point(215, 39);
            this.iD_CURSOTextBox.Name = "iD_CURSOTextBox";
            this.iD_CURSOTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_CURSOTextBox.TabIndex = 2;
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(147, 68);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(57, 13);
            nOMBRELabel.TabIndex = 3;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cURSOBindingSource, "NOMBRE", true));
            this.nOMBRETextBox.Location = new System.Drawing.Point(215, 65);
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMBRETextBox.TabIndex = 4;
            // 
            // iD_NIVELLabel
            // 
            iD_NIVELLabel.AutoSize = true;
            iD_NIVELLabel.Location = new System.Drawing.Point(147, 94);
            iD_NIVELLabel.Name = "iD_NIVELLabel";
            iD_NIVELLabel.Size = new System.Drawing.Size(55, 13);
            iD_NIVELLabel.TabIndex = 5;
            iD_NIVELLabel.Text = "ID NIVEL:";
            // 
            // iD_NIVELTextBox
            // 
            this.iD_NIVELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cURSOBindingSource, "ID_NIVEL", true));
            this.iD_NIVELTextBox.Location = new System.Drawing.Point(215, 91);
            this.iD_NIVELTextBox.Name = "iD_NIVELTextBox";
            this.iD_NIVELTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_NIVELTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(407, 184);
            this.dataGridView1.TabIndex = 8;
            // 
            // FormCURSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 364);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_CURSOLabel);
            this.Controls.Add(this.iD_CURSOTextBox);
            this.Controls.Add(nOMBRELabel);
            this.Controls.Add(this.nOMBRETextBox);
            this.Controls.Add(iD_NIVELLabel);
            this.Controls.Add(this.iD_NIVELTextBox);
            this.Controls.Add(this.cURSOBindingNavigator);
            this.Name = "FormCURSO";
            this.Text = "FormCURSO";
            this.Load += new System.EventHandler(this.FormCURSO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAVH3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOBindingNavigator)).EndInit();
            this.cURSOBindingNavigator.ResumeLayout(false);
            this.cURSOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CAVH3DataSet cAVH3DataSet;
        private System.Windows.Forms.BindingSource cURSOBindingSource;
        private CAVH3DataSetTableAdapters.CURSOTableAdapter cURSOTableAdapter;
        private CAVH3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cURSOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cURSOBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CURSOTextBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox iD_NIVELTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}