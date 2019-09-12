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
            /* Var. para gravar a quantidade alunos a serem cadastrados e 
              var. para concatenar com o nome do aluno */
            
            Console.WriteLine("Você deseja visualizar a tabuada de qual número? ");
            var numTab = Convert.ToInt32(Console.ReadLine());
             for (int i = 0; i <= numTab; i++)

            {
                var result = numTab * i;                
                var texto1 = @"X{i} = {i}";
                
              var textoFinal = string.Format(Conso)

            Console.ReadKey();
            }
        }
    }
}
