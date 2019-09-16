using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoOList
{
    class Program
    {
        static List<string> minhaListaPulgmatica = new List<string>()
            {
                "Felipe",
                "Irineu",
                "Serilop"
            };
        static void Main(string[] args)
        {
            
            AdicionarItensALista();
            ListaInformacoes();        
            Console.ReadKey();


        }
        /// <summary>
        /// O método adiciona um nome na lista 
        /// </summary>
        private static void AdicionarItensALista()
        {
            Console.WriteLine("Informe um nome:");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.Clear();
        }
        
        /// <summary>
        /// Mostra a Lista
        /// </summary>
        private static void ListaInformacoes()
        {
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
