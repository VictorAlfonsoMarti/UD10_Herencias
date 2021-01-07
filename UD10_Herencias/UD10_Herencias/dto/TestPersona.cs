using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias
{
    class TestPersona
    {
        public static void Test()
        {
            // pido por pantall los valores
            Console.WriteLine("------- TEST PERSONAS -------");
            Console.WriteLine("Escribe el nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribe la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el sexo: H || M ");
            char sexo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Escribe el peso: ");
            int peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe la altura: ");
            int altura = Convert.ToInt32(Console.ReadLine());

            // asigno los valor
            Persona p1 = new Persona(nombre, edad, sexo, peso, altura);
            Persona p2 = new Persona(nombre, edad, sexo);
            Persona p3 = new Persona();

            // comrpuebo el peso ideal
            Console.WriteLine("--------- PESO IDEAL ---------");
            Console.WriteLine("Nº -1 = Inferior al peso ideal.");
            Console.WriteLine("Nº 0 = Dentro del peso ideal.");
            Console.WriteLine("Nº 1 = Superior al peso ideal.");

            Console.WriteLine("Objeto 1 " + p1.calcularIMC());
            Console.WriteLine("Objeto 2 " + p2.calcularIMC());
            Console.WriteLine("Objeto 3 " + p3.calcularIMC());

            // indico si es mayor de edad
            Console.WriteLine("--------- MAYORIA DE EDAD ---------");
            Console.WriteLine("Objeto 1 " + p1.esMayorDeEdad());
            Console.WriteLine("Objeto 2 " + p2.esMayorDeEdad());
            Console.WriteLine("Objeto 3 " + p3.esMayorDeEdad());

            // muestra informacion de cada objeto
            Console.WriteLine("--------- INFORMACION ---------");
            Console.WriteLine("\n Objeto 1");
            p1.toString();
            Console.WriteLine("\n Objeto 2");
            p2.toString();
            Console.WriteLine("\n Objeto 3");
            p3.toString();

        }
    }
}
