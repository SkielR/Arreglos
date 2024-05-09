using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos1w1
{
    class Empleado
    {
        private string nombre;
        private double sueldo;

        public double pSueldo {
            get { return sueldo; }
            set { sueldo = value; }
        }
        public string pNombre {
            get { return nombre; }
            set { nombre = value; }
        }
        public Empleado(string nombre, double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }
        public Empleado()
        {
            this.nombre = "";
            this.sueldo = 0;
        }
        public double calcularNeto(double porcentaje)
        {   
            return sueldo + (sueldo * porcentaje / 100);
        }
    }
}
