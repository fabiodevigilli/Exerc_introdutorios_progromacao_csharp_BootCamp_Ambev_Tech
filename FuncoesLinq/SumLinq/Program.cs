using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomaInteirosLista();
            SomarInteiroPrimitivos();
            SomaBalaListaDeCriancas();
            Console.ReadKey();    
        }
        /// <summary>
        /// Método que mostra números inteiros por um tipo primitivo
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            //quando utilizamos "[]" em um tipo "primitivo" podemos criar uma coleção destes valores
            //alocação memoria para nossa coleção de valore e informamos a quantidade de posições que ela vai ocupar
            //memoria ocupada int * quantidade informada 
            int[] colecaoInteiros = new int[5] 
            //Aqui carregamos nossa coleção de valores 
            { 1, 2, 3, 4, 5 }; //VETOR

            //Aqui somamos os valores de nossa lista
            Console.WriteLine("Soma dos números inteiros por Array");
            Console.WriteLine(colecaoInteiros.Sum());
            Console.ReadKey();

        }
        /// <summary>
        /// Soma os números de uma lista dinâmica de inteiros 
        /// </summary>
        private static void SomaInteirosLista()
        {

            List<int> listaDeInteiros = new List<int>()
                {
                //Nossa coleção de valores
                1,2,3,4,5,7,8,9,10,11,12
            };
            Console.WriteLine("Soma de números inteiros por Lista Dinâmica");
            Console.WriteLine(listaDeInteiros.Sum());
            Console.ReadKey();
            
        }

        private static void SomaBalaListaDeCriancas()
        {
            //Nossa lista de crianças foi criada e carregada em memória 
            List<Crianca> criancas = new List<Crianca>()
            {
                //criando uma nova criança dentro da minha lista
                new Crianca()
                {
                    Nome = "Joazinho",
                    Balas = 9

                },
                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }

            };
            Console.WriteLine("Quantidade total de balas que as criancinhas levaram da venda");
            Console.WriteLine(criancas.Sum(x=>x.Balas));


        }
        

    }
}
