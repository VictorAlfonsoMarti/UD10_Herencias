using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias
{
    class Electrodomestico
    {
        //ATRIBUTOS
        private int precioBase;
        private string color;
        private char consumoEnergetico;
        private int peso;

        protected const int precioBaseDefecto = 100;
        protected const string colorDefecto = "blanco";
        protected const char consumoEnergeticoDefecto = 'F';
        protected const int pesoDefecto = 5;

        protected string[] colorDisponible = new string[] { "blanco", "negro", "rojo", "azul", "gris", "BLANCO", "NEGRO", "ROJO", "AZUL", "GRIS" };
        protected string letrasConsumoDisponible = "ABCDEF";

        //GETTERS Y SETTERS
        public int _PrecioBase
        {
            get { return precioBase; }
            set { precioBase = value; }
        }
        public string _Color
        {
            get { return color; }
            set { color = value; }
        }
        
        public char _ConsumoEnergetico
        {
            get { return consumoEnergetico; }
            set { consumoEnergetico = value; }
        }

        public int _Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        //CONSTRUCTORES
        public Electrodomestico()
        {
            _PrecioBase = precioBaseDefecto;
            _Color = colorDefecto;
            _ConsumoEnergetico = consumoEnergeticoDefecto;
            _Peso = pesoDefecto;
        }

        public Electrodomestico(int precioBase, int peso)
        {
            _PrecioBase = precioBase;
            _Color = colorDefecto;
            _ConsumoEnergetico = consumoEnergeticoDefecto;
            _Peso = peso;
        }

        public Electrodomestico(int precioBase, string color, char consumoEnergetico, int peso)
        {
            _PrecioBase = precioBase;
            _Color = comprobarColor(color, colorDisponible); ;
            _ConsumoEnergetico = comprobarConsumoEnergetico(consumoEnergetico, letrasConsumoDisponible);
            _Peso = peso;
        }

        //METODOS
        protected string comprobarColor(string color, string[] colorDisponible)
        {
            Boolean existe = false;
            for (int x = 0; x < colorDisponible.Length; x++)
            {
                if (colorDisponible[x].Equals(color))
                {
                    existe = true;
                    break;
                }
            }

            if (existe == false)
            {
                return colorDefecto;
            }
            return color;
        }

        // chekea que la letra de consumo energetico este dentro del string de posibles letras.
        protected char comprobarConsumoEnergetico(char letra, string lista)
        {
            if (lista.IndexOf(letra) < 0)
            {
                return consumoEnergeticoDefecto;
            }
            else
            {
                return letra;
            }
        }
        
        public int precioFinal()
        {
            int precioFinal = 0;

            // aumentamos valor segun letra de consumo energetico
            switch (this.consumoEnergetico)
            {
                case 'A':
                    precioFinal = precioFinal + 100;
                    break;
                case 'B':
                    precioFinal = precioFinal + 80;
                    break;
                case 'C':
                    precioFinal = precioFinal + 60;
                    break;
                case 'D':
                    precioFinal = precioFinal + 50;
                    break;
                case 'E':
                    precioFinal = precioFinal + 30;
                    break;
                case 'F':
                    precioFinal = precioFinal + 10;
                    break;
                default:
                    goto case 'F';
                    break;
            }

            // aumentamos valor segun su peso
            switch (this.peso)
            {
                case int n when (n > 0 && n <= 19):
                    precioFinal = precioFinal + 10;
                    break;
                case int n when (n > 20 && n <= 49):
                    precioFinal = precioFinal + 50;
                    break;
                case int n when (n > 50 && n <= 79):
                    precioFinal = precioFinal + 80;
                    break;
                case int n when (n > 80):
                    precioFinal = precioFinal + 100;
                    break;
            }

            // asignamos el nuevo valor a precio
            return this.precioBase = this.precioBase + precioFinal;
        }
    }
}
