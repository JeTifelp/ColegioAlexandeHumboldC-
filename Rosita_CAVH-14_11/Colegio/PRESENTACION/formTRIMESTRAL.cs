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
    public partial class formTRIMESTRAL : Form
    {
       

        public formTRIMESTRAL()
        {
            InitializeComponent();
        }

        private void bOLETIN_TRIMESTRALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOLETIN_TRIMESTRALBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAVH3DataSet);

        }

        private void formTRIMESTRAL_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet.BOLETIN_TRIMESTRAL' Puede moverla o quitarla según sea necesario.
            this.bOLETIN_TRIMESTRALTableAdapter.Fill(this.cAVH3DataSet.BOLETIN_TRIMESTRAL);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /*    SELECT  AVG (CALIFICACION)
               FROM NOTAS N
               WHERE N.ID_ALUMNO='AL001' AND N.CURSO='1PRIM' AND N.ID_TRIMESTRE= 'TRI01' AND N.MATERIA='MAT'
            * **/

        }
    }
}
