using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        /// <summary>
        /// Metodo que converte moeda em real para uma moeda alvo:
        /// DOLAR
        /// YEN
        /// BITCOIN
        /// 
        /// 
        /// </summary>
        /// <param name="minhaMoeda">Moeda em valor real</param>
        /// <param name="moedaAlvo">Alvo em que a moeda será convertida</param>
       
        /// <summary>
        /// RETORNAR O VALOR CONVERTIDO EM DOLAR
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        public static string ConversaoDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
        }
        /// <summary>
        /// RETORNA O VALOR CONVERTIDO EM EURO
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        public static string ConversaoEuro(double meuNumero)
        {
            return (meuNumero / 4.53).ToString("C2", CultureInfo.CreateSpecificCulture("fr-FR"));
        }
        /// <summary>
        /// RETORNA O VALOR CONVERTIDO EM YEN
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        public static string ConversaoYen(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("c", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        /// <summary>
        /// RETORNA O VALOR CONVERTIDO EM BITCOIN
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        public static string ConversaoBTC(double meuNumero)
        {
            return (meuNumero / 41997.10).ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC");
        }

    }
}

