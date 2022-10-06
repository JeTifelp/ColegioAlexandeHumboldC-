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
    public partial class Form_INSCRIBIR : Form
    {
        N_INSCRIPCION ins = new N_INSCRIPCION();
        public Form_INSCRIBIR()
        {
            InitializeComponent();
        }

        private void vERIFICARCUPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_realizar_inscripcion FR = new  FORM_realizar_inscripcion ();
            FR.Show();
        }

        private void gESTIONARAPODERADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAPODERADO FR = new FormAPODERADO();
            FR.Show();
        }

        private void gESTIONARAPODERADOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAPODERADO FR = new FormAPODERADO();
            FR.Show();
        }

    /*    private void iNSCRIPCIONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iNSCRIPCIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAVH3DataSet);

        }

        private void Form_INSCRIBIR_Load(object sender, EventArgs e)
        {
        }*/

        private void rEGISTRARLUGARDENACIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLUGARDENACIMIENTO fr = new FormLUGARDENACIMIENTO();
            fr.Show();
        }

        private void gESTIONARALUMNOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormALUMNO fr = new FormALUMNO();
            fr.Show();
        }

        private void gESTIONARSEGUROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSEGURO fr = new FormSEGURO();
            fr.Show();
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

        private void gESTIONARALUMNOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            ins.eliminar(iD_INSCRIPCIONTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ins.MOSTRAR();
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            ins.insertar(iD_INSCRIPCIONTextBox.Text, fECHADateTimePicker.Value, comboBox1.Text, iD_ALUMNOTextBox.Text, comboBox2.Text, iD_EMPLEADOTextBox.Text);
  
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {

        }

        private void Form_INSCRIBIR_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet3.GESTION' Puede moverla o quitarla según sea necesario.
            this.gESTIONTableAdapter1.Fill(this.cAVH3DataSet3.GESTION);
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet3.PARALELO' Puede moverla o quitarla según sea necesario.
            this.pARALELOTableAdapter1.Fill(this.cAVH3DataSet3.PARALELO);
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet1.PARALELO' Puede moverla o quitarla según sea necesario.
        //    this.pARALELOTableAdapter.Fill(this.cAVH3DataSet1.PARALELO);
            // TODO: esta línea de código carga datos en la tabla 'cAVH3DataSet1.GESTION' Puede moverla o quitarla según sea necesario.
         //   this.gESTIONTableAdapter.Fill(this.cAVH3DataSet1.GESTION);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  N_GESTION gesti = new N_GESTION();
           int cant= gesti.Contar_CantTuplas_Gestion();
           iD_INSCRIPCIONTextBox.Text = Convert.ToString(cant);
           */
            N_INSCRIPCION inscrip = new N_INSCRIPCION();
           // int cant = inscrip.Contar_tUPLAS_Inscripcion();
          //  iD_INSCRIPCIONTextBox.Text = Convert.ToString(cant-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Result_textBox1.Text = Convert.ToString(n_nparalelo.contar_cuposPROcedure(paralelocomboBox1.Text));
            N_ALUMNO n_nalumno = new N_ALUMNO();
            iD_ALUMNOTextBox.Text = Convert.ToString(n_nalumno.buscar_algun_ID_Alumno(nombretextBox1.Text,aPaternotextBox2.Text,aMaternotextBox3.Text));

            /*
              public int  ObtieneCupos_de_UNParalelos(String codigoparalelo)
              {
                  String rpta;
                  cnx.AbrirConexion();
                  SqlConnection sqlcnx = new SqlConnection(cnx.obtennerCaminoConexion());
                  int cantidad = 0;
                  //SqlConnection sqlcnx = new SqlConnection(cnx.LeerConexion());
                  try
                  {

                      sqlcnx.Open();
                      SqlCommand sqlcmd = new SqlCommand("VerificarCupo", sqlcnx);
                      sqlcmd.CommandType = CommandType.StoredProcedure;


                      SqlParameter SqlPar_Sigla = new SqlParameter();
                      SqlPar_Sigla.ParameterName = "@Sigla";
                      SqlPar_Sigla.SqlDbType = SqlDbType.VarChar;
                      SqlPar_Sigla.Size = 10;
                      SqlPar_Sigla.Value = codigoparalelo; // SqlPar_Sigla.Value = ID_PARALELO;//dar el parametro
                      sqlcmd.Parameters.Add(SqlPar_Sigla);


                      SqlParameter SqlPar_Cupo = new SqlParameter();
                      SqlPar_Cupo.ParameterName = "@NroCupo";
                      SqlPar_Cupo.SqlDbType = SqlDbType.Int;
                      SqlPar_Cupo.Direction = ParameterDirection.Output;
                      sqlcmd.Parameters.Add(SqlPar_Cupo);

                      sqlcmd.ExecuteNonQuery();
                       cantidad = (int)sqlcmd.Parameters["@NroCupo"].Value;
                      //cantidadcuposActualizados= (int)sqlcmd.Parameters["@NroCupo"].Value;
                     

                  }
                  catch (Exception ex)
                  {
                      rpta = ex.Message;
                  }
                  finally
                  {
                      if (sqlcnx.State == ConnectionState.Open) sqlcnx.Close();

                  }
                  //corregir
                  return cantidad;
                  cnx.CerrarConexion();

              }//_____ 
        */

        }

        private void rEALIZARINSCRIPCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
