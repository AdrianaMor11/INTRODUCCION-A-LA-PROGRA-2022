using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void calcularBinario(object sender, MouseEventArgs e)
        {
            var numero = int.Parse(decimalBi.Text);
            long bin = 0;

            const int DIVISOR = 2;
            long digito = 0;

            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                bin += digito * (long)Math.Pow(10, j);
            }

            binario.Text = bin.ToString();
        }

        private void calcularHexadecimal(object sender, MouseEventArgs e)
        {
            var numero = int.Parse(decimalHexa.Text);

            hexadecimal.Text = Convert.ToString(numero, 16).ToUpper();
        }
    }
}
