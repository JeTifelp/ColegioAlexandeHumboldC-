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
    public partial class Alumn21 : Form
    {
        public Alumn21()
        {
            InitializeComponent();
        }

        private void Alumn21_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Alumnooo.ALUMNO' Puede moverla o quitarla según sea necesario.
            this.ALUMNOTableAdapter.Fill(this.Alumnooo.ALUMNO);

            this.reportViewer1.RefreshReport();
        }
    }
}
