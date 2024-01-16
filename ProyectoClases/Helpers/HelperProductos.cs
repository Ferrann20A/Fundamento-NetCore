using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperProductos
    {
        public List<Producto> Productos { get; set; }

        public HelperProductos()
        {
            this.Productos = new List<Producto>();
        }

        public async Task WriteProductosAsync(string path)
        {
            string data = this.ConvertProductosString();
            await HelperFiles.WriteFileAsync(path, data);
        }

        public async Task ReadProductosAsync(string path)
        {
            string data = await HelperFiles.ReadFileAsync(path);
            this.ConvertProductosList(data);
        }


        private string ConvertProductosString()
        {
            string data = "";
            foreach(Producto p in this.Productos)
            {
                string temp = p.Nombre + "," + p.Cantidad;
                data += temp + "#";
            }
            data = data.TrimEnd('#');
            return data;
        }

        private void ConvertProductosList(string data)
        {
            this.Productos.Clear();
            string[] datosProductos = data.Split('#');
            foreach(string d in datosProductos)
            {
                string[] propiedades = d.Split(",");
                Producto p = new Producto();
                p.Nombre = propiedades[0];
                p.Cantidad = propiedades[1];
                this.Productos.Add(p);
            }
        }
    }
}
