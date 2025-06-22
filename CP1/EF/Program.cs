using System;
using System.Collections.Generic;

namespace EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                Console.Write("Generando nuevo juego de Lotto con cinco Números... ");
                var lotto = new Lotto { FechaHora = DateTime.Now, Numeros = new List<Numero>() };
                var numeros = new HashSet<int>();
                var aleatorio = new Random();
                for (var orden = 0; orden < 5; orden++)
                {
                    var num = aleatorio.Next(41);
                    if (numeros.Contains(num))
                    {
                        orden--;
                    }
                    else
                    {
                        numeros.Add(num);
                        lotto.Numeros.Add(new Numero { Orden = orden, Num = num });
                    }
                }
                db.Lottos.Add(lotto);
                Console.WriteLine("Listo\n");

                Console.Write("Guardando cambios en la base de datos... ");

                Console.WriteLine("Listo\n");
                
                Console.WriteLine("Imprimiendo los juegos de Lotto y sus Números:\n");
            }
        }
    }
}
