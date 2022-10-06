using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Colegio
{
    public partial class Docente20 : Form
    {
        public Docente20()
        {
            InitializeComponent();
        }

        private void Docente20_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Docente200.DOCENTE' Puede moverla o quitarla según sea necesario.
            this.DOCENTETableAdapter.Fill(this.Docente200.DOCENTE);

            this.reportViewer1.RefreshReport();
        }
    }
}
