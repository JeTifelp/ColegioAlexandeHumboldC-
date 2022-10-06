namespace Colegio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nIVELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLUMNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lUGARDENACIMIENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Nivel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Window;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBox1.Location = new System.Drawing.Point(95, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nIVELToolStripMenuItem,
            this.gESTIONToolStripMenuItem,
            this.aLUMNOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nIVELToolStripMenuItem
            // 
            this.nIVELToolStripMenuItem.Name = "nIVELToolStripMenuItem";
            this.nIVELToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.nIVELToolStripMenuItem.Text = "NIVEL";
            // 
            // gESTIONToolStripMenuItem
            // 
            this.gESTIONToolStripMenuItem.Name = "gESTIONToolStripMenuItem";
            this.gESTIONToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.gESTIONToolStripMenuItem.Text = "GESTION";
            // 
            // aLUMNOToolStripMenuItem
            // 
            this.aLUMNOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lUGARDENACIMIENTOToolStripMenuItem});
            this.aLUMNOToolStripMenuItem.Name = "aLUMNOToolStripMenuItem";
            this.aLUMNOToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aLUMNOToolStripMenuItem.Text = "ALUMNO";
            this.aLUMNOToolStripMenuItem.Click += new System.EventHandler(this.aLUMNOToolStripMenuItem_Click);
            // 
            // lUGARDENACIMIENTOToolStripMenuItem
            // 
            this.lUGARDENACIMIENTOToolStripMenuItem.Name = "lUGARDENACIMIENTOToolStripMenuItem";
            this.lUGARDENACIMIENTOToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.lUGARDENACIMIENTOToolStripMenuItem.Text = "LUGAR DE NACIMIENTO";
            this.lUGARDENACIMIENTOToolStripMenuItem.Click += new System.EventHandler(this.lUGARDENACIMIENTOToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 370);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "<          MAIN     FORM          >";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nIVELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLUMNOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lUGARDENACIMIENTOToolStripMenuItem;
    }
}

