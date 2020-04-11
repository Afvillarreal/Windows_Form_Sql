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
    public partial class ventana3 : Form
    {
        public ventana3()
        {
            InitializeComponent();
        }

        private void btnvolvervent3_Click(object sender, EventArgs e)
        {
            ventana2 volver = new ventana2();
            this.Hide();
            volver.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/felipe/Desktop/imagenes/"+ listBox1.Text +".png";
            pictureBox2.ImageLocation = "C:/Users/felipe/Desktop/imagenes/" + comboBox1.Text + ".png";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "C:/Users/felipe/Desktop/imagenes/images.png";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }
    }
}
