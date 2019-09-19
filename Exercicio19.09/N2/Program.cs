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
        }

        public static void Formulario()
        {
            Console.WriteLine("Quantas pessoas você deseja cadastrar: ");
            var qtdPessoas = int.Parse(Console.ReadLine());

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
                Console.WriteLine("Qual a altura?");
                var altura = double.Parse(Console.ReadLine());

                var listaPessoas = new List<Pessoa>();
                listaPessoas.Add(new Pessoa()
                {
                    Nome = nome,
                    Idade = idade,
                    Genero = genero,
                    Altura = altura
                });
                                                                                 
            }

            


        }
    }
}






