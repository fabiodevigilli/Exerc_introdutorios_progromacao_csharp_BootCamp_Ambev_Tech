using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicandoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        /// <summary>
        /// Reescrever o texto de forma vertical, navega sobre um array unidimensional de caracteres (string)
        /// </summary>
        private static void IniciandoForEach01()
        {
            Console.WriteLine("Informe o texto:");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)

            {
                if (item == 'e')
                    continue;
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
