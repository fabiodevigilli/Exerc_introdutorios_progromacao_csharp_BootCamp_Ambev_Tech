using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ForEachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeDecimais();
            Console.ReadKey();

        }
        /// <summary>
        /// Mostra a lista de Datas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();
            minhaLista.Add(new DateTime(2019, 09, 17));
            minhaLista.Add(new DateTime(2019, 09, 18));
            minhaLista.Add(new DateTime(2019, 09, 19));
            minhaLista.Add(new DateTime(2019, 09, 20).AddDays(99));
            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MMM/dd")));
           
        }
        /// <summary>
        /// Mostra a lista de marcas
        /// </summary>
        private static void ListaString()
            {
                var minhaLista = new List<string>();
                minhaLista.Add("XIOAMI");
                minhaLista.Add("IPHONE APPLE");
                minhaLista.Add("SAMSUNG");
                minhaLista.Add("NOKIA");
                //MUDOU A SINTAXER, MAS PERMANECE O MESMO, TRATA-SE DE UMA EXPRESSÃO LINQ
                minhaLista.ForEach(i => Console.WriteLine(i));
                /* É A MESMA COISA QUE O QUE ESTÁ ABAIXO:
                foreach (var item in minhaLista)
                {
                    Console.WriteLine(item);
                }         
                */


             
            }
        /// <summary>
        /// Mostra uma lista de inteiros
        /// </summary>
        private static void ListaInt()
        {
            var ListaInt = new List<int>();
            ListaInt.Add(1);
            ListaInt.Add(2);
            ListaInt.Add(3);
            ListaInt.Add(4);
            ListaInt.Add(5);
            ListaInt.Add(6);
            ListaInt.Add(7);
            ListaInt.Add(8);
            ListaInt.Add(9);
            ListaInt.Add(10);
            ListaInt.ForEach(itens => Console.WriteLine(itens));



            {

            }

        }

        /// <summary>
        /// Mostra a lista de números decimais
        /// </summary>
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();
            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C")+ " \n" + FNDD(meuDecimal)));

        }
        private static string FNDD(double meuNumero)
        {
            
            return (meuNumero / 4.5008).ToString("c", CultureInfo.CreateSpecificCulture("en-US"));
        }
        }
        
    }

