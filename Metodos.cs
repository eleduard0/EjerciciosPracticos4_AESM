using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos4_AESM
{
    public class Metodos
    {
        public void Arreglos() 
        {
            // Respuesta inciso a) //
            int[,] t = new int[2, 3];

            // Respuesta inciso b) //
            Console.WriteLine($"Son {t.GetLength(0)} filas");


            // Respuesta inciso c) //
            Console.WriteLine($"Son {t.GetLength(1)} columnas");

            // Respuesta incico d) //
            Console.WriteLine($"Son {t.GetLength(0)*t.GetLength(1)} elementos");

            // Respuesta inciso e) //
            for (int i = 0; i<t.GetLength(1); i++)
            {
                Console.WriteLine(t[1,i]);
            }
            
            // Respuesta inciso f) //
            for (int i = 0; i<t.GetLength(0); i++)
            {
                Console.WriteLine(t[i,1]);
            }

            // Respuesta inciso g) //
            t[0,1] = 0;

            // Respuesta inciso h) //
            t[0, 1] = 0;
            t[0, 2] = 0; t[1, 0] = 0;
            t[1, 1] = 0; t[1, 2] = 0;

            /* Respuesta inciso i) */
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j= 0; j < t.GetLength(1); j++)
                {
                    t[i, j] = 0;
                }
            }
            /* Respuesta inciso j) */
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    t[i, j] = int.Parse(Console.ReadLine());
                }
            }
            /* Respuesta inciso k) */




        }
    }
}
