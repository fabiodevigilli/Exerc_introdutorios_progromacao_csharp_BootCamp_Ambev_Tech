using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_Repetição___Lista
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos alunos você deseja cadastrar? ");
            int qtdAlunos = Convert.ToInt32(Console.ReadLine());

             for (int i = 0; i <= qtdAlunos; i++)

            {

                var texto1 = @"Nome do Aluno: {0}
Idade:{1}
Turma:{2}";


              var textoFinal = string.Format(texto1
                  , Console.ReadLine()
                  , Console.ReadLine()
                  , Console.ReadLine());


            Console.WriteLine($@"Aluno Cadastrado: 
{textoFinal}");
                Console.ReadLine();
            }
        }
    }
}
