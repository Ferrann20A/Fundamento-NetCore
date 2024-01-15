using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        protected int SalarioMinimo { get; set; }

        public int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() Empleado");
            return 22;
        }

        //Modificamos para leer el constructor co parametros de persona
        public Empleado()
        {
            Debug.WriteLine("Constructor vacío Empleado");
            this.SalarioMinimo = 2000;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public Empleado(string nombre, string apellidos) : base(nombre, apellidos)
        {
            Debug.WriteLine("Constructor 2 parametros Empleado");
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
    }
}
