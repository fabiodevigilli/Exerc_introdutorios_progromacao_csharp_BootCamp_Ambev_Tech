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
            Console.WriteLine("Informe o texto:");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)

            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
