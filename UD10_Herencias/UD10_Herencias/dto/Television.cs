using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias
{
    class Television : Electrodomestico
    {
        // ATRIBUTOS
        private int resolucion;
        private Boolean sincronizadorTDT;

        private const int resolucionDefecto = 20;
        private const Boolean sincronizadorTDTDefecto = false;

        // GETTERS Y SETTERS
        public int _Resolucion
        {
            get { return resolucion; }
            set { resolucion = value; }
        }

        public Boolean _SincronizadorTDT
        {
            get { return sincronizadorTDT; }
            set { sincronizadorTDT = value; }
        }

        public Television()
        {
            _PrecioBase = precioBaseDefecto;
            _Color = comprobarColor(colorDefecto, colorDisponible);
            _ConsumoEnergetico = comprobarConsumoEnergetico(consumoEnergeticoDefecto, letrasConsumoDisponible);
            _Peso = pesoDefecto;
            _Resolucion = resolucionDefecto;
            _SincronizadorTDT = sincronizadorTDTDefecto;
        }

        public Television(int precioBase, int peso) : base(precioBase, peso)
        {
            _PrecioBase = precioBase;
            _Color = comprobarColor(colorDefecto, colorDisponible); 
            _ConsumoEnergetico = comprobarConsumoEnergetico(consumoEnergeticoDefecto, letrasConsumoDisponible);
            _Peso = peso;
            _Resolucion = resolucionDefecto;
            _SincronizadorTDT = sincronizadorTDTDefecto;
        }

        public Television(int precioBase, string color, char consumoEnergetico, int peso, int resolucion, Boolean sincronizadorTDT) : base(precioBase, color, consumoEnergetico, peso)
        {
            _PrecioBase = precioBase;
            _Color = comprobarColor(color, colorDisponible); 
            _ConsumoEnergetico = comprobarConsumoEnergetico(consumoEnergetico, letrasConsumoDisponible);
            _Peso = peso;
            _Resolucion = resolucion;
            _SincronizadorTDT = sincronizadorTDT;
        }

        // METODOS
        public int precioFinal()
        {
            int precioFinal = base.precioFinal();

            if (_Resolucion > 40)
            {
                precioFinal = precioFinal + ((precioFinal / 30) *100);
            }
            if (_SincronizadorTDT == true)
            {
                precioFinal = precioFinal + 50;
            }
            return _PrecioBase = precioFinal;
        }
    }
}
