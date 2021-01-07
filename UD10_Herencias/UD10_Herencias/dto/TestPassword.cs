using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias
{
    class TestPassword
    {
        public static void Test()
        {
            Console.WriteLine("---- TEST PASSWORD ----");

            //Crea un array de Passwords con el tamaño que tu le indiques por teclado
            Console.WriteLine("Indica cuantas contraseñas quieres crear:");
            string[] cadenaPasswords = new string[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("De qué tamaño quieres que sean las contraseñas:");
            int tamañoPasswords = Convert.ToInt32(Console.ReadLine());

            // Crea un bucle que cree un objeto para cada posición del array
            // Indica también por teclado la longitud de los Passwords (antes de bucle).
            // Crea otro array de booleanos donde se almacene si el password del array de Password es o no fuerte (usa el bucle anterior).
            // Al final, muestra la contraseña y si es o no fuerte (usa el bucle anterior). Usaeste simple formato:
            Boolean[] cadenaFuerte = new Boolean[cadenaPasswords.Length];

            for (int x = 0; x < cadenaPasswords.Length; x++)
            {
                Password contraseña = new Password(tamañoPasswords);
                cadenaPasswords[x] = contraseña._Contraseña; 
                cadenaFuerte[x] = contraseña.esFuerte(Convert.ToString(cadenaPasswords[x]));
                Console.WriteLine(cadenaPasswords[x] + " " + cadenaFuerte[x]);
            }
        }
    }
}
