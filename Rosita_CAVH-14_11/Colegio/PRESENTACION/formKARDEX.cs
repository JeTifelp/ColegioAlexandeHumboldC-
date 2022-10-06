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
    public partial class formKARDEX : Form
    {
        private Colegio.CONEXION.N_KARDEX nkardex = new Colegio.CONEXION.N_KARDEX();
        public formKARDEX()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void formKARDEX_Load(object sender, EventArgs e)
        {


        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nkardex.MOSTRAR();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nkardex.insertar(textBox1idkarde.Text, textBox2curso.Text, textBox3nivel.Text, textBox4colegioProced.Text,
                             textBox8gestion.Text, textBox6cantHermanos.Text, textBox5lug_nacimiento.Text, textBox7idAlumno.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            nkardex.eliminar(textBox1idkarde.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8gestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7idAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6cantHermanos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5lug_nacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4colegioProced_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2curso_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1idkarde_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nkardex.MOSTRAR() ;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

            nkardex.insertar(textBox1idkarde.Text, textBox2curso.Text, textBox3nivel.Text, textBox4colegioProced.Text,
                             textBox8gestion.Text, textBox6cantHermanos.Text, textBox5lug_nacimiento.Text, textBox7idAlumno.Text);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            nkardex.eliminar(textBox1idkarde.Text);
        }
    }
}
