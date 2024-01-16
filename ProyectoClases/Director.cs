using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director:Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor Director");
            this.SalarioMinimo += 200;
        }

        //OVERRIDE
        public new int GetDiasVacaciones()
        {
            //Necesitamos leer primero la clase base para recuperar las vacaciones de un empleado
            int vacaciones = base.GetDiasVacaciones();
            Debug.WriteLine("GetVacaciones() Director");
            return vacaciones + 8;
        }

        public int GetDiasVacaciones(int diasExtras)
        {
            return 30 + diasExtras;
        }
    }
}
