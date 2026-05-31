using SistemaGestionEmpleados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEmpleados.Controlador
{
    public class ListaEmpleados
    {
        public static List<Empleado> lista = new List<Empleado>();

        public static int GenerarCodigo()
        {
            return lista.Count + 1;
        }

        public static void Agregar(Empleado e)
        {
            lista.Add(e);
        }

        public static Empleado Buscar(int codigo)
        {
            foreach (Empleado e in lista)
            {
                if (e.Codigo == codigo)
                    return e;
            }
            return null;
        }

        public static void Eliminar(int codigo)
        {
            Empleado e = Buscar(codigo);
            if (e != null)
                lista.Remove(e);
        }

        static ListaEmpleados()
        {
            Empleado e1 = new Empleado();
            e1.Codigo = 1;
            e1.Nombre = "Carlos Mendoza";
            e1.Cedula = "0701234567";
            e1.Direccion = "Pasaje";
            e1.Telefono = "0991111111";
            e1.Edad = 28;
            e1.Departamento = "Sistemas";
            e1.Cargo = "Desarrollador";
            e1.Salario = 1200;

            Empleado e2 = new Empleado();
            e2.Codigo = 2;
            e2.Nombre = "Maria Torres";
            e2.Cedula = "0709876543";
            e2.Direccion = "Machala";
            e2.Telefono = "0982222222";
            e2.Edad = 32;
            e2.Departamento = "Contabilidad";
            e2.Cargo = "Contadora";
            e2.Salario = 900;

            Empleado e3 = new Empleado();
            e3.Codigo = 3;
            e3.Nombre = "Luis Ramirez";
            e3.Cedula = "0704567891";
            e3.Direccion = "Cuenca";
            e3.Telefono = "0973333333";
            e3.Edad = 40;
            e3.Departamento = "Sistemas";
            e3.Cargo = "Analista";
            e3.Salario = 1500;

            Empleado e4 = new Empleado();
            e4.Codigo = 4;
            e4.Nombre = "Ana Vera";
            e4.Cedula = "0706543210";
            e4.Direccion = "Loja";
            e4.Telefono = "0964444444";
            e4.Edad = 25;
            e4.Departamento = "Recursos Humanos";
            e4.Cargo = "Asistente";
            e4.Salario = 800;

            Empleado e5 = new Empleado();
            e5.Codigo = 5;
            e5.Nombre = "Jose Castro";
            e5.Cedula = "0707418529";
            e5.Direccion = "Quito";
            e5.Telefono = "0955555555";
            e5.Edad = 35;
            e5.Departamento = "Contabilidad";
            e5.Cargo = "Auditor";
            e5.Salario = 1100;

            lista.Add(e1);
            lista.Add(e2);
            lista.Add(e3);
            lista.Add(e4);
            lista.Add(e5);
        }
    }
}
