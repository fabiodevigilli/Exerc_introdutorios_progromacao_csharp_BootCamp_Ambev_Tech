using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N2.Model;


namespace N2
{
    class Program
    {
        static void Main(string[] args)
        {
            Formulario();
        }

        public static void Formulario()
        {
            Console.WriteLine("Quantas pessoas você deseja cadastrar: ");
            var qtdPessoas = int.Parse(Console.ReadLine());
            var listaPessoas = new List<Pessoa>();

            for (int i = 0; i < qtdPessoas; i++)
            {
                Console.WriteLine("Qual o nome da pessoa?");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual a idade da pessoa?");
                var idade = int.Parse(Console.ReadLine());
                Console.WriteLine(@"Qual o gênero desta pessoa? Digite:
M - Masculino
F - Feminino
O - Outro");
                var genero = Console.ReadKey().KeyChar;
                Console.WriteLine("\nQual a altura?");
                var altura = double.Parse(Console.ReadLine());
                



                listaPessoas.Add(new Pessoa()
                {
                    Nome = nome,
                    Idade = idade,
                    Genero = genero,
                    Altura = altura,
                    
                });
                Console.Clear();
            }
            listaPessoas.ForEach(Indice => Console.WriteLine($@"--------- Usuário Cadastrado ----------
Nome: {Indice.Nome}
Idade: {Indice.Idade}
Gênero: {Indice.Genero}
Altura: {Indice.Altura}"));
            Console.ReadLine();



        }

    }
}







