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
            ForEachComSplit();
           
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
    

    private static void ForEachComSplit()
    {
        var conteudoDoTexto = "qualquer coisa que foi escrita no quadro";
        Console.WriteLine("Informe a palavra a ser buscada: ");
        var palavra = Console.ReadLine();
            // SEPARAMOS O TEXTO POR PALAVRAS ATRAVÉS DO ESPAÇO DO SPLIT
        var conteudoTextSplit = conteudoDoTexto.Split(' ');
            foreach (var item in conteudoTextSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
            }
            Console.ReadKey();
    }


    }
}
