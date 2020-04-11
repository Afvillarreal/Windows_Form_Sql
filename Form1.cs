using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (txtid.Text=="1" && txtcon.Text == "1")
            {
                //MessageBox.Show("ha ingresado");

                this.Hide();

                ventana2 nuevaventana = new ventana2();
                nuevaventana.Show();
            }
            else
            {
                MessageBox.Show("datos incorrecto");

                txtid.Text = "";
                txtcon.Text = "";

                txtid.Focus();
            }

        }
    }
}
