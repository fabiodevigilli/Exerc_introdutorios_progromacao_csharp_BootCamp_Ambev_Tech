using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ VERIFICADOR ------------");
            var nome = AskName();
            AskIdade(nome);
            Console.ReadKey();


        }
        
        
        
        /// <summary>
         /// Verificar a maioridade e informa o usuário
         /// </summary>
         /// <param name="nome"></param>
        private static void AskIdade(string nome)
        {
            
            Console.WriteLine("INFORME A SUA IDADE:");
            var idade = int.Parse(Console.ReadLine());
            if (idade <= 18)
                Console.WriteLine($"PARABÉNS {nome}, VOCÊ JÁ ESTA NA FASE ADULTA.");
            else
                Console.WriteLine($"CALMA {nome}, TUDO AO SEU TEMPO LOGO VOCÊ TERÁ 18 ANOS DE IDADE");
            
        }
        
        private static string AskName()
        {
            Console.WriteLine("INFORME O SEU NOME:");
            var name = Console.ReadLine();
            return name; ;
        }

    }

}
