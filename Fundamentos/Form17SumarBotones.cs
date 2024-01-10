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
    public partial class Form17SumarBotones : Form
    {
        List<Button> botones;
        int suma;
        public Form17SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            foreach (Button boton in this.panel1.Controls)
            {
                this.botones.Add(boton);
                boton.Click += SumarNumeros;
            }
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            this.suma = 0;
            this.textBox1.Text = suma.ToString();
            Random random = new Random();
            foreach (Button boton in this.botones)
            {
                int aleatorio = random.Next(1, 50);
                boton.Text = aleatorio.ToString();
            }
        }

        void SumarNumeros(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int numero = int.Parse(btn.Text);
            this.suma += numero;
            this.textBox1.Text = suma.ToString();
        }
    }
}
