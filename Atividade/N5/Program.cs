using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- INFORME UMA PALAVRA -----------");
            var palavra = Console.ReadLine();
            Console.WriteLine($"A palavra {palavra} COMEÇA COM A LETRA '{palavra[0]}' E TERMINA COM A LETRA '{palavra[palavra.Length-1]}'");
            Console.ReadKey();
        }
    }
}
