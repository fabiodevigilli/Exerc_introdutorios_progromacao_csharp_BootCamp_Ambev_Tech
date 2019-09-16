using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeSemana1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            TextoInicial();
            Console.ReadKey();
                     
        }
        /// <summary>
        /// RETORNA O TEXTO DE BOAS VINDAS
        /// </summary>
        private static void TextoInicial ()
        {
            Console.WriteLine(@"--------------- SEJA BEM-VINDO ---------------
Aperte qualquer tecla para fechar.");

        }
        
    }
}
