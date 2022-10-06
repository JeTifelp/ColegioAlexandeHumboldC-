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
    public partial class FormMATERIA : Form
    {
        private string tipo;
        N_MATERIA mat = new N_MATERIA();
        public FormMATERIA(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void mATERIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.mATERIABindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.cAVH2DataSet);

        }

        private void FormMATERIA_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'cAVH2DataSet.MATERIA' Puede moverla o quitarla según sea necesario.
            //this.mATERIATableAdapter.Fill(this.cAVH2DataSet.MATERIA);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            mat.insertar(iD_MATERIATextBox.Text,nOMBRETextBox.Text);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            mat.eliminar(iD_MATERIATextBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mat.MOSTRAR();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            PRINCIPAL_CAVH FR = new PRINCIPAL_CAVH(tipo);
            FR.Show();
        }
    }
}
