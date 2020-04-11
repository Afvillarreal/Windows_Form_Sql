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
    public partial class Ventana4 : Form
    {
        public Ventana4()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            ventana2 volver = new ventana2();
            this.Hide();
            volver.Show();
        }

        private void Ventana4_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventana_nuevo nuevo = new ventana_nuevo();

            nuevo.MdiParent = this;

            nuevo.Show();
        }
    }
}
