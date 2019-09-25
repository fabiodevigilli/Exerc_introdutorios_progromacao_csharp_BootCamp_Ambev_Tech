using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> vendas = new List<Venda>()
            {
                new Venda()
                {
                    
                    Produto = "XIAOMI",
                    Quantidade = 8,
                    Valor = 1200
                    

                },
                new Venda()
                {
                    Produto = "SLIM 3500 APP",
                    Quantidade = 5,
                    Valor = 2800.96
                },

                new Venda()
                {
                    Produto = "Iphone",
                    Quantidade = 1,
                    Valor = 9999.99
                }

            };
            Console.WriteLine("Média de produtos vendidos neste mês");
            Console.WriteLine(vendas.Average(x => x.Quantidade));
            Console.WriteLine("Media de vendas em R$:");
            Console.WriteLine(vendas.
                //Aqui realizamos o cálculo de quantidade * valor = total de venda do produto
                Average(x => (x.Quantidade * x.Valor)).ToString("c"));
            //Average divide o valor total pela quantidade de itens em nossa lista
            Console.ReadKey();

        }
    }
}
