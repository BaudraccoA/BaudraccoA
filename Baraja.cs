using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_Españolas
{
    public class Baraja
    {
        public Cartas[] cartas;
        public int posSiguiente;

        public static int Num_Cartas = 40;
        


        public Baraja()
        {
         cartas = new Cartas[Num_Cartas];
         posSiguiente = 0;
         CrearBaraja();
         Barajar();

        }

        public void CrearBaraja()
        {
            string[] palo= Cartas.Palos;

            for (int i = 0; i < palo.Length; i++)
            {
                for (int j = 0; j < Cartas.Limites_Cartas_Palo; j++)
                {
                    if ( ! (j == 7 || j == 8))
                    {
                        if (j >= 9)
                        {
                            cartas[(i * (Cartas.Limites_Cartas_Palo - 2)) + (j-2)] = new Cartas(j + 1, palo[i]);
                        }
                        else
                        {
                            cartas[i * (Cartas.Limites_Cartas_Palo-2) + j] = new Cartas(j + 1, palo[i]);
                        }
                    }
                }
            }


        }
        public void Barajar()
        {
            {
                int aleatoria;
                Cartas c;

                for (int i = 0; i < cartas.Length; i++)
                {
                    aleatoria = new Random().Next(0, Num_Cartas - 1);

                    c = cartas[i];
                    cartas[i] = cartas[aleatoria];
                    cartas[aleatoria] = c;
                }
                posSiguiente = 0;
            }
        }
        public Cartas SiguinteCarta()
        {   
            Cartas? c = null;
            
            if (posSiguiente == Num_Cartas)
            {
                Console.WriteLine("Ya no hay mas cartas, vuelva a barajar");
            }
            else
            {
                c = cartas[posSiguiente++];
                

            }

            return c;
        }

        public int CartasDisponibles()
        {
            return Num_Cartas - posSiguiente;
        }
        public Cartas[]? DarCartas(int numCartas)
        {
            if (numCartas > Num_Cartas)
            {
                Console.WriteLine("No se puede dar mas cartas de las que hay en la baraja");

            }
            else
            {
                if (CartasDisponibles() < Num_Cartas)
                {
                    Console.WriteLine("No hay suficiente cartas que mostrar");
                }
                else
                {
                    Cartas[] cartasDar = new Cartas[numCartas];
                    for (int i = 0; i < cartasDar.Length; i++)
                    {
                        cartasDar[i] = SiguinteCarta();
                    }
                    return cartasDar;
                }

            }               
            return null;
        } 
        public void CartasDelMonton()
        {
            if (CartasDisponibles() == Num_Cartas)
            {
                Console.WriteLine("No se ha sacado ninguna carta");
            }
            else
            {
                for (int i = 0; i < posSiguiente; i++)
                {
                    Console.WriteLine(cartas[i]);
                }
            }

        }
        public void MostrarBaraja()
        {

            if (CartasDisponibles() == 0)
            {
                Console.WriteLine("No hay cartas que mostrar");
            }
            else
            {
                for (int i = posSiguiente; i < cartas.Length; i++)
                {
                    Console.WriteLine(cartas[i]);
                }
            }
        }
    }
}
