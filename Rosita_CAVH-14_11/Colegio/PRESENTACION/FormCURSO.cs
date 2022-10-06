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
    public partial class FormCURSO : Form
    {
        N_CURSO curso = new N_CURSO();
        public FormCURSO()
        {
            InitializeComponent();
        }

        private void FormCURSO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet.CURSO' Puede moverla o quitarla según sea necesario.
            this.cURSOTableAdapter.Fill(this.cAVH3DataSet.CURSO);

        }

        private void cURSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cURSOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAVH3DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = curso.MOSTRAR();
        }
    }
}