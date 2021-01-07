using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias
{
    class Selector
    {
        // selector de ejercicios. ejecuta métodos según el ejercicio que se quiera comprobar.
        public static void SelectorEjercicio()
        {
            Console.WriteLine("Indica el ejercicio que quieres ejecutar: (Número del 1 al 9)");
            string ejercicio = Console.ReadLine();

            switch (ejercicio) //ejecutamos el método según el ejercicio.
            {
                case "1":
                    Cuenta cuenta1 = new Cuenta("Don José", 500000);
                    Cuenta cuenta2 = new Cuenta("Don Pepito");

                    Console.WriteLine("PRINTAMOS DOS CUENTAS");
                    cuenta1.ToString();
                    cuenta2.ToString();
                    Console.WriteLine("INGRESAMOS A DON PEPITO Y PRINTAMOS");
                    cuenta2.Ingresar(43.12);
                    cuenta2.ToString();
                    Console.WriteLine("RETIRAMOS 40 A DON PEPITO Y PRINTAMOS");
                    cuenta2.Retirar(40);
                    cuenta2.ToString();
                    Console.WriteLine("RETIRAMOS 20 A DON PEPITO Y PRINTAMOS");
                    cuenta2.Retirar(20);
                    cuenta2.ToString();
                    break;
                case "2":
                    TestPersona.Test();
                    break;
                case "3":
                    TestPassword.Test();
                    break;
                case "4":
                    //Electrodomestico o1 = new Electrodomestico();
                    //Electrodomestico o2 = new Electrodomestico(56, 100);
                    //Electrodomestico o3 = new Electrodomestico(1000, "gris", 'C', 3);
                    //Console.WriteLine("--------electro1-------");
                    //Console.WriteLine("Precio: " + o1._PrecioBase);
                    //Console.WriteLine("Color: " + o1._Color);
                    //Console.WriteLine("Letra: " + o1._ConsumoEnergetico);
                    //Console.WriteLine("Peso: " + o1._Peso);
                    //Console.WriteLine("-------electro2--------");
                    //Console.WriteLine("Precio: " + o2._PrecioBase);
                    //Console.WriteLine("Color: " + o2._Color);
                    //Console.WriteLine("Letra: " + o2._ConsumoEnergetico);
                    //Console.WriteLine("Peso: " + o2._Peso);
                    //Console.WriteLine("--------electro3-------");
                    //Console.WriteLine("Precio: " + o3._PrecioBase);
                    //Console.WriteLine("Color: " + o3._Color);
                    //Console.WriteLine("Letra: " + o3._ConsumoEnergetico);
                    //Console.WriteLine("Peso: " + o3._Peso);
                    //Console.WriteLine("--------cambioPrecio-------");
                    //Console.WriteLine("--------electro1-------");
                    //o1.precioFinal();
                    //Console.WriteLine("Precio: " + o1._PrecioBase);
                    //Console.WriteLine("--------electro2-------");
                    //o2.precioFinal();
                    //Console.WriteLine("Precio: " + o2._PrecioBase);
                    //Console.WriteLine("--------electro3-------");
                    //o3.precioFinal();
                    //Console.WriteLine("Precio: " + o3._PrecioBase);

                    //Lavadora l1 = new Lavadora();
                    //Lavadora l2 = new Lavadora(56, 100);
                    //Lavadora l3 = new Lavadora(1000, "rojo", 'C', 3, 5);
                    //Console.WriteLine("--------lav1-------");
                    //Console.WriteLine("Precio: " + l1._PrecioBase);
                    //Console.WriteLine("Color: " + l1._Color);
                    //Console.WriteLine("Letra: " + l1._ConsumoEnergetico);
                    //Console.WriteLine("Peso: " + l1._Peso);
                    //Console.WriteLine("Carga: " + l1._Carga);
                    //Console.WriteLine("-------lav2--------");
                    //Console.WriteLine("Precio: " + l2._PrecioBase);
                    //Console.WriteLine("Color: " + l2._Color);
                    //Console.WriteLine("Letra: " + l2._ConsumoEnergetico);
                    //Console.WriteLine("Peso: " + l2._Peso);
                    //Console.WriteLine("Carga: " + l2._Carga);
                    //Console.WriteLine("--------lav3-------");
                    //Console.WriteLine("Precio: " + l3._PrecioBase);
                    //Console.WriteLine("Color: " + l3._Color);
                    //Console.WriteLine("Letra: " + l3._ConsumoEnergetico);
                    //Console.WriteLine("Peso: " + l3._Peso);
                    //Console.WriteLine("Carga: " + l3._Carga);
                    //Console.WriteLine("--------cambioPrecio-------");
                    //Console.WriteLine("--------lav1-------");
                    //l1.precioFinal();
                    //Console.WriteLine("Precio: " + l1._PrecioBase);
                    //Console.WriteLine("-------lav2-------");
                    //l2.precioFinal();
                    //Console.WriteLine("Precio: " + l2._PrecioBase);
                    //Console.WriteLine("--------lav3-------");
                    //l3.precioFinal();
                    //Console.WriteLine("Precio: " + l3._PrecioBase);

                    //Television t1 = new Television();
                    //Television t2 = new Television(56, 100);
                    //Television t3 = new Television(10, "rojo", 'F', 1, 100, false);
                    //Console.WriteLine("--------tv1-------");
                    //Console.WriteLine("Precio: " + t1._PrecioBase);
                    //Console.WriteLine("Color: " + t1._Color);
                    //Console.WriteLine("Letra: " + t1._ConsumoEnergetico);
                    //Console.WriteLine("Peso: " + t1._Peso);
                    //Console.WriteLine("Resolucion: " + t1._Resolucion);
                    //Console.WriteLine("TDT: " + t1._SincronizadorTDT);
                    //Console.WriteLine("-------tv2--------");
                    //Console.WriteLine("Precio: " + t2._PrecioBase);
                    //Console.WriteLine("Color: " + t2._Color);
                    //Console.WriteLine("Letra: " + t2._ConsumoEnergetico);
                    //Console.WriteLine("Peso: " + t2._Peso);
                    //Console.WriteLine("Resolucion: " + t2._Resolucion);
                    //Console.WriteLine("TDT: " + t2._SincronizadorTDT);
                    //Console.WriteLine("--------tv3-------");
                    //Console.WriteLine("Precio: " + t3._PrecioBase);
                    //Console.WriteLine("Color: " + t3._Color);
                    //Console.WriteLine("Letra: " + t3._ConsumoEnergetico);
                    //Console.WriteLine("Peso: " + t3._Peso);
                    //Console.WriteLine("Resolucion: " + t3._Resolucion);
                    //Console.WriteLine("TDT: " + t3._SincronizadorTDT);
                    //Console.WriteLine("--------cambioPrecio-------");
                    //Console.WriteLine("--------tv1-------");
                    //t1.precioFinal();
                    //Console.WriteLine("Precio: " + t1._PrecioBase);
                    //Console.WriteLine("-------tv2-------");
                    //t2.precioFinal();
                    //Console.WriteLine("Precio: " + t2._PrecioBase);
                    //Console.WriteLine("--------tv3-------");
                    //t3.precioFinal();
                    //Console.WriteLine("Precio: " + t3._PrecioBase);

                    TestElectrodomestico.Test();


                    break;
                case "5":
                        
                    break;
                case "6":
                        
                    break;
                case "7":
                        
                    break;
                case "8":
                        
                    break;
                case "9":
                        
                    break;
                default:
                    Console.WriteLine("ERROR: Debes introducir un número del 1 al 9.");
                    SelectorEjercicio(); // llamamos otra vez al selector.
                    break;
            }


            // comprobamos si queres ejecutar más ejercicios
            Console.WriteLine("\n \n ¿Quieres comprobar otra vez algún ejercicio? si || no ");
            string salir = Console.ReadLine();

            if (salir == "si") SelectorEjercicio();
            else System.Environment.Exit(1);
        }
    }
}
