using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias
{
    class Lavadora : Electrodomestico
    {
        // ATRIBUTOS
        private int carga;

        protected const int cargaDefecto = 5;

        // GETTERS Y SETTERS

        public int _Carga
        {
            get { return carga; }
            set { carga = value; }
        }


        // CONSTRUCTORES
        public Lavadora()
        {
            _PrecioBase = precioBaseDefecto;
            _Color = comprobarColor(colorDefecto, colorDisponible); ;
            _ConsumoEnergetico = comprobarConsumoEnergetico(consumoEnergeticoDefecto, letrasConsumoDisponible);
            _Peso = pesoDefecto;
            _Carga = cargaDefecto;
        }

        public Lavadora(int precioBase, int peso) : base(precioBase, peso)
        {
            _PrecioBase = precioBase;
            _Color = comprobarColor(colorDefecto, colorDisponible); ;
            _ConsumoEnergetico = comprobarConsumoEnergetico(consumoEnergeticoDefecto, letrasConsumoDisponible);
            _Peso = peso;
            _Carga = cargaDefecto;
        }

        public Lavadora(int precioBase, string color, char consumoEnergetico, int peso, int carga) : base(precioBase, color, consumoEnergetico, peso)
        {
            _PrecioBase = precioBase;
            _Color = comprobarColor(color, colorDisponible); ;
            _ConsumoEnergetico = comprobarConsumoEnergetico(consumoEnergetico, letrasConsumoDisponible);
            _Peso = peso;
            _Carga = carga;
        }

        // METODOS
		/*precioFinal ()():, si tiene una carga mayor de 30 kg, aumentara el precio 50
		€, sino es así no se incrementara el precio. Llama al método padre y
		añade el código necesario. Recuerda que las condiciones que hemos visto
		*/
        public int precioFinal()
        {
            if (_Carga > 30)
            {
                return _PrecioBase = base.precioFinal() + 50;
            }
            else
            {
                return _PrecioBase = base.precioFinal();
            }
        }
    }
}
