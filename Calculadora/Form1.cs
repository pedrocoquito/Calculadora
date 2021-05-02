using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPerdaPeso_Click(object sender, EventArgs e)
        {
            try
            {
                double ultimaPesagem = Convert.ToDouble(txtUltimaPesagem.Text);
                double pesoNascimento = Convert.ToDouble(txtPesoNascimento.Text);

                double resultado = (((ultimaPesagem * 100) / pesoNascimento - 100)* -1);

                MessageBox.Show("A perda ponderal foi de " + String.Format("{0:0.00}", resultado) + "%");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado, verifique as informações fornecidas.");
            }
        }

        private void btnGanhoPeso_Click(object sender, EventArgs e)
        {
            try
            {
                double pesoAtual = Convert.ToDouble(txtPesoAtual.Text);
                double pesoAnterior = Convert.ToDouble(txtPesoAnterior.Text);
                int intervaloConsultas = Convert.ToInt32(txtIntervaloConsulta.Text);

                double resultado = ((pesoAtual - pesoAnterior) / intervaloConsultas) * 1000;

                MessageBox.Show("O ganho de peso foi de " + String.Format("{0:0.00}", resultado) + " gramas/dia.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado, verifique as informações fornecidas.");
            }
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);

                double p = Math.Pow(altura, 2);
                double resultado = peso / p;

                MessageBox.Show("O IMC é de: " + String.Format("{0:0.00}", resultado) + ".");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado, verifique as informações fornecidas.");
            }
        }

        private void validaTexto(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal d;
            if (!decimal.TryParse(tb.Text, out d))
            {
                if (tb.Text.Length > 0)
                {
                    tb.Text = tb.Text.Substring(0, (tb.TextLength - 1));
                }

                MessageBox.Show("Apenas número ou ','");

                return;
            }
        }
    }
}
