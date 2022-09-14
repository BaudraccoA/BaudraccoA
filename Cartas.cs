using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_Españolas
{
    public class Cartas
    {
        // Propiedades
        public int Numeros;
        public string Palo;

        public static string [] Palos = { "Oro", "Copa", "Espada", "Basto" };
        public static int Limites_Cartas_Palo = 12;



        public Cartas(int numeros, string palo)
        {
            Numeros = numeros;
            Palo = palo;
            
        }
        override
        public string ToString()
        {
            return " " + Numeros  +  (Palo  +  " ").ToString();
              
        }
    }
}
