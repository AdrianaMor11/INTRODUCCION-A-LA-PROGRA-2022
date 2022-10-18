using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1057021
{
    internal class Automovil
    {

        private int modelo;
        private double precio;
        private string marca;
        private bool disponible;
        private double tipoCambioDolar;
        private double descuentoAplicado;

        public Automovil()
        {
            this.modelo = 2019;
            this.precio = 10000.00;
            this.marca = "";
            this.disponible = false;
            this.tipoCambioDolar = 7.50;
            this.descuentoAplicado = 0.00;
        }

        public void DefinirModelo(int unModelo)
        {
            this.modelo = unModelo;
        }

        public void DefinirPrecio(double unPrecio)
        {
            this.precio = unPrecio;
        }

        public void DefinirMarca(string unaMarca)
        {
            this.marca = unaMarca;
        } 

        public void DefinirTipoCambio(double TipoCambio)
        {
            this.tipoCambioDolar = TipoCambio;
        }

        public void CambiarDisponibilidad()
        {
            if (this.disponible)
            {
                this.disponible = false;
            }
            else
            {
                this.disponible = true;
            }
        }

        public string MostrarDisponibilidad()
        {
            if (this.disponible)
            {
                return "Disponible";
            }
            else
            {
                return "No se encuentra disponible actualmente";
            }
        }

        public string MostrarInformacion()
        {
            double precioDolares = this.precio / this.tipoCambioDolar;

            return "Marca: " 
                + this.marca 
                + " \nModelo: " 
                + this.modelo 
                + "\nPrecio de venta: Q" 
                + this.precio 
                + "\nPrecio en dólares $" 
                + precioDolares
                + " \nDisponibilidad: " 
                + this.MostrarDisponibilidad();

        }

        public void AplicarDescuento(double miDescuento)
        {
            this.descuentoAplicado = miDescuento;
            this.precio -= this.descuentoAplicado;

            this.DefinirPrecio(this.precio);
        }

    }
}
