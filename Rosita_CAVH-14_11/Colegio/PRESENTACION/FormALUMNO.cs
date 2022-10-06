using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Colegio.NEGOCIO;
using Colegio.DATOS;
namespace Colegio.PRESENTACION
{
    public partial class FormALUMNO : Form
    {
        N_ALUMNO ALUM = new N_ALUMNO();   
        public FormALUMNO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormALUMNO_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'cAVH2DataSet.ALUMNO' Puede moverla o quitarla según sea necesario.
            //this.aLUMNOTableAdapter.Fill(this.cAVH2DataSet.ALUMNO);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ALUM.MOSTRAR();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FORM_realizar_inscripcion fr = new FORM_realizar_inscripcion();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            ALUM.Insertar(iD_ALUMNOTextBox.Text, aP_PATERNOTextBox.Text, aP_MATERNOTextBox.Text,nOMBRETextBox.Text,dIRECCIONTextBox.Text,sEXOTextBox.Text,iD_LNTextBox.Text );
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ALUM.eliminar(iD_ALUMNOTextBox.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ALUM.modificar(iD_ALUMNOTextBox.Text, aP_PATERNOTextBox.Text, aP_MATERNOTextBox.Text, nOMBRETextBox.Text, dIRECCIONTextBox.Text, sEXOTextBox.Text, iD_LNTextBox.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
            //______BUSCA ALUMNOS POR NOMBRE______________//
            int total = 0;  
            string ID_AL="";
            String AP_PAT="";
            String AP_MAT="";
            String NOM="";
            String DIRE="";
            String SEX="";
            String ID_LUGA="";
            ALUMNO P = new ALUMNO();
            N_ALUMNO nnalumnos = new N_ALUMNO();

            String nombr = this.buscartextBox1.Text;
            P.setNombre(nombr);

            String apell_Pat = this.ap_pat_textBox1.Text;
            P.setAP_paterno(apell_Pat);

            String apell_mat = this.ap_mat_textBox2.Text;
            P.setAP_materno(apell_mat);

            DataTable ds = new DataTable();


            ds = nnalumnos.buscar_alumno_por_nombre(P);//PARALELOS.Buscar_Cupo(P);
            foreach (DataRow renglon in ds.Rows)
            {
                 ID_AL = renglon["ID_ALUMNO"].ToString();
                //textBox1.Text = IDP;
                

               AP_PAT= renglon["AP_PATERNO"].ToString();
               

                AP_MAT= renglon["AP_MATERNO"].ToString();
               

               NOM = renglon["NOMBRE"].ToString();
               

                 DIRE= renglon["DIRECCION"].ToString();
               

                SEX = renglon["SEXO"].ToString();
              

               ID_LUGA=renglon["ID_LN"].ToString();
               

               // total = CUPOMAX - CUPOLLENO;

            }
            iD_ALUMNOTextBox.Text = ID_AL;
            aP_PATERNOTextBox.Text = AP_PAT;
            aP_PATERNOTextBox.Text = AP_MAT;
            nOMBRETextBox.Text = NOM;
            dIRECCIONTextBox.Text = DIRE;
            sEXOTextBox.Text = SEX;
            iD_LNTextBox.Text = ID_LUGA;

            // dataGridView1.DataSource = Convert.ToString(total);
          // buscartextBox1.Text = Convert.ToString(total);
        }

        private void iD_ALUMNOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aP_PATERNOLabel_Click(object sender, EventArgs e)
        {

        }

        private void aP_MATERNOLabel_Click(object sender, EventArgs e)
        {

        }

        private void nOMBRELabel_Click(object sender, EventArgs e)
        {

        }

        private void dIRECCIONLabel_Click(object sender, EventArgs e)
        {

        }

        private void sEXOLabel_Click(object sender, EventArgs e)
        {

        }

        private void iD_LNLabel_Click(object sender, EventArgs e)
        {

        }

        private void iD_LNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sEXOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dIRECCIONTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nOMBRETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aP_MATERNOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aP_PATERNOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iD_ALUMNOLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
