using SistemaGestionEmpleados.Controlador;
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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void empleadosPorDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta = ListaEmpleados.lista
                .OrderBy(emp => emp.Departamento)
                .ThenByDescending(emp => emp.Salario)
                .Select(emp => new
                {
                    emp.Codigo,
                    emp.Nombre,
                    emp.Departamento,
                    emp.Cargo,
                    emp.Salario
                })
                .ToList();

            dataGridView1.DataSource = consulta;
        }

        private void promedioDeSalariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta = ListaEmpleados.lista
                .GroupBy(emp => emp.Departamento)
                .Select(g => new
                {
                    Departamento = g.Key,
                    PromedioSalario = g.Average(x => x.Salario)
                })
                .ToList();

            dataGridView1.DataSource = consulta;
        }

        private void salarioMenorAlPromedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double promedio = ListaEmpleados.lista
                .Average(emp => emp.Salario);

            var consulta = ListaEmpleados.lista
                .Where(emp => emp.Salario < promedio)
                .Select(emp => new
                {
                    emp.Nombre,
                    emp.Departamento,
                    emp.Salario
                })
                .ToList();

            dataGridView1.DataSource = consulta;
        }

        private void mejorPagadoPorDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta = ListaEmpleados.lista
                .GroupBy(emp => emp.Departamento)
                .Select(g => new
                {
                    Departamento = g.Key,
                    MejorPagado = g.Max(x => x.Salario),
                    TotalEmpleados = g.Count()
                })
                .ToList();

            dataGridView1.DataSource = consulta;
        }

        private void reporteCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta = ListaEmpleados.lista
                .GroupBy(emp => emp.Departamento)
                .Select(g => new
                {
                    Departamento = g.Key,
                    CantidadEmpleados = g.Count(),
                    SalarioTotal = g.Sum(x => x.Salario),
                    SalarioPromedio = g.Average(x => x.Salario)
                })
                .ToList();

            dataGridView1.DataSource = consulta;
        }
    }
}
