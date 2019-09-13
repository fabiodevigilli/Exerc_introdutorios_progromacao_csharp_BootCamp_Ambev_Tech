using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextoInicial();
            Console.ReadKey();
        }
        /// <summary>
        /// Dá boas vindas e solicita o nome
        /// </summary>
        private static void TextoInicial()
        {
            Console.WriteLine(@"------------- BEM-VINDO -------------
INFORME O SEU NOME COMPLETO:");
            var nomeCompleto = Console.ReadLine();
            Console.WriteLine($@"APERTE QUALQUER TECLA PARA SAIR, {nomeCompleto}");

        }
    }
}
