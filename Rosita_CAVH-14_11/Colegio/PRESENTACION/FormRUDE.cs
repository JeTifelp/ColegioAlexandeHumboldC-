using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Colegio.PRESENTACION
{
    public partial class FormRUDE : Form
    {
        public FormRUDE()
        {
            InitializeComponent();
        }

        private void rUDEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rUDEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAVH2DataSet);

        }

        private void FormRUDE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAVH2DataSet.RUDE' Puede moverla o quitarla según sea necesario.
            this.rUDETableAdapter.Fill(this.cAVH2DataSet.RUDE);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FORM_realizar_inscripcion FR = new FORM_realizar_inscripcion();
            FR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
