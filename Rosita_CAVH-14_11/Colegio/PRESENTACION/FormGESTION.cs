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
    public partial class FormGESTION : Form
    {
        private N_GESTION ngestion = new N_GESTION();
        //los textbox tienen nombres cada uno
        public FormGESTION()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            ngestion.insertar(tid_getion.Text, tdescripcion.Text, dfechainicio.Value, dfechafin.Value);
        }

        private void FormGESTION_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = ngestion.listar();
            dataGridView1.DataSource = ngestion.MOSTRAGESTION();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ngestion.eliminar(tid_getion.Text);
        }

        private void tid_getion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tid_getion_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ngestion.MOSTRAGESTION();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
