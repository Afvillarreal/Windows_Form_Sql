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
    public partial class ventana2 : Form
    {
        public ventana2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            String seleccion;

            if (checkBox1.Checked == true)
            {
                cont++;
            }
            if (checkBox2.Checked == true)
            {
                cont++;
            }
            
            if (radioButton1.Checked == true)
            {
                seleccion = "tarjeta de Credito";
            }
            else
            {
                seleccion = "paypal";
            }

            MessageBox.Show("ha comprado " + cont + " cursos y el metodo de pago es: " + seleccion);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 volver = new Form1();
            this.Hide();
            volver.Show();
        }

        private void btnconfigvent2_Click(object sender, EventArgs e)
        {
            ventana3 configuracion = new ventana3();
            this.Hide();
            configuracion.Show();
        }

        private void btndescipvent3_Click(object sender, EventArgs e)
        {
            Ventana4 descripcion = new Ventana4();
            this.Hide();
            descripcion.Show();
        }
    }
}
