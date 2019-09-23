using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestoDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaDeFrutas = new List<Fruta>();
            
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212


            });
            
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95

            });

            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarela",
                Peso = 325

            });

#region Lista 1
            /// PARA ORDENAR:
            cestaDeFrutas.OrderByDescending(x => x.Nome).ToList<Fruta>().ForEach(i => Console.WriteLine($"ID {i.Id} Nome: {i.Nome}"));
            #endregion
#region Lista 2
            ///PARA REALIZAR FILTROS: 

            var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x => x.Nome);
            //Imprimimos os valores ordenados
            #endregion
#region Lista 3
            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"ID {i.Id} Peso {i.Peso} Nome {i.Nome} "));

            //outra forma de fazer um filtro 
             (from frutinha in cestaDeFrutas
              where frutinha.Peso > 100
              select frutinha).ToList<Fruta>().ForEach(i => Console.WriteLine($"Fruta Escolhida {i.Nome}"));
           

            Console.ReadKey();
            #endregion


            var mostrandoFind = cestaDeFrutas.Find(x => x.Cor == "Amarela" || x.Cor == "Vermelha");
            Console.WriteLine($"Id {mostrandoFind.Id} Nome {mostrandoFind.Nome}");
            var mostrandoFindAll = cestaDeFrutas.FindAll(x => x.Cor == "Amarela" || x.Cor == "Vermelha");
            mostrandoFindAll.ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome}"));

            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);

            foreach (var item in listaOrdenada)
                Console.WriteLine($"ID {item.Id} Nome {item.Nome}");

            Console.WriteLine("----------------------------- Find com order by");
            var cestaDeFrutasFindOrder = cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            Console.WriteLine($"Id {cestaDeFrutasFindOrder.Id}, Nome {cestaDeFrutasFindOrder.Nome}");
            
            Console.ReadKey();




        }
    }
}

