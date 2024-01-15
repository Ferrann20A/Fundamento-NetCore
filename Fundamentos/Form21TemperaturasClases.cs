using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form21TemperaturasClases : Form
    {
        //List<int> temperaturas;
        List<Mes> meses;
        public Form21TemperaturasClases()
        {
            InitializeComponent();
            //this.temperaturas = new List<int>();
            this.meses = new List<Mes>();
        }

        private void btnGenerarTemperaturas_Click(object sender, EventArgs e)
        {
            this.lstTemperaturas.Items.Clear();
            //this.temperaturas.Clear();
            //this.meses.Clear();
            Random random = new Random();
            DateTime fecha = DateTime.Parse("01/01/2024");
            for (int i = 1; i <= 12; i++)
            {
                int temp = random.Next(-20, 45);
                //this.temperaturas.Add(temp);
                string nombreMes = fecha.ToString("MMMM");
                fecha = fecha.AddMonths(1);
                //this.lstTemperaturas.Items.Add(nombreMes.ToUpper() + ": " + temp);
                //Mes mes = new Mes(nombreMes, temp);
                //this.lstTemperaturas.Items.Add(mes.GetMesCompleto());
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int maxima = 0;
            int minima = 0;
            int media = 0;
            int suma = 0;
            //foreach (Mes mes in meses)
            //{
            //    suma += mes.Temperatura;
            //    maxima = Math.Max(maxima, mes.Temperatura);
            //    minima = Math.Min(minima, mes.Temperatura);
            //}
            media = suma / this.meses.Count;
            this.txtTempMax.Text = maxima.ToString();
            this.txtTempMin.Text = minima.ToString();
            this.txtMediaAnual.Text = media.ToString();
        }
    }
}
