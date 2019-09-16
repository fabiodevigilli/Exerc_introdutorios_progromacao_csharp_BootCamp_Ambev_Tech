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
           
            Console.Clear();
            Console.WriteLine("Informe um nome:");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Deseja informar mais valores? sim(S) não(N)");
            //TO LOWER CONVERTE PARA MINÚSCULO, TOUPPER
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AdicionarItensALista();
            else
            {

            }

        }
        
        /// <summary>
        /// Mostra a Lista
        /// </summary>
        private static void ListaInformacoes()
        {
            Console.WriteLine("ITENS DA LISTA:");
            foreach (var item in minhaListaPulgmatica) 
                Console.WriteLine($"Nome{item} foi adicionado a lista");
            Console.ReadKey();
        }
    }
}
