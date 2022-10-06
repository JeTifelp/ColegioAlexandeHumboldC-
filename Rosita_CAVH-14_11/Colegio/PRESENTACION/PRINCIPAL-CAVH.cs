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
    public partial class PRINCIPAL_CAVH : Form
    {
        private string tipo;
        public PRINCIPAL_CAVH(string tipo )
        {

            InitializeComponent();
            this.tipo = tipo;
            if (tipo == "Docente")
            {
                gESTIONACADEMICAToolStripMenuItem.Enabled = false;
                aLUMNOToolStripMenuItem.Enabled = false;
                rEPORTESToolStripMenuItem.Enabled = false;
                
            }
            if (tipo == "Secretaria")
            {
                gESTIONACADEMICAToolStripMenuItem.Enabled = false;
                nOTASToolStripMenuItem.Enabled = true;
                rEPORTESToolStripMenuItem.Enabled = true;

            }
            if (tipo == "Director")
            {
                gESTIONACADEMICAToolStripMenuItem.Enabled = true;
                nOTASToolStripMenuItem.Enabled = true;
                rEPORTESToolStripMenuItem.Enabled = true;

            }
            
        }

        private void PRINCIPAL_CAVH_Load(object sender, EventArgs e)
        {

        }

        private void gESTIONARNIVELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNIVEL FR = new FormNIVEL(tipo);
            FR.Show();
        }

        private void gESTIONARCURSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCURSO FR = new FormCURSO();
            FR.Show();
        }

        private void gESTIONARPARALELOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PARALELO FR = new PARALELO (tipo);
            FR.Show();
        }

        private void gESTIONARMATERIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMATERIA FR = new FormMATERIA(tipo);
            FR.Show();
            
        }

        private void aSIGNARHORARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHORARIO FR = new FormHORARIO();
            FR.Show();
        }

        private void gESTIONARDOCENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDOCENTE FR = new FormDOCENTE(tipo);
            FR.Show();
        }

        private void aLUMNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVERIFICAR_CUPO FR = new FormVERIFICAR_CUPO();
          //  FORM_realizar_inscripcion FR = new FORM_realizar_inscripcion();
            FR.Show();
        }

        private void rEDISTRARNOTASDELALUMNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNOTAS FR = new  FormNOTAS ();
            FR.Show();
        }

        private void rEGISTRARNOTATRIMESTRALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTRIMESTRAL FR = new  formTRIMESTRAL();
            FR.Show();  
        }

        private void gESTIONARLIBRETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLIBRETA FR = new formLIBRETA();
            FR.Show();
        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gESTIONARGESTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGESTION fr = new FormGESTION();
            fr.Show();
        }

        private void gESTIONARLISTADODEALUMNOSPARACADACURSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumno20 l = new Alumno20();
            l.Show();
        }

        private void gENERARLISTADODEPROFESORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Docente20 l = new Docente20();
            l.Show();

            
        }

       
    }
}
