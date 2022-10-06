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
    public partial class FormLUGARDENACIMIENTO : Form
    {
        private N_LUGARDENACIMIENTO nlugarNacimiento = new N_LUGARDENACIMIENTO();
        public FormLUGARDENACIMIENTO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NOMBREALUMNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLUGARDENACIMIENTO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nlugarNacimiento.insertar(textIDPAIS.Text, textPAISNAC.Text, textDEPARTAMENTO.Text, textPROVINCIAESTADO.Text, textCUIDAD.Text);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            nlugarNacimiento.eliminar(textIDPAIS.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            nlugarNacimiento.insertar(textIDPAIS.Text, textPAISNAC.Text, textDEPARTAMENTO.Text, textPROVINCIAESTADO.Text, textCUIDAD.Text);
      
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            nlugarNacimiento.eliminar(textIDPAIS.Text);
       
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            nlugarNacimiento.modificar(textIDPAIS.Text, textPAISNAC.Text, textDEPARTAMENTO.Text, textPROVINCIAESTADO.Text, textCUIDAD.Text);

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FORM_realizar_inscripcion fr = new  FORM_realizar_inscripcion();
            fr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nlugarNacimiento.MOSTRAR();
        }

        private void textCUIDAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPROVINCIAESTADO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDEPARTAMENTO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPAISNAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIDPAIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
