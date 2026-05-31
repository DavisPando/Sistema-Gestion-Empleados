using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEmpleados.Entidades
{
    public class Empleado : Persona
    {
        private int codigo;
        private string departamento;
        private string cargo;
        private double salario;
        private double bono;
        private double descuento;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public double Bono
        {
            get { return bono; }
            set { bono = value; }
        }

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        public void AplicarBono(double monto)
        {
            bono = monto;
            salario += bono;
        }

        public void AplicarDescuento()
        {
            descuento = salario * 0.0945;
            salario -= descuento;
        }

        public double SalarioNeto()
        {
            return salario - descuento;
        }
    
}
}
