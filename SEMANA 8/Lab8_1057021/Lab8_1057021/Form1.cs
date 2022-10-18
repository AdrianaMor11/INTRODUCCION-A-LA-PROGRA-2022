using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab8_1057021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void seleccionarOpcion(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    contenedor.SelectedTab = sumatoria;
                    break;
                case 1:
                    contenedor.SelectedTab = tablas;
                    this.calcularTabla();
                    break;
                case 2:
                    contenedor.SelectedTab = perfecto;
                    break;
                default:

                    break;
            }
        }

        private void calcularTabla()
        {
            string cadena = "\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10\n";
            for (int i = 1; i <= 10; i++)
            {
                cadena += "\n"+i+"\t";
                for(int j = 1; j <= 10; j++)
                {
                    cadena += String.Format("{0}\t", (i * j));
                }

                cadena += "\n";
            }

            datosTabla.Text = cadena.ToString();
        }

        private void calcularSumatoria(object sender, KeyEventArgs e)
        {
            int numero = 0;
            int sumatoria = 0;

            if (int.TryParse(inNumeroSumatoria.Text, out numero))
            {
                for (var i = 0; i <= numero; i++)
                {
                    sumatoria += i;
                }
            }

            resultadoSumatoria.Text = sumatoria.ToString();
        }
    }
}
