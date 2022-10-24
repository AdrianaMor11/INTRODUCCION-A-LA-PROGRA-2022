using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_1057021
{
    public partial class Form1 : Form
    {

        Automovil objAutomovil = new Automovil();

        public Form1()
        {
            InitializeComponent();
        }

        private void guardarInformacion(object sender, EventArgs e)
        {
            objAutomovil.DefinirModelo(int.Parse(inModelo.Text));
            objAutomovil.DefinirPrecio(int.Parse(inPrecio.Text));
            objAutomovil.DefinirMarca(inMarca.Text);
            objAutomovil.DefinirTipoCambio(double.Parse(inCambio.Text));

            txtMostrarInformacion.Text = objAutomovil.MostrarInformacion();

            MessageBox.Show("Registro Creado con éxito");
        }

        private void CambiarDisponibilidad(object sender, EventArgs e)
        {
            objAutomovil.CambiarDisponibilidad();
            txtMostrarInformacion.Text = objAutomovil.MostrarInformacion();

        }

        private void AplicarDescuento(object sender, EventArgs e)
        {
            objAutomovil.AplicarDescuento(double.Parse(inDescuento.Text));
            txtMostrarInformacion.Text = objAutomovil.MostrarInformacion();

        }
    }
}
