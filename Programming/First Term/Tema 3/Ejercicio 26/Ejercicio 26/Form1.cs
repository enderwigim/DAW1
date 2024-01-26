namespace Ejercicio_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma;
            string resultado;

            resultado = "Serie: \n";
            suma = 0;

            for (int i = 3; i <= 99; i += 3)
            {
                resultado += i + ", ";
                if (i % 7 == 0)
                {
                    resultado += "\n";
                }
                suma += i;
            }
            resultado += "\nSuma: ";
            MessageBox.Show(resultado + suma.ToString());
        }
    }
}