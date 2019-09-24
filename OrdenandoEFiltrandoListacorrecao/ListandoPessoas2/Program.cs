using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Controller;
using ListandoPessoas2.Model;

namespace ListandoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CARREGAMOS NOSSA CAIXA DE FERRAMENTAS DE PESSOAS
            //PODEMOS AGORA LISTA E E DEMAIS FUNCIONALIDADES
            PessoaController pessoaController
                //NESTA PARTE AO INICIAR EM MEMÓRIA
                //INICIAMOS O CONSTRUTOR
                = new PessoaController();
            pessoaController.ListaDePessoasPublic.ForEach(i => MostraInformacoes(i));
            Console.ReadKey();
            MostraIdentificador("Lista ordenada por nome");
                pessoaController.GetPessoasOrdenadaAsc().ForEach(i => MostraInformacoes(i));
                Console.ReadKey();
            MostraIdentificador("Lista ordenada por Data de Nascimento, ordem decrescente");
            pessoaController.GetPessoasOrdenadaDescPelaDataNascimento().ForEach(i => MostraInformacoes(i));
            Console.ReadKey();
            MostraIdentificador("Lista das pessoas com mais de R$ 500,00 em carteira");
            pessoaController.GetPessoasComMaisPilasNaCarteira().ForEach(i => MostraInformacoes(i));
            Console.ReadKey();
            MostraIdentificador("Lista das pessoas com mais de 18 anos");
            pessoaController.GetPessoasComIdadeMaiorA().ForEach(i => MostraInformacoes(i));
            Console.ReadKey();
            MostraIdentificador("Lista das pessoas com menos de 16 anos");
            pessoaController.GetPessoasComIdadeMenorA().ForEach(i => MostraInformacoes(i));
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que mostra no console formatado nosso objeto
        /// "Pessoa"
        /// </summary>
        /// <param name="pessoa"></param>
        private static void MostraInformacoes(Pessoa pessoa)
        {
            //Nosso template que apresenta as informações formatadas
            string template = "Id {0,3} Nome {1,-10} Nascimento {2,10} Carteira {3,5}";//Número negativo formata à esquerda
            //Recebemos as informações formatadas com o string format
            string textoFormatado =
                //string.Format é usado para formatar as strings
                //deixando nosso texto padrão apresentável
                string.Format(
                    //Nosso primeiro parametro é o template que usamos
                    template, pessoa.Id, pessoa.Nome, pessoa.DataNascimento.ToShortDateString(), pessoa.Carteira.ToString("C")) ;
                    //Após infromar o template, temos os parametros
                    //este metodo espera um array de parâmetros ou seja
                    //podemos passar muitos parametros nele
            Console.WriteLine(textoFormatado);

           
        }
        /// <summary>
        /// MÉTODO QUE RETORNA UM TÍTULO PADRÃO PARA AS LISTAGENS
        /// </summary>
        /// <param name="nomeAcao"></param>
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("------------- {0,20} -------------", nomeAcao));
        }

    }
}

