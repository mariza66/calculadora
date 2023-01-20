using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19janeiro
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

        private void botao8_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBoxResultado.Text + "8";
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBoxResultado.Text +"7"; 
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBoxResultado.Text + "9";
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBoxResultado.Text + "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBoxResultado.Text + "5";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBoxResultado.Text + "6";
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBoxResultado.Text + "1";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBoxResultado.Text + "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBoxResultado.Text + "3";
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBoxResultado.Text + "0";
        }

        private void botaoSoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            textBoxResultado.Text = "";
            operacao = "soma";
            labelOperacao.Text = "+";

           
        }

        private void botaoSub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            textBoxResultado.Text = "";
            operacao = "subtracao";
            labelOperacao.Text = "-";


        }

        private void botaoMult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            textBoxResultado.Text = "";
            operacao = "multiplicacao";
            labelOperacao.Text = "x";
        }

        private void botaoDiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            textBoxResultado.Text = "";
            operacao = "divisao";
            labelOperacao.Text = "/";
        }

        private void botaoCE_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacao.Text = "";
        }

        private void botaoResult_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "soma")
            {
                textBoxResultado.Text = Convert.ToString(valor1 + valor2);
            }
            if (operacao == "subtracao")
            {
                textBoxResultado.Text = Convert.ToString(valor1- valor2);
            }
            if(operacao == "multiplicao")
            {
                textBoxResultado.Text = Convert.ToString(valor1 * valor2);
            }
            if (operacao == "divisao")
            {
                textBoxResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }
    }
   
}
