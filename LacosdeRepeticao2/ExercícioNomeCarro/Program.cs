using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioNomeCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            NomeCarro();
            Console.ReadKey();

        }
        static void NomeCarro()
        {
            var listaCarros = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
            var listaCarrosSpl = listaCarros.Split(';');
            foreach (var item in listaCarrosSpl)
            {
                Console.WriteLine(item.Split(',')[0]);
                
            }
            Console.WriteLine("Informe o modelo do carro cujas informações devem ser exibidas:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaCarrosSpl)
            {
                var infos = item.Split(',');
                var nome = infos[0].Split(':')[1];
                var marca = infos[1].Split(':')[1];
                var ano = infos[2].Split(':')[1];
                if (nomeBusca == nome)
                {
                    Console.WriteLine($"O {nome} é da {marca}, produzido em {ano}");
                }
           }
        }
    }
}
