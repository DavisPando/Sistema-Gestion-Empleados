using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEmpleados.Entidades
{
    public class Persona
    {
        private string cedula;
        private string nombre;
        private string direccion;
        private string telefono;
        private int edad;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
