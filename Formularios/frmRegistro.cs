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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sistemas");
            comboBox1.Items.Add("Contabilidad");
            comboBox1.Items.Add("Recursos Humanos");
            comboBox1.Items.Add("Ventas");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();

            emp.Codigo = ListaEmpleados.GenerarCodigo();
            emp.Nombre = textBox1.Text;
            emp.Cedula = textBox2.Text;
            emp.Direccion = textBox3.Text;
            emp.Telefono = textBox4.Text;
            emp.Edad = Convert.ToInt32(textBox5.Text);
            emp.Cargo = textBox6.Text;
            emp.Salario = Convert.ToDouble(textBox7.Text);
            emp.Departamento = comboBox1.Text;

            ListaEmpleados.Agregar(emp);

            MessageBox.Show("Empleado registrado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaEmpleados.lista;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
