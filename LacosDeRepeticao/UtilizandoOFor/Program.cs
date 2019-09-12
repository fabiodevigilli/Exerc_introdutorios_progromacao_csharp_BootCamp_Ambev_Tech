using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoOFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "The girl has no name";
            var countFind = 0;
            Console.WriteLine("Encontre uma palavra de três caracteres: ");
            var palavra = Console.ReadLine();
            for (int i = 0; i < (nome.Length - 2); i++)
            {
                var palavraParaComparar = nome[i].ToString() +
                                          nome[i + 1].ToString() +
                                          nome[i + 2].ToString();
                if (palavra == palavraParaComparar)
                    countFind++;
            }
                Console.WriteLine($"Quantidade total de {palavra}: {countFind}");
                Console.ReadKey();
            
            
        }
    }
}
