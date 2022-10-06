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
    public partial class PARALELO : Form
    {
        private string tipo;
        N_PARALELOS para = new N_PARALELOS();
        
        public PARALELO(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void pARALELOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.pARALELOBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.cAVH2DataSet);

        }

        private void PARALELO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet.GESTION' Puede moverla o quitarla según sea necesario.
            this.gESTIONTableAdapter.Fill(this.cAVH3DataSet.GESTION);
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet.CURSO' Puede moverla o quitarla según sea necesario.
            this.cURSOTableAdapter.Fill(this.cAVH3DataSet.CURSO);
            //// TODO: esta línea de código carga datos en la tabla 'cAVH2DataSet.PARALELO' Puede moverla o quitarla según sea necesario.
            //this.pARALELOTableAdapter.Fill(this.cAVH2DataSet.PARALELO);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = para.MOSTRAR();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            para.insertar(iD_PARALELOTextBox.Text,dESCRIPCIONTextBox.Text,Convert.ToInt32(cUPOS_LLENOSTextBox.Text),Convert.ToInt32(cUPO_MAXTextBox.Text),comboBox1.Text, comboBox2.Text);
        }

        private void pARALELOBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PRINCIPAL_CAVH fr = new PRINCIPAL_CAVH(tipo);
            fr.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            para.eliminar(iD_PARALELOTextBox.Text);
        }
    }
}
