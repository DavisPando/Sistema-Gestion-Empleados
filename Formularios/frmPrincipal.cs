using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionEmpleados.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistro f = new frmRegistro();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBono f = new frmBono();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmConsultas f = new frmConsultas();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
