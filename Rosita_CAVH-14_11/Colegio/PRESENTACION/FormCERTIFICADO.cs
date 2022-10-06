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
    public partial class FormCERTIFICADO : Form
    {
        N_CERTIFICADO C_N = new N_CERTIFICADO();

        public FormCERTIFICADO()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            C_N.insertar(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), dfechainicio.Value, textBox7.Text);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            C_N.eliminar(textBox1.Text);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            C_N.modificar(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), dfechainicio.Value, textBox7.Text);
        
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FORM_realizar_inscripcion FR = new  FORM_realizar_inscripcion();

            FR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = C_N.MOSTRAR();
        }

        private void FormCERTIFICADO_Load(object sender, EventArgs e)
        {

        }
    }
}
