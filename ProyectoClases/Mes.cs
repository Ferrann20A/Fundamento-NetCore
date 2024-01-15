using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes
    {
        public string Nombre { get; set; }
        public int TemperaturaMaxima { get; set; }
        public int TemperaturaMinima { get; set; }

        //public Mes(string nombre, int temperatura) { 
        //    this.Nombre = nombre;
        //    this.Temperatura = temperatura;
        //}

        public int GetMediaAnual()
        {
            return (this.TemperaturaMaxima + this.TemperaturaMinima) / 2;
        }

        //public string GetMesCompleto()
        //{
        //    return this.Nombre + ": " + this.Temperatura;
        //}
    }
}
