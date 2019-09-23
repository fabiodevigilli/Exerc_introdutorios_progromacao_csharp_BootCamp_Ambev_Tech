using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Program
    {

        static void Main(string[] args)
        {

            ListaDePessoas();

        }

        private static void ListaDePessoas()
        {
            var listaDePessoas = new List<Pessoa>();
            listaDePessoas.Add(new Pessoa()
            {
                ID = 1,
                Nome = "Spears",
                DataNasc = DateTime.Parse("07/11/2004"),
                Carteira = 846.96


            }
                );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 2,
                Nome = "Swanson",
                DataNasc = DateTime.Parse("20/06/2003"),
                Carteira = 233.09


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 3,
                Nome = "Gay",
                DataNasc = DateTime.Parse("03/12/2001"),
                Carteira = 911.92


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 4,
                Nome = "Gregory",
                DataNasc = DateTime.Parse("02/01/2000"),
                Carteira = 469.01


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 5,
                Nome = "Olson",
                DataNasc = DateTime.Parse("18/07/2001"),
                Carteira = 261.90


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 6,
                Nome = "Garza",
                DataNasc = DateTime.Parse("01/04/2000"),
                Carteira = 360.41


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 7,
                Nome = "Sweet",
                DataNasc = DateTime.Parse("12/03/2003"),
                Carteira = 312.76


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 8,
                Nome = "Cline",
                DataNasc = DateTime.Parse("26/03/2002"),
                Carteira = 484.51


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 9,
                Nome = "Oliver",
                DataNasc = DateTime.Parse("05/07/2004"),
                Carteira = 513.76


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 10,
                Nome = "Vang",
                DataNasc = DateTime.Parse("10/07/2000"),
                Carteira = 271.05


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 11,
                Nome = "Maddox",
                DataNasc = DateTime.Parse("29/05/2004"),
                Carteira = 783.97


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 12,
                Nome = "Garrett",
                DataNasc = DateTime.Parse("03/06/2006"),
                Carteira = 154.11


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 13,
                Nome = "Mcintosh",
                DataNasc = DateTime.Parse("06/07/2006"),
                Carteira = 902.80


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 14,
                Nome = "Yang",
                DataNasc = DateTime.Parse("29/04/2005"),
                Carteira = 550.48


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 15,
                Nome = "Hendricks",
                DataNasc = DateTime.Parse("05/09/2003"),
                Carteira = 410.56


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 16,
                Nome = "Cain",
                DataNasc = DateTime.Parse("12/01/2002"),
                Carteira = 221.13


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 17,
                Nome = "Blackburn",
                DataNasc = DateTime.Parse("10/05/2000"),
                Carteira = 135.67


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 18,
                Nome = "Howe",
                DataNasc = DateTime.Parse("27/09/2005"),
                Carteira = 360.14


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 19,
                Nome = "Pratt",
                DataNasc = DateTime.Parse("18/09/2000"),
                Carteira = 991.83


            }
                            );
            listaDePessoas.Add(new Pessoa()
            {
                ID = 20,
                Nome = "Sherman",
                DataNasc = DateTime.Parse("20/02/2003"),
                Carteira = 667.00


            }
           );

            Console.WriteLine(@"
******************************* Lista de Informações Ordenadas por Nome *******************************
");
            listaDePessoas.OrderBy(x => x.Nome).ToList<Pessoa>().ForEach(i => Console.WriteLine($"ID: {i.ID} || Nome: {i.Nome} || Data de Nascimento: {i.DataNasc.ToString("dd/MM/yyyy")} || Cartera {i.Carteira}"));
            Console.WriteLine(@"
Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(@"
******************************* Lista de Informações Ordenadas por Nascimento *******************************
");
            listaDePessoas.OrderByDescending(x => x.DataNasc).ToList<Pessoa>().ForEach(i => Console.WriteLine($"ID: {i.ID} || Nome: {i.Nome} || Data de Nascimento: {i.DataNasc.ToString("dd/MM/yyyy")} || Cartera {i.Carteira}"));
            Console.WriteLine(@"
Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(@"
******************************* Lista de Informações Pessoas Com Mais de R$ 500,00 *******************************
");
            var listaCarteira = listaDePessoas.FindAll(x => x.Carteira > 500);
            listaCarteira.ForEach(i => Console.WriteLine($"ID: {i.ID} || Nome: {i.Nome} || Data de Nascimento: {i.DataNasc.ToString("dd/MM/yyyy")} || Cartera {i.Carteira}"));
            Console.WriteLine(@"
Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(@"
******************************* Lista de Informações Pessoas Com Mais de 18 anos *******************************
");
            var listaMaiores = listaDePessoas.FindAll(x => x.DataNasc.Year <= 2001);
            listaMaiores.ForEach(i => Console.WriteLine($"ID: {i.ID} || Nome: {i.Nome} || Data de Nascimento: {i.DataNasc.ToString("dd/MM/yyyy")} || Cartera {i.Carteira}"));
            Console.WriteLine(@"
Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(@"
******************************* Lista de Informações Pessoas Com Menos de 16 anos *******************************
");
            var listaMenores = listaDePessoas.FindAll(x => x.DataNasc.Year >= 2003);
            listaMenores.ForEach(i => Console.WriteLine($"ID: {i.ID} || Nome: {i.Nome} || Data de Nascimento: {i.DataNasc.ToString("dd/MM/yyyy")} || Cartera {i.Carteira}"));
            Console.WriteLine(@"
Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

