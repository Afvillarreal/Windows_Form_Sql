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
    public partial class ventana_nuevo : Form
    {
        public ventana_nuevo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 1;
            progressBar1.Maximum = 100;
            progressBar1.Step = 2;

            for (int x=0; x<100; x++)
            {
                progressBar1.PerformStep();
            }
        }
    }
}
