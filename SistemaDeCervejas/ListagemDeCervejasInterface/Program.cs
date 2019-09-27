using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ListagemDeCervejasInterface
{
    class Program
    {
        static CervejaController cervejas = new CervejaController();
   
        static void Main(string[] args)
        {
            double peso = 0;
            char respostaMenu;
            bool retornoMe;
            Console.WriteLine("Informe seu peso");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Informe o gênero atentando-se à situação de consumo.
1 - Homem, não ingeriu durante a refeição
2 - Mulher, não ingeriu durante a refeição
3 - Homem ou mulher que ingeriu durante a refeição");
            respostaMenu = char.Parse(Console.ReadKey().KeyChar.ToString());
            retornoMe = cervejas.TesteAlcool(peso, respostaMenu);
            if (retornoMe == true)
            {
                Console.WriteLine("Você não deve dirigir, será preso se pego!");
            }
            else Console.WriteLine("Uma possível blitz não acarretaria prisão");
            Console.ReadKey();
        }
        
    }
}
