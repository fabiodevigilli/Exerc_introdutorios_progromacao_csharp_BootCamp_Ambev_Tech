using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício.Model;
namespace Exercício.Controller
{
    class ListaDeVendasController
    {

        private VendasContext contextDB = new VendasContext();

        private static string VendasPeriodo()
        {
            var mesEscolhido = 0;
            Console.WriteLine(@"Informe o mês do qual você deseja obter as informações de vendas. 
 Digite números de 1 a 12, conforme mês desejado:");
            mesEscolhido = int.Parse(Console.ReadLine());
            
                      



        }
    }
}
