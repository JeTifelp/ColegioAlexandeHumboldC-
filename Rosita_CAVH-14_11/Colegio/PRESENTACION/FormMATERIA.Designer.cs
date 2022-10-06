namespace Colegio.PRESENTACION
{
    partial class FormMATERIA
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
            System.Windows.Forms.Label iD_MATERIALabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMATERIA));
            this.mATERIABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.iD_MATERIATextBox = new System.Windows.Forms.TextBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            iD_MATERIALabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIABindingNavigator)).BeginInit();
            this.mATERIABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_MATERIALabel
            // 
            iD_MATERIALabel.AutoSize = true;
            iD_MATERIALabel.Location = new System.Drawing.Point(89, 62);
            iD_MATERIALabel.Name = "iD_MATERIALabel";
            iD_MATERIALabel.Size = new System.Drawing.Size(72, 13);
            iD_MATERIALabel.TabIndex = 1;
            iD_MATERIALabel.Text = "ID MATERIA:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(89, 88);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(57, 13);
            nOMBRELabel.TabIndex = 3;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // mATERIABindingNavigator
            // 
            this.mATERIABindingNavigator.AddNewItem = null;
            this.mATERIABindingNavigator.CountItem = null;
            this.mATERIABindingNavigator.DeleteItem = null;
            this.mATERIABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton1});
            this.mATERIABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mATERIABindingNavigator.MoveFirstItem = null;
            this.mATERIABindingNavigator.MoveLastItem = null;
            this.mATERIABindingNavigator.MoveNextItem = null;
            this.mATERIABindingNavigator.MovePreviousItem = null;
            this.mATERIABindingNavigator.Name = "mATERIABindingNavigator";
            this.mATERIABindingNavigator.PositionItem = null;
            this.mATERIABindingNavigator.Size = new System.Drawing.Size(532, 25);
            this.mATERIABindingNavigator.TabIndex = 0;
            this.mATERIABindingNavigator.Text = "bindingNavigator1";
            // 
            // iD_MATERIATextBox
            // 
            this.iD_MATERIATextBox.Location = new System.Drawing.Point(167, 59);
            this.iD_MATERIATextBox.Name = "iD_MATERIATextBox";
            this.iD_MATERIATextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_MATERIATextBox.TabIndex = 2;
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.Location = new System.Drawing.Point(167, 85);
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMBRETextBox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 150);
            this.dataGridView1.TabIndex = 50;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Image = global::Colegio.Properties.Resources._1381810697_22560;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(322, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 41);
            this.button3.TabIndex = 52;
            this.button3.Text = "Actualizar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Eliminar";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Guardar datos";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Agregar nuevo";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // FormMATERIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 348);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(iD_MATERIALabel);
            this.Controls.Add(this.iD_MATERIATextBox);
            this.Controls.Add(nOMBRELabel);
            this.Controls.Add(this.nOMBRETextBox);
            this.Controls.Add(this.mATERIABindingNavigator);
            this.Name = "FormMATERIA";
            this.Text = "FormMATERIA";
            this.Load += new System.EventHandler(this.FormMATERIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mATERIABindingNavigator)).EndInit();
            this.mATERIABindingNavigator.ResumeLayout(false);
            this.mATERIABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator mATERIABindingNavigator;
        private System.Windows.Forms.TextBox iD_MATERIATextBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}