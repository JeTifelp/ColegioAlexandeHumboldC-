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
    public partial class FORM_realizar_inscripcion : Form
    {
        N_PARALELOS n_nparalelo = new N_PARALELOS();
        public FORM_realizar_inscripcion()
        {
            InitializeComponent();
        }

        private void vERIFICARCUPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVERIFICAR_CUPO FR = new FormVERIFICAR_CUPO();
            FR.Show();
        }

      

        private void rEALIZARINSCRIPCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_INSCRIBIR FR = new Form_INSCRIBIR();
            FR.Show();
        }

        private void gESTIONARALUMNOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormALUMNO fr = new FormALUMNO();
            fr.Show();
        }

        private void gESTIONARAPODERADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAPODERADO FR = new FormAPODERADO();
            FR.Show();
        }

        private void gESTIONARCERTIFICADODENACIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCERTIFICADO fr = new FormCERTIFICADO();
            fr.Show();
        }

        private void gESTIONARRUDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRUDE fr = new FormRUDE();
            fr.Show();
        }

        private void gESTIONARKARDEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formKARDEX fr = new formKARDEX();
            fr.Show();
        }

        private void rEGISTRARLUGARDENACIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLUGARDENACIMIENTO fr = new FormLUGARDENACIMIENTO();
            fr.Show();
        }

        private void gESTIONARSEGUROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSEGURO fr = new FormSEGURO();
            fr.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void FORM_realizar_inscripcion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet.GESTION' Puede moverla o quitarla según sea necesario.
          //  this.gESTIONTableAdapter.Fill(this.cAVH3DataSet.GESTION);
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet.PARALELO' Puede moverla o quitarla según sea necesario.
          //  this.pARALELOTableAdapter.Fill(this.cAVH3DataSet.PARALELO);

        }

        private void gESTIONARSEGUROToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormSEGURO FR = new FormSEGURO();
            FR.Show();
        }

        private void rEALIZARINSCRIPCIONToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_INSCRIBIR FR = new Form_INSCRIBIR();
            FR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        { //_______CONTROLA CUPO______________//
            int total = 0;
            PARALELOS P = new PARALELOS();
            N_PARALELOS N_P = new N_PARALELOS();

            String iD = this.paralelocomboBox1.Text;
            P.setID_paralelo(iD);
            String idgest=this.gestioncomboBox2.Text;
            P.setID_GESTION(idgest);
            DataTable ds = new DataTable();

            ds = N_P.buscar_CUPO(P);//PARALELOS.Buscar_Cupo(P);
            foreach (DataRow renglon in ds.Rows)
            {
                string IDP = renglon["ID_PARALELO"].ToString();
                //textBox1.Text = IDP;
                int CUPOLLENO = Convert.ToInt32(renglon["CUPOS_LLENOS"].ToString());
                int CUPOMAX = Convert.ToInt32(renglon["CUPO_MAX"].ToString());
                total = CUPOMAX - CUPOLLENO;

            }
           // dataGridView1.DataSource = Convert.ToString(total);
           Result_textBox1.Text = Convert.ToString(total);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // _______________VERIFICAR CUPO CON PROCEDIMIENTO ALMACENADO_______________
        private void button2_Click(object sender, EventArgs e)
        {
            Result_textBox1.Text = Convert.ToString(n_nparalelo.contar_cuposPROcedure(paralelocomboBox1.Text));
        }

        private void paralelocomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}