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
    public partial class FormHORARIO : Form
    {
        public FormHORARIO()
        {
            InitializeComponent();
        }

        private void hORARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.hORARIOBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.cAVH2DataSet);

        }

        private void FormHORARIO_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'cAVH2DataSet.HORARIO' Puede moverla o quitarla según sea necesario.
            //this.hORARIOTableAdapter.Fill(this.cAVH2DataSet.HORARIO);

        }
    }
}
