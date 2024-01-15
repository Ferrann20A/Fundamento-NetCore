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
            Debug.WriteLine("GetVacaciones() Director");
            return 30;
        }
    }
}
