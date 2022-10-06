using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Colegio.NEGOCIO;

namespace Colegio.PRESENTACION
{
    public partial class FormNIVEL : Form
    {    private string tipo;
        private N_NIVEL nNivel = new N_NIVEL();
        public FormNIVEL(string tipo)
        {
            this.tipo=tipo;
            InitializeComponent();
        }
        public FormNIVEL()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nNivel.Insertar(tidnivel.Text,tdescripcion.Text);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nNivel.MOSTRAR();
     
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            nNivel.Insertar(tidnivel.Text, tdescripcion.Text);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            nNivel.Eliminar(tidnivel.Text);
     
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            PRINCIPAL_CAVH fr = new PRINCIPAL_CAVH(tipo);
            fr.Show();
        }

        private void FormNIVEL_Load(object sender, EventArgs e)
        {

        }
    }
}
