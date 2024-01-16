using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
        }

        public async Task WriteMascotasAsync(string path)
        {
            //Al escribir, debemos convertir la coleccion a string
            string data = this.ConvertMascotasString();
            await HelperFiles.WriteFileAsync(path, data);
        }

        public async Task ReadMascotasAsync(string path)
        {
            //Leemos el fichero que nos han dado
            string data = await HelperFiles.ReadFileAsync(path);
            this.ConvertMascotasList(data);
        }

        /*Nosotros....*/

        private string ConvertMascotasString()
        {
            string data = "";
            foreach(Mascota m in this.Mascotas)
            {
                string temp = m.Nombre + "," + m.Raza;
                data += temp + "#";
            }
            data = data.TrimEnd('#');
            return data;
        }

        //Tambien tendremos que leer de un fichero las mascotas
        //Al leer debemos convertir el string en coleccion
        //GARFIELD,GATO#PLUTO,PERRO
        private void ConvertMascotasList(string data)
        {
            //Limpiar la coleccion de mascotas
            this.Mascotas.Clear();
            //Separamos los datos de cada mascota
            string[] datosMascotas = data.Split('#');
            foreach(string d in datosMascotas)
            {
                //Volvemos a separar por el separador de propiedades
                string[] propiedades = d.Split(",");
                //Instanciamos cada mascota
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }
    }
}
