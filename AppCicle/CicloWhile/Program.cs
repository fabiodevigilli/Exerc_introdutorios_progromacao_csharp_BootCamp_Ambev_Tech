using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            string nome = string.Empty;
            int idade = 0;
            string nomeCidade = string.Empty;
            string nomeSchool = string.Empty;

            while (AskToContinue() == 1)
            {
                nome = AskName();
                nomeCidade = AskCity();
                nomeSchool = AskNameSchool();
                idade = AskAge(nome);
            }
            Console.WriteLine($"\r\nSuas informações: \r\nNome: {nome} \r\nIdade: {idade} \r\nCidade de Nascimento: {nomeCidade}\r\nNome da Escola: {nomeSchool}");
            Console.ReadKey();
        }

        /// <summary>
        /// Retorna o texto inicial
        /// </summary>
         private static void ShowInitAppText()
           {
                Console.WriteLine("---------------------");
                Console.WriteLine("-- Seja bem-vindo! --");
                Console.WriteLine("---------------------");
            }
        /// <summary>
        /// Retorna a pergunta inicial e o valor da resposta
        /// </summary>
        /// <returns></returns>
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? sim(1) não(2)");
            return  int.Parse(Console.ReadKey().KeyChar.ToString());
            
        }
        /// <summary>
        /// Lê a idade e retorna a verificação da maioridade
        /// </summary>
        /// <returns></returns>
        private static int AskAge(string nome)
        {

            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
                Console.WriteLine($"{nome}, você pode consumir bebida alcoólica!");
            else
                Console.WriteLine($"{nome}, você não pode consumir bebida alcoólica!");

            return idade;
            
        }
        /// <summary>
        /// Retorna o nome informado
        /// </summary>
        /// <returns></returns>
        private static string AskName()
        {
            Console.WriteLine("\r\nQual o seu nome?");
            return Console.ReadLine();
        }

        /// <summary>
        /// Retorna o nome da cidade
        /// </summary>
        /// <returns></returns>
        private static string AskCity()
        {
            Console.WriteLine("Qual a sua cidade de nascimento:");
            return Console.ReadLine();
        }
        /// <summary>
        /// Retorna o nome da Escola
        /// </summary>
        /// <returns></returns>
        private static string AskNameSchool()
        {
            Console.WriteLine("Qual o nome da escola aonde você estudou?");
            return Console.ReadLine();
        }



    }


    }


