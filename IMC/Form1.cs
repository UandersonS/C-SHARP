using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(txtAltura.Text, CultureInfo.InvariantCulture);
            double peso = double.Parse(txtPeso.Text, CultureInfo.InvariantCulture);
            double IMC = peso / (altura * altura);
            //txtResultado.Text = $"Seu IMC é de = {IMC}";

            if (IMC < 18.5)
            {
                txtResultado.Text = $"Seu IMC é de = {IMC.ToString("F2")}\r\n" +
                    $"Peso abaixo do normal";
            }
            else if ((IMC == 18.5) || (IMC <= 25.00))
            {
                txtResultado.Text = $"Seu IMC é de = {IMC.ToString("F2")}\r\n" +
                    $"Peso normal";
            }
            if ((IMC > 25.00) || (IMC <= 30.00))
            {
                txtResultado.Text = $"Seu IMC é de = {IMC.ToString("F2")}\r\n" +
                    $"Você está no Sobrepeso";
            }
            else if ((IMC > 30.00) || (IMC <= 35))
            {
                txtResultado.Text = $"Seu IMC é de = {IMC.ToString("F2")}\r\n" +
                    $"Grau de Obesidade 1";
            }
            if ((IMC > 35.00) || (IMC <= 40.00))
            {
                txtResultado.Text = $"Seu IMC é de = {IMC.ToString("F2")}\r\n" +
                    $"Grau de Obesidade 2";
            }
            else if (IMC > 40.00)
            {
                txtResultado.Text = $"Seu IMC é de = {IMC.ToString("F2")}\r\n" +
                    $"Obesidade Grau 3";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void lblTitulo_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
