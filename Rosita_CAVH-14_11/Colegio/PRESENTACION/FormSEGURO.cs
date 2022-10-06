using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Colegio.DATOS;

namespace Colegio.PRESENTACION
{
    public partial class FormSEGURO : Form

    {
        private NEGOCIO.N_SEGURO n_nseguro = new NEGOCIO.N_SEGURO();
        public FormSEGURO()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FORM_realizar_inscripcion FR = new FORM_realizar_inscripcion();
            FR.Show();
        }

        private void FormSEGURO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n_nseguro.insertar(idsegurotextBox1.Text,idsegurotextBox1.Text,estadotextBox3.Text, dateTimePicker1.Value,gestiontextBox2.Text);

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n_nseguro.eliminar(idsegurotextBox1.Text);
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = n_nseguro.MOSTRAR();
        
        }
    }
}
