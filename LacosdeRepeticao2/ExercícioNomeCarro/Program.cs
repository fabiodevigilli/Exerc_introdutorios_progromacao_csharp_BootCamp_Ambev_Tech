using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioNomeCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            NomeCarro();
            Console.ReadKey();

        }
        static void NomeCarro()
        {
            // SALVA A LISTA DE INFORMAÇÕES
            var listaCarros = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
            // SPLIT QUEBRA AS LINHAS DE ACORDO COM O CARACTER IDENTIFICADO ;.
            // ESTÁ ASSINADO DENTRO DE UMA STRING QUE SERÁ UTILIZADA DE VETOR 
            var listaCarrosSpl = listaCarros.Split(';');
            // FOREACH PERCORRE O VETOR COM A VARIÁVEL ITEM
            foreach (var item in listaCarrosSpl)
            {
                //RETORNA A VARIÁVEL ITEM COM A PRIMEIRA INFORMAÇÃO ANTES DA PRIMEIRA VÍRGULA E IMPRIME NA TELA
                Console.WriteLine(item.Split(',')[0]);

            }
            Console.WriteLine("Informe o modelo do carro cujas informações devem ser exibidas:");
            var nomeBusca = Console.ReadLine();

            //PERCORRE CADA ITEM DO VETOR
            foreach (var item in listaCarrosSpl)
            {
                //QUEBRA A LINHA EM CADA VÍRGULA DO VETOR E GRAVA NA VARIÁVEL
                var infos = item.Split(',');
                //ASSINA A POSIÇÃO DE CADA VETOR, EM CADA VARIÁVEL, GRAVANDO APENAS O PRIMEIRO VALOR APÓS OS ":"
                var nome = infos[0].Split(':')[1];
                var marca = infos[1].Split(':')[1];
                var ano = infos[2].Split(':')[1];
                //COMPRARA SE A VARIÁVEL NOME ESTÁ DE ACORDO COM A INFORMAÇÃO BUSCADA
                if (nomeBusca == nome)
                {
                    //IMPRIME AS DEMAIS INFORMAÇÕES DO CARRO BUSCADO
                    Console.WriteLine($"O {nome} é da {marca}, produzido em {ano}");
                }
            }
        }
       
            

    }
}
