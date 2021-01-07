using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias
{
    class Persona
    {
        // ATRIBUTOS
        private string nombre;
        private int edad;
        private string DNI;
        private char sexo;
        private double peso;
        private int altura;

        private const char sexoDefecto = 'M';
       


        // GETTERS Y SETTERS

        public string NombrePersona
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int EdadPersona
        {
            get { return edad; }
            set { edad = value; }
        }

        public char SexoPersona
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public double PesoPersona
        {
            get { return peso; }
            set { peso = value; }
        }

        public int AlturaPersona
        {
            get { return altura; }
            set { altura = value; }
        }

        // CONSTRUCTORES
        public Persona()
        {
            NombrePersona = "";
            EdadPersona = 0;
            SexoPersona = sexoDefecto;
            DNI = generarDNI();
            PesoPersona = 0;
            AlturaPersona = 0;
        }

        public Persona(string nombrePersona, int edadPersona, char sexoPersona)
        {
            NombrePersona = nombrePersona;
            EdadPersona = edadPersona;
            SexoPersona = comprobarSexo(sexoPersona);
            DNI = generarDNI();
        }

        public Persona(string nombrePersona, int edadPersona, char sexoPersona, double pesoPersona, int alturaPersona)
        {
            NombrePersona = nombrePersona;
            EdadPersona = edadPersona;
            SexoPersona = comprobarSexo(sexoPersona);
            DNI = generarDNI();
            PesoPersona = pesoPersona;
            AlturaPersona = alturaPersona;
        }

        // METODOS
        
        public int calcularIMC()
        {
            /* calculara si la persona esta en su peso ideal (peso en kg/(altura^2 en
                m)), si esta fórmula devuelve un valor menor que 20, la función devuelve un -1, si
                devuelve un número entre 20 y 25 (incluidos), significa que esta por debajo de su peso
                ideal la función devuelve un 0 y si devuelve un valor mayor que 25 significa que tiene
                sobrepeso, la función devuelve un 1. Te recomiendo que uses constantes para devolver
                estos valores.*/

            const int inferiorPesoIdeal = -1;
            const int exactoPesoIdeal = 0;
            const int superiorPesoIdeal = 1;

            double pesoIdeal = this.peso / (this.altura * 2);


            if ( pesoIdeal < 20)
            {
                return inferiorPesoIdeal;
            }
            else if (pesoIdeal > 25)
            {
                return superiorPesoIdeal;
            }
            else
            {
                return exactoPesoIdeal;
            }
        }


        public Boolean esMayorDeEdad()
        {
            //: indica si es mayor de edad, devuelve un booleano.

            if (this.edad < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected char comprobarSexo(char sexo)
        {
            // comprueba que el sexo introducido es correcto. Si no es  correcto, sera H. No sera visible al exterior.
            if (sexo != 'H' && sexo != 'M'){
                return 'H'; 
            }
            else
            {
                return sexo;
            }
        }

        public void toString()
        {
            Console.WriteLine("Nombre: {0}", this.nombre);
            Console.WriteLine("Edad: {0}", this.edad) ;
            Console.WriteLine("DNI: {0}", this.DNI);
            Console.WriteLine("Sexo: {0}", this.sexo);
            Console.WriteLine("Peso: {0}", this.peso);
            Console.WriteLine("Altura: {0}", this.altura);
        }

        public string generarDNI()
        {
            // genera un número aleatorio de 8 cifras, genera a partir de este su número su letra correspondiente. Este método sera invocado cuando se construya el objeto.
            Random random = new Random();
            int numero = random.Next(000000000, 1000000000);

            return Convert.ToString(numero) + generarLetraDNI(numero);
            
        }

        public string generarLetraDNI(int numeroDNI)
        {
            // genera la letra del dni segun numero de dni
            string letraDNI = "TRWAGMYFPDXBNJZSQVHLCKE"; // string para asignar letra al dni
            int moduloNumeros = numeroDNI % 23;

            return letraDNI[moduloNumeros].ToString();
        }
    }
}
