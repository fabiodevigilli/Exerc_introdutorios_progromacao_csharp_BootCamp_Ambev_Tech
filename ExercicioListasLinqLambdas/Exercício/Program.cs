using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeVendas.Controller;
using SistemaDeVendas.Model;




namespace SistemaDeVendas
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main (string[] args)
        {

            Menu();
          

        }

        /// <summary>
        /// Mostra o Menu
        /// </summary>
        /// <param name="mesEscolhido"></param>
        private static void Menu ()
        {
            var opcaoEscolhida = int.MinValue;
            while (opcaoEscolhida != 0)
            {
                Console.Clear();
                Console.WriteLine(@"Informe uma opção do menu:
1 - Listar Informações de Vendas
2 - Listar Vendas por período");
                opcaoEscolhida = int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (opcaoEscolhida)
                {
                    case 1:
                        Console.Clear();
                        MostrarTodosOsDados();
                        break;
                    case 2:
                        Console.Clear();
                        MostrarDadosPorPeriodo();
                        break;
                                      
                    default:
                        return;
                         

                }
            }
        }
        /// <summary>
        /// Opção 2 do Menu, Retorna as informações de vendas conforme o mês selecionado 
        /// </summary>
        private static void MostrarDadosPorPeriodo()
        {
            var mesEscolhido = 0;
            Console.WriteLine(@"Informe o mês do qual você deseja obter as informações de vendas. Digite números de 1 a 12, conforme mês desejado:");
            mesEscolhido = int.Parse(Console.ReadLine());
            vendasController.VendasPeriodo(mesEscolhido).ForEach(x => FormataDados(x));
            Console.WriteLine($"A média de vendas do mês {mesEscolhido} é de R$ {vendasController.MediaVendas(mesEscolhido).ToString("c")}");
            Console.WriteLine($"O total de vendas do mês {mesEscolhido} é de R$ {vendasController.SomaVendas(mesEscolhido).ToString("c")}");
            Console.ReadKey();


        }
        /// <summary>
        /// Mostra todos os Dados de Vendas
        /// </summary>
        private static void MostrarTodosOsDados()
        {
            vendasController.contextDB.ListaDeVendas.ForEach(x => FormataDados(x));
            Console.ReadKey();
        }
        /// <summary>
        /// Formata os dados a serem impressos
        /// </summary>
        /// <param name="vendasModel"></param>
        private static void FormataDados(VendasModel vendasModel)
        {
            string template = "ID: {0,3} Nome: {1,-50} Valor: {3,7} Data: {2,10}";
            string TextoFormatado = string.Format(template, vendasModel.ID, vendasModel.NomeCarro, vendasModel.DataVenda.ToShortDateString(), vendasModel.Valor.ToString("c"));
        Console.WriteLine(TextoFormatado);
        }





    }
}
