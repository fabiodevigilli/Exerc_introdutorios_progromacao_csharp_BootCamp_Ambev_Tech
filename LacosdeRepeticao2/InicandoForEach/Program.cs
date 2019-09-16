using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicandoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForEachComSplitList();
            Console.ReadKey();

        }
        /// <summary>
        /// Reescrever o texto de forma vertical, navega sobre um array unidimensional de caracteres (string)
        /// </summary>
        private static void IniciandoForEach01()
        {
            Console.WriteLine("Informe o texto:");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)

            {
                if (item == 'e')
                    continue;
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    

    private static void ForEachComSplit()
    {
            var conteudoDoTexto = "qualquer;coisa;que;estava;no;quadro;";
        Console.WriteLine("Informe a palavra a ser buscada: ");
        var palavra = Console.ReadLine();
            // SEPARAMOS O TEXTO POR PALAVRAS ATRAVÉS DO ESPAÇO DO SPLIT
        var conteudoTextSplit = conteudoDoTexto.Split(';');
            foreach (var item in conteudoTextSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
            }
            Console.ReadKey();
    }

        /// <summary>
        /// Exercícios com split e informando o nome
        /// </summary> 
        private static void ForEachExercitar()
        {
            Console.WriteLine("Informe seu nome");
            var conteudo = $"EXERCICIO.DE.FIXAÇÃO.QUALQUER.{Console.ReadLine()}";
            Console.WriteLine("Informe a palavra para realizar a busca: ");
            var palavra = Console.ReadLine();
            var conteudoSplit = conteudo.Split('.');
            foreach (var item in conteudoSplit)

            {
                if (palavra == item)
                
                    Console.WriteLine("Palavra encontrada com sucesso!");
                                
            }
            
        }
        /// <summary>
        /// APRESENTA OS NOMES DOS USUÁRIOS CADASTRADOS
        /// </summary>
        private static void ForEachComSplitList()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:75;nome:Eusebio,idade:29";
            var listaDeInformacoes = conteudo.Split(';');
            Console.WriteLine("Usuários cadastrados: ");
            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
                
            }
            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)

            {
                var informacoes = item.Split(',');
                var nome = informacoes[0].Split(':')[1];
                var idade = informacoes[1].Split(':')[1];
                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade.");
                }

            }

        }
    }
    
}
