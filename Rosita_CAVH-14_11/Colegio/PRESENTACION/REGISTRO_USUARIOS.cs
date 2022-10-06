using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Colegio.DATOS;
namespace Colegio.PRESENTACION
{
    public partial class REGISTRO_USUARIOS : Form
    {
        public REGISTRO_USUARIOS()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtContraseña.Text)
            {
                if (Usuario.CrearCuentas(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    MessageBox.Show("Cuenta Creada con exito");
                }
                else
                    MessageBox.Show("No se pudo crear la cuenta");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AUTENTIFICACION f = new AUTENTIFICACION();
            f.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void REGISTRO_USUARIOS_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
