namespace Ejercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void CalcularBilletes(ref int pesetas, ref string total, int numeroCalcular)
        {
            int cantidadBilletes;
            
            {
                if (pesetas >= numeroCalcular)
                {

                    cantidadBilletes = (pesetas / numeroCalcular);
                    if (numeroCalcular > 25)
                    {
                        total += cantidadBilletes + " billetes de" + numeroCalcular + " \n";
                    }
                    else
                    {
                        total += cantidadBilletes + " monedas de" + numeroCalcular + " \n";
                    }
                    pesetas = pesetas % numeroCalcular;
                }
            }
           
            
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int pesetas;
            string total;

            total = "";
            pesetas = int.Parse(txtCantidadPesetas.Text);
            lblPesetas.Text = "";
            CalcularBilletes(ref pesetas, ref total, 10000);
            CalcularBilletes(ref pesetas, ref total, 5000);
            CalcularBilletes(ref pesetas, ref total, 2000);
            CalcularBilletes(ref pesetas, ref total, 1000);
            CalcularBilletes(ref pesetas, ref total, 100);
            CalcularBilletes(ref pesetas, ref total, 25);
            lblPesetas.Text = total;
            /*
            if (pesetas > 5000)
            {
                cantidadBillete = (pesetas / 5000);
                total = cantidadBillete.ToString() + "billetes de 5000" + "\n";
                pesetas = pesetas % 5000;
                lblPesetas.Text += total;
            }
            if (pesetas > 2000)
            {
                cantidadBillete = (pesetas / 2000);
                total = cantidadBillete.ToString() + "billetes de 2000" + "\n";
                pesetas = pesetas % 2000;
                lblPesetas.Text += total;
            }
            if (pesetas > 1000)
            {
                cantidadBillete = (pesetas / 1000);
                total = cantidadBillete.ToString() + "billetes de 1000" + "\n";
                pesetas = pesetas % 1000;
                lblPesetas.Text += total;
            }
            if (pesetas > 100)
            {
                cantidadBillete = (pesetas / 100);
                total = cantidadBillete.ToString() + "billetes de 100" + "\n";
                pesetas = pesetas % 100;
                lblPesetas.Text += total;
            }
            if (pesetas > 25)
            {
                cantidadBillete = (pesetas / 25);
                total = cantidadBillete.ToString() + "monedas de 25" + "\n";
                pesetas = pesetas % 25;
                lblPesetas.Text += total;
            }
            */




        }
    }
}