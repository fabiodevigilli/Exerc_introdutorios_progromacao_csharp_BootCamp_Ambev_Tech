using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMoeda
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {
            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(ConversaoDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(ConversaoEuro(minhaMoeda));
                    break;
                case "Yen":
                    Console.WriteLine(ConversaoYen(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(ConversaoBTC(minhaMoeda));
                    break;
                default:
                    Console.WriteLine("A opção selecionada não corresponde a nenhuma moeda conhecida por este software.");
                    break;
            }
        }
    }
}
