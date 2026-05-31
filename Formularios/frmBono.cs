using SistemaGestionEmpleados.Controlador;
using SistemaGestionEmpleados.Entidades;
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
    public partial class frmBono : Form
    {
        public frmBono()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emp = ListaEmpleados.Buscar(
                Convert.ToInt32(textBox1.Text));

            if (emp != null)
            {
                textBox2.Text = emp.Nombre;
                textBox3.Text = emp.Departamento;
                textBox4.Text = emp.Cargo;
                textBox5.Text = emp.Salario.ToString();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleado emp = ListaEmpleados.Buscar(
                Convert.ToInt32(textBox1.Text));

            if (emp != null)
            {
                double monto = Convert.ToDouble(textBox6.Text);
                emp.AplicarBono(monto);
                textBox5.Text = emp.Salario.ToString();
                MessageBox.Show("Bono aplicado correctamente");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Empleado emp = ListaEmpleados.Buscar(
                Convert.ToInt32(textBox1.Text));

            if (emp != null)
            {
                emp.AplicarDescuento();
                textBox5.Text = emp.Salario.ToString();
                MessageBox.Show("Descuento IESS aplicado: " +
                    emp.Descuento.ToString("F2"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
