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
    public partial class AUTENTIFICACION : Form
    {
        private string tipo;
        public AUTENTIFICACION(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }
        public AUTENTIFICACION()
        {
            InitializeComponent();
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (Usuario.Autentificar(txtUsuario.Text, txtContraseña.Text) > 0)
            {
                this.Hide();
                PRINCIPAL_CAVH f = new PRINCIPAL_CAVH(s);
                f.ShowDialog();
            }
            else
                MessageBox.Show("Error en los datos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Usuario.Autentificar(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    this.Hide();
                    Form1 f = new Form1();
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("Error en los datos");
        }

        
    }

        private void button1_Click(object sender, EventArgs e)
        {
         this.Hide();
            REGISTRO_USUARIOS f = new REGISTRO_USUARIOS();
            f.ShowDialog();
        }

        private void AUTENTIFICACION_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (Usuario.Autentificar(txtUsuario.Text, txtContraseña.Text) > 0)
            {
                this.Hide();
                PRINCIPAL_CAVH f = new PRINCIPAL_CAVH(s);
                f.ShowDialog();
            }
            else
                MessageBox.Show("Error en los datos");
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtContraseña.Text)
            {
                if (Usuario.CrearCuentas(textBox3.Text, textBox2.Text) > 0)
                {
                    MessageBox.Show("Cuenta Creada con exito");
                }
                else
                    MessageBox.Show("No se pudo crear la cuenta");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
