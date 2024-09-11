using Abstraccion;
using BE;
using BLL;

namespace Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = resultado.ToString();
        }

        double resultado = 0, valor = 0;
        IOperacion operacion;

        private void siete_Click(object sender, EventArgs e)
        {
            valor = 7;
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            valor = 8;
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            valor = 9;
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            valor = 4;
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            valor = 5;
        }

        private void seis_Click(object sender, EventArgs e)
        {
            valor = 6;
        }

        private void uno_Click(object sender, EventArgs e)
        {
            valor = 1;
        }

        private void dos_Click(object sender, EventArgs e)
        {
            valor = 2;
        }

        private void tres_Click(object sender, EventArgs e)
        {
            valor = 3;
        }

        private void cero_Click(object sender, EventArgs e)
        {
            valor = 0;
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            resultado = 0;
            valor = 0;
            operacion = null;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            BLLCalcular bLLCalcular = new BLLCalcular();

            if (operacion== null)
            {
                MessageBox.Show("Debe seleccionar una operacion");
                return;
            }
            if (!bLLCalcular.PuedeCalcular(operacion, valor))
            {
                MessageBox.Show("No se puede dividir por CERO");
                return;
            }
            resultado = bLLCalcular.Calcular(operacion, resultado, valor);
            textBox1.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operacion = new Multiplicar();
        }

        private void bntDividir_Click(object sender, EventArgs e)
        {
            operacion = new Dividir();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            operacion = new Sumar();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operacion = new Restar();
        }
    }
}