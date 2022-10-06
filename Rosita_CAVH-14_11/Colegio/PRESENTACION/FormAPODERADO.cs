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
    public partial class FormAPODERADO : Form
    {
        N_APODERADO APO = new N_APODERADO();

        public FormAPODERADO()
        {
            InitializeComponent();
        }

        private void aPODERADOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.aPODERADOBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.cAVH2DataSet);

        }

        private void FormAPODERADO_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'cAVH2DataSet.APODERADO' Puede moverla o quitarla según sea necesario.
            //this.aPODERADOTableAdapter.Fill(this.cAVH2DataSet.APODERADO);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FORM_realizar_inscripcion FR = new FORM_realizar_inscripcion();
            FR.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            APO.insertar(Convert.ToInt32(cI_APODERADOTextBox.Text),aP_PATERNOTextBox.Text, aP_MATERNOTextBox.Text,nOMBRETextBox.Text,oCUPACIONTextBox.Text,mAYOR_GRADO_INSTRUCCIONTextBox.Text,pROFESIONTextBox.Text,eMPRESA_TRABAJOTextBox.Text,Convert.ToInt32(tELEFONOTextBox.Text), pARENTESCOTextBox.Text, dIRECCION_DOMICILIOTextBox.Text , dIRECCION_OFICINATextBox.Text );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = APO.MOSTRAR();
        }
    }
}
