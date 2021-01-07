using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UD10_Herencias
{
    class Password
    {
        // ATRIBUTOS
        private int longitud;
        private string contraseña;

        // GETTER SETTER
        public int _Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        public string _Contraseña
        {
            get { return contraseña; }
        }



        // CONSTRUCTORES
        public Password()
        {
            _Longitud = 8;
            this.contraseña = generarPassword(_Longitud);
        }

        public Password(int longitud)
        {
            _Longitud = longitud;
            this.contraseña = generarPassword(longitud);
        }


        // METODOS
        public string generarPassword(int longitud)
        {
            // genera una contraseña cogiendo valores aleatorios del string contraseñaRandom
            Random Aleatorio = new Random();
            const string contraseñaRandom = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789¡!@#%*._,?¿-";

            return new string(Enumerable.Repeat(contraseñaRandom, longitud).Select(s => s[Aleatorio.Next(s.Length)]).ToArray());
        }

        public Boolean esFuerte(string contraseña)
        {
            char[] contraseñaArray = contraseña.ToArray(); // convertimos la password en una array
            string mayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string minusculas = "abcdefghijklmnopqrstuvwxyz";
            string numeros = "0123456789";
            int nMayus = 0;
            int nMinus = 0;
            int nNumeros = 0;

            for (int x = 0; x < contraseñaArray.Length; x++)
            {
                // Por cada caracter en el array(contraseña) comparamos si esta en la lista de mayusculas, minusculas o numeros y las vamos contando si existen. 

                if (minusculas.IndexOf(contraseñaArray[x]) > 0)
                {
                    nMinus++;
                }
                if (mayusculas.IndexOf(contraseñaArray[x]) > 0)
                {
                    nMayus++;
                }
                if (numeros.IndexOf(contraseñaArray[x]) > 0)
                {
                    nNumeros++;
                }
            }

            if (nMayus > 2 && nMinus > 1 && nNumeros > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }       
    }
}
