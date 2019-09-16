using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício18anos
{
    class Program
    {
        static void Main(string[] args)
        {
            Listar18Anos();
            Console.ReadKey();
        }
        private static void Listar18Anos()
        { 
        var listaNomes = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
        var listaNomesSp = listaNomes.Split(';');


            foreach (var item in listaNomesSp)
            {

                var infos = item.Split(',');

                var nome = infos[0].Split(':')[1];
                var idade = int.Parse(infos[1].Split(':')[1]);
                if (idade >= 18)
                    Console.WriteLine($"{nome},{idade}");
            }      
            }
}
}
