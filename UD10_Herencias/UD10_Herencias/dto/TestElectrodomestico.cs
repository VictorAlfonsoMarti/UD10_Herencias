using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias    
{
    class TestElectrodomestico
    {

        public static void Test()
        {
            object[] cadena;

            Electrodomestico o1 = new Electrodomestico();
            Electrodomestico o2 = new Electrodomestico(56, 30);
            Electrodomestico o3 = new Electrodomestico(70, "gris", 'A', 4);
            Lavadora l1 = new Lavadora();
            Lavadora l2 = new Lavadora(65, 10);
            Lavadora l3 = new Lavadora(100, "rojo", 'C', 3, 5);
            Television t1 = new Television();
            Television t2 = new Television(16, 90);
            Television t3 = new Television(20, "blanco", 'F', 1, 100, false);
            Television t4 = new Television(40, "rosa", 'G', 3, 45, true);
            
            cadena = new object[10] { o1, o2, o3, l1, l2, l3, t1, t2, t3, t4 };

            int precioFinalElectrodomestico = 0;
            int precioFinalLavadora = 0;
            int precioFinalTelevision = 0;


            foreach (Electrodomestico x in cadena)
            {
                x.precioFinal();
                if (x.GetType() == typeof(Lavadora))
                {
                    precioFinalLavadora = precioFinalLavadora + x._PrecioBase;
                }
                if (x.GetType() == typeof(Television))
                {
                    precioFinalTelevision = precioFinalTelevision + x._PrecioBase;
                }
                precioFinalElectrodomestico = precioFinalElectrodomestico + x._PrecioBase;
            }

            Console.WriteLine("Precio final de los electrodomesticos: {0}", precioFinalElectrodomestico);
            Console.WriteLine("Precio final de las lavadoras: {0}", precioFinalLavadora);
            Console.WriteLine("Precio final de las televisiones: {0}", precioFinalTelevision);

        }
    }
}
