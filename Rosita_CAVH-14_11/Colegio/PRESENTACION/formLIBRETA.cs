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
    public partial class formLIBRETA : Form
    {
        N_LIBRETA LIB = new N_LIBRETA();
        public formLIBRETA()
        {
            InitializeComponent();
        }

        private void lIBRETABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lIBRETABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAVH3DataSet);

        }

        private void formLIBRETA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet.LIBRETA' Puede moverla o quitarla según sea necesario.
            this.lIBRETATableAdapter.Fill(this.cAVH3DataSet.LIBRETA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LIB.MOSTRAR();
        }
    }
}
