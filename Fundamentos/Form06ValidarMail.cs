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
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidaMail_Click(object sender, EventArgs e)
        {
            string mail = this.txtMail.Text;

            // Verificar si el correo electrónico contiene @
            if (mail.Contains("@") == false)
            {
                MessageBox.Show("El correo electrónico debe contener @", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que @ no esté al principio ni al final
            if (mail.StartsWith("@") || mail.EndsWith("@"))
            {
                MessageBox.Show("El símbolo @ no puede estar al principio ni al final del correo electrónico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que solo haya una @
            if (mail.IndexOf("@") != mail.LastIndexOf("@"))
            {
                MessageBox.Show("El correo electrónico debe contener solo una @", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que haya un punto
            if (!mail.Contains("."))
            {
                MessageBox.Show("El correo electrónico debe contener un punto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que haya un punto después de @
            int indexAtSymbol = mail.IndexOf("@");
            int indexDotAfterAt = mail.IndexOf(".", indexAtSymbol);
            if (indexDotAfterAt == -1)
            {
                MessageBox.Show("Debe haber un punto después del símbolo @", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar el dominio de 2 a 4 caracteres
            string dominio = mail.Substring(indexDotAfterAt + 1);
            if (dominio.Length < 2 || dominio.Length > 4)
            {
                MessageBox.Show("El dominio del correo electrónico debe tener entre 2 y 4 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todas las validaciones pasan, mostrar mensaje de éxito
            MessageBox.Show("El correo electrónico es válido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
