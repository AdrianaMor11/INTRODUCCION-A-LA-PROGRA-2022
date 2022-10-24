using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea9
{
    public partial class Form1 : Form
    {
        public Form1(Motocicleta motocicleta)
        {
            InitializeComponent();
            Motocicleta = motocicleta;
        }

        public Motocicleta Motocicleta { get; }

        private void GuardarInformacion(object sender, EventArgs e)
        {
            this.Motocicleta.definirMarca(marca.Text);
            this.Motocicleta.definirModelo(int.Parse(modelo.Text));
            this.Motocicleta.definirIva(double.Parse(iva.Text));
            this.Motocicleta.definirPrecio(double.Parse(precio.Text));
        }

        private void mostrarDatos(object sender, EventArgs e)
        {
            mostrarInformacion.Text = this.Motocicleta.mostrarDatos();
            precioSinIva.Text = String.Concat("Q ", this.Motocicleta.precioSinIva());
            montoIva.Text = String.Concat("Q ", this.Motocicleta.devolverIva());
            precioConIva.Text = String.Concat("Q ", this.Motocicleta.precioConIva());
        }
    }
}
