using System.Globalization;

namespace Calculadora_II
{
    public partial class Form1 : Form
    {

        decimal valor1 = 0;
        decimal valor2 = 0;

        string operacao = "";

       

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "Mult";
                TxtOpercao.Text = "*";

            }
            
        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoN0_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "0";
        }

        private void botaoN1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void botaoN2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void botaoN3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void botaoN4_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void botaoN5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void botaoN6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void botaoN7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void botaoN9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void botaoPonto_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + ".";
        }

        private void botaoMais_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "Soma";
                TxtOpercao.Text = "+";

            }
            
        }
           

        private void botaoMenos_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "Subt";
                TxtOpercao.Text = "-";

            }
            
        }

        private void botaoDividir_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "Div";
                TxtOpercao.Text = "/";

            }
            
        }

        private void botaoIgual_Click(object sender, EventArgs e)

        {
            if(TxtResultado.Text != "")
            {
                valor2 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "Soma")
                {
                    TxtResultado.Text = Convert.ToString(valor1 + valor2, CultureInfo.InvariantCulture);
                }

                if (operacao == "Subt")
                {
                    TxtResultado.Text = Convert.ToString(valor1 - valor2, CultureInfo.InvariantCulture);
                }

                if (operacao == "Mult")
                {
                    TxtResultado.Text = Convert.ToString(valor1 * valor2, CultureInfo.InvariantCulture);
                }

                if (operacao == "Div")
                {
                    TxtResultado.Text = Convert.ToString(valor1 / valor2, CultureInfo.InvariantCulture);
                }

            }
            
        }

        private void TxtResultado_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void botaoCE_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
            TxtOpercao.Text = "";
        }

        private void botaoC_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            TxtResultado.Text = "";
            TxtOpercao.Text = "";
        }
    }
}