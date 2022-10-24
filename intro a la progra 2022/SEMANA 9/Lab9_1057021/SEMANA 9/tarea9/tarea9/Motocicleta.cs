using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea9
{
    public class Motocicleta
    {
        private int Modelo { get; set; }
        private double Precio { get; set; }
        private string Marca { get; set; }
        private double Iva { get; set; }

        public Motocicleta()
        {
            this.Modelo = 2019;
            this.Precio = 1000;
            this.Marca = "";
            this.Iva = 0.12;
        }

        public string mostrarDatos()
        {
            return $"Modelo: {this.Modelo} \n Precio: {this.Precio} \n Marca: {this.Marca} \n IVA: {this.Iva}";
        }

        public void definirMarca(string marca)
        {
            this.Marca = marca;
        }

        public void definirPrecio(double precio)
        {
            this.Precio = precio;
        }

        public void definirModelo(int modelo)
        {
            this.Modelo = modelo;
        }

        public string definirIva(double iva)
        {
            if(iva > 0.00 && iva < 1)
            {
                this.Iva = iva;
                return "IVA valido";
            }

            return "IVA Invalido";
        }

        public double precioSinIva()
        {
            return this.Precio;
        }

        public double precioConIva()
        {
            return (this.Precio + (this.Precio * this.Iva));
        }

        public double devolverIva()
        {
            return this.Iva * this.Precio;
        }
    }
}
