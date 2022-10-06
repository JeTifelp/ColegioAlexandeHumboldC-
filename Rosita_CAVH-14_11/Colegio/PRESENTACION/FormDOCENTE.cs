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
    public partial class FormDOCENTE : Form
    {
        private string tipo;
        N_DOCENTE DOC = new N_DOCENTE();
        public FormDOCENTE(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void dOCENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.dOCENTEBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.cAVH2DataSet);

        }

     /*  private void FormDOCENTE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAVH2DataSet.DOCENTE' Puede moverla o quitarla según sea necesario.
            //this.dOCENTETableAdapter.Fill(this.cAVH3DataSet.DOCENTE);

        }
        */
        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            DOC.insertar(iD_DOCENTETextBox.Text,aP_PATERNOTextBox.Text,aP_MATERNOTextBox.Text, nOMBRETextBox.Text,Convert.ToInt32(hORAS_TRABAJOTextBox.Text),tELEFONOTextBox.Text,dIRECCIONTextBox.Text, fECHA_NACIMIENTODateTimePicker.Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DOC.MOSTRAR();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {

            PRINCIPAL_CAVH FR = new PRINCIPAL_CAVH(tipo);
            FR.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DOC.eliminar(iD_DOCENTETextBox.Text);
        }

        private void dOCENTEBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormDOCENTE_Load(object sender, EventArgs e)
        {

        }

        private void iD_DOCENTETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dOCENTEBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
