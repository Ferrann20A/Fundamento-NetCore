namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //Solo escribiremos aqui
            this.txtNombre.Location = new Point(78, 20);
            //Tenemos tipos de datos primitivos, los primitivos
            //directamente se escriben
            this.txtNombre.Text = "Soy un texto";
            this.Width = 180;
            //Esto es una excepcion en la norma
            //Tener una clase estructura o final
            //No se instancia la clase, se utiliza.
            //Por ej, la clase color
            this.BackColor = Color.ForestGreen;
            //Pongamos que deseamos alinear el texto de una caja
            this.txtNombre.TextAlign = HorizontalAlignment.Right;
            //comentario
        }
    }
}
