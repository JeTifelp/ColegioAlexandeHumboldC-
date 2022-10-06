using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Colegio.PRESENTACION;

namespace Colegio
{
    public partial class Form1 : Form
    {
       // private string tipo;
        public Form1()
        {
            InitializeComponent();
            //this.tipo = tipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGESTION P = new FormGESTION();
            P.Show();                      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNIVEL FN = new FormNIVEL();
            FN.Show();
        }

        private void aLUMNOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lUGARDENACIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLUGARDENACIMIENTO FLugN = new FormLUGARDENACIMIENTO();
            FLugN.Show();
            

        }
    }
}
