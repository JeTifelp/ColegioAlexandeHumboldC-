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
    public partial class FormNOTAS : Form
    {
        N_NOTAS nota = new N_NOTAS();
        public FormNOTAS()
        {
            InitializeComponent();
        }

        private void FormNOTAS_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            nota.insertar(iD_ALUMNOTextBox.Text, tIPOTextBox.Text, Convert.ToInt32(cALIFICACIONTextBox.Text), fECHADateTimePicker.Value, mATERIATextBox.Text, cURSOTextBox.Text, iD_TRIMESTRETextBox.Text, iD_ALUMNOTextBox.Text);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            nota.eliminar(iD_NOTASTextBox.Text);

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            Form1 FR = new Form1();

            FR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nota.MOSTRAR();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = nota.MOSTRAR();

        }
    }
}
