using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias
{
    class Cuenta
    {
        // ATRIBUTOS
        private string titular;
        private double cantidad;

        // GETERS Y SETERS
        public string TitularCuenta
        {
            get { return titular; }
            set { titular = value; }
        }

        public double CantidadCuenta
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        // TOSTRING

        public override string ToString()
        {
            Console.WriteLine("------- CUENTA -------");
            Console.WriteLine(" TITULAR: " + TitularCuenta + "\n SALDO ACTUAL: " + CantidadCuenta);
            Console.WriteLine("\n");
            return base.ToString();
        }


        // CONSTRUCTORES
        public Cuenta(string titular)
        {
            TitularCuenta = titular;
            CantidadCuenta = 0;
        }

        public Cuenta(string titular, double cantidad)
        {
            TitularCuenta = titular;
            CantidadCuenta = cantidad;
        }

        // METODOS

        public void Ingresar(double cantidad)
        {
            // se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, no se hará nada.
            if (cantidad > 0)
            {
                this.cantidad = this.cantidad + cantidad;
            }
        }

        public void Retirar(double cantidad)
        {
            // se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.
            if ((this.cantidad - cantidad) < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad = this.cantidad - cantidad;
            }
        }
    }
}
