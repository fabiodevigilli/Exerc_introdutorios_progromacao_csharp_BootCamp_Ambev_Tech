using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 30;
            Hebeficar(out y);
            Console.WriteLine(y);
            Console.ReadKey();

            int resultadoConversao = 0;
            int.TryParse("145", out resultadoConversao);

            List<int> numeros = new List<int>();
            Random rdm = new Random();
           

            for (int i = 0; i < 1000; i++)
            {
                int valorGerado = rdm.Next(100);

                bool eRepetido = numeros.Contains(valorGerado);
                    if (!numeros.Contains(valorGerado)) 
                {
                    numeros.Add(valorGerado);
                }
                    else
                {
                    w--;
                }
                numeros.Add(valorGerado);

            }
            Console.ReadLine();
                 
        }


           private static void Hebeficar (out int idade)
            {
                idade = 16000;
            }
            
        }
    }

