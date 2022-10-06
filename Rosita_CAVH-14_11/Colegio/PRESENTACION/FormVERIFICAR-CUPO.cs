using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Colegio.NEGOCIO;
using Colegio.CONEXION;

namespace Colegio.PRESENTACION
{
    public partial class FormVERIFICAR_CUPO : Form
    {
        N_PARALELOS n_nparalelo = new N_PARALELOS();
        N_LUGARDENACIMIENTO nlugarNacimiento = new N_LUGARDENACIMIENTO();
        N_INSCRIPCION ins = new N_INSCRIPCION();
        N_LUGARDENACIMIENTO LN =new N_LUGARDENACIMIENTO();
        N_ALUMNO Alumn = new N_ALUMNO();
        N_CERTIFICADO CER = new N_CERTIFICADO();

        N_RUDE RUD = new N_RUDE();
        DialogResult res;
         public FormVERIFICAR_CUPO()
        {
            InitializeComponent();
        }

        private void vERIFICARCUPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gESTIONARALUMNOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormVERIFICAR_CUPO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet4.RUDE' Puede moverla o quitarla según sea necesario.
            this.rUDETableAdapter.Fill(this.cAVH3DataSet4.RUDE);
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet4.LUGAR_NACIMIENTO' Puede moverla o quitarla según sea necesario.
            this.lUGAR_NACIMIENTOTableAdapter.Fill(this.cAVH3DataSet4.LUGAR_NACIMIENTO);
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet4.PARALELO' Puede moverla o quitarla según sea necesario.
            this.pARALELOTableAdapter.Fill(this.cAVH3DataSet4.PARALELO);
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet4.GESTION' Puede moverla o quitarla según sea necesario.
            this.gESTIONTableAdapter.Fill(this.cAVH3DataSet4.GESTION);
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet3.GESTION' Puede moverla o quitarla según sea necesario.
        //    this.gESTIONTableAdapter.Fill(this.cAVH3DataSet3.GESTION);
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet3.PARALELO' Puede moverla o quitarla según sea necesario.
        //    this.pARALELOTableAdapter.Fill(this.cAVH3DataSet3.PARALELO);
          /*  // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet3.EMPLEADO' Puede moverla o quitarla según sea necesario.
                this.eMPLEADOTableAdapter.Fill(this.cAVH3DataSet3.EMPLEADO);
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet3.GESTION' Puede moverla o quitarla según sea necesario.
            this.gESTIONTableAdapter.Fill(this.cAVH3DataSet3.GESTION);
*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_______CONTROLA CUPO______________//
            int total = 0;
            PARALELOS P = new PARALELOS();
            N_PARALELOS N_P = new N_PARALELOS();

            String iD = this.paralelocomboBox1.Text;
            P.setID_paralelo(iD);
            String idgest = this.gestioncomboBox2.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Result_textBox1.Text = Convert.ToString(n_nparalelo.contar_cuposPROcedure(paralelocomboBox1.Text));
        }

        private void paralelocomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            nlugarNacimiento.eliminar(textIDPAIS.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            nlugarNacimiento.insertar(textIDPAIS.Text, textPAISNAC.Text, textDEPARTAMENTO.Text, textPROVINCIAESTADO.Text, textCUIDAD.Text);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            nlugarNacimiento.modificar(textIDPAIS.Text, textPAISNAC.Text, textDEPARTAMENTO.Text, textPROVINCIAESTADO.Text, textCUIDAD.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = nlugarNacimiento.MOSTRAR();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = ins.MOSTRAR();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            res = MessageBox.Show(" DESEA REALIZAR LA INSCRIPCION ","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res== DialogResult.Yes){
         
            ins.insertar(iD_INSCRIPCIONTextBox.Text, fECHADateTimePicker.Value, comboBox1.Text, iD_ALUMNOTextBox.Text, comboBox2.Text, iD_EMPLEADOTextBox.Text);

            }       
            }

        private void button7_Click(object sender, EventArgs e)
        {    res = MessageBox.Show(" DESEA REALIZAR ELIMINACION DE LA INSCRIPCION ","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res== DialogResult.Yes){
         
            ins.eliminar(iD_INSCRIPCIONTextBox.Text);

            }
     }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Alumn.Insertar(textBox1.Text, aP_PATERNOTextBox.Text, aP_MATERNOTextBox.Text, nOMBRETextBox.Text, dIRECCIONTextBox.Text, sEXOTextBox.Text, comboBox3.Text);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Alumn.eliminar(textBox1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {

            Alumn.modificar(textBox1.Text, aP_PATERNOTextBox.Text, aP_MATERNOTextBox.Text, nOMBRETextBox.Text, dIRECCIONTextBox.Text, sEXOTextBox.Text, comboBox3.Text);
       
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = Alumn.MOSTRAR();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = CER.MOSTRAR();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dfechainicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        { // busca el Id de ins y lo recupera en un textbox
          iD_INSCRIPCIONTextBox.Text=  ins.Contar_tUPLAS_Inscripcion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            N_ALUMNO n_nalumno = new N_ALUMNO();
            iD_ALUMNOTextBox.Text = Convert.ToString(n_nalumno.buscar_algun_ID_Alumno(nombretextBox1.Text, aPaternotextBox2.Text, aMaternotextBox3.Text));



        }

        private void button18_Click(object sender, EventArgs e)
        {
            CER.insertar(textBox10.Text, Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox2.Text), dfechainicio.Value, textBox7.Text);
      
        }

        private void button19_Click(object sender, EventArgs e)
        {
           CER.eliminar(textBox10.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
           CER.modificar(textBox10.Text, Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox2.Text), dfechainicio.Value, textBox7.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            dataGridView6.DataSource = RUD.MOSTRAR();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            RUD.insertar(cOD_RUDETextBox.Text,nOMBRE_UETextBox.Text,Convert.ToInt32(cODIGO_SIETextBox.Text),Convert.ToInt32(cODIGO_PROCEDENCIATextBox.Text),dEPENDENCIA_UETextBox.Text,nOMBRE_UE_PROCEDENCIATextBox.Text, iD_ALUMNOTextBox1.Text  );
        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }
    }
}
