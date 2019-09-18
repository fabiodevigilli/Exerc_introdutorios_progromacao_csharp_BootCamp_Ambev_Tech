using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Metodos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Arvore();
            Console.ReadKey();
            CalculoArea();
            Console.ReadKey();
            ListaCervejas();
            Console.ReadKey();
            ListaMarcasCarros();
            Console.ReadKey();

        }

        /// <summary>
        /// MÉTODO MOSTRA UMA ÁRVORE ANIMADA
        /// </summary>
        public static void Arvore()
        {
            

            Console.WriteLine(@"    ()   
   (  )  
  (    )  
 (      ) 
 (      ) 
    ||/º  
    ||   
    ||   
  º/||                           
__|_||____________________________");
            Thread.Sleep(70);
            Console.Clear();
            Console.WriteLine(@"    ()   
   (  )  
  (    )  
 (      ) 
 (      ) 
    ||/  
    || º  
    ||   
  º/||                           
__|_||____________________________");
            Thread.Sleep(70);
            Console.Clear();
            Console.WriteLine(@"    ()   
   (  )  
  (    )  
 (      ) 
 (      ) 
    ||/  
    ||   
    || º  
  º/||                           
__|_||____________________________");
            Thread.Sleep(70);
            Console.Clear();
            Console.WriteLine(@"    ()   
   (  )  
  (    )  
 (      ) 
 (      ) 
    ||/  
    ||   
    ||   
  º/|| º                          
__|_||____________________________");
            Thread.Sleep(70);
            Console.Clear();
            Console.WriteLine(@"    ()   
   (  )  
  (    )  
 (      ) 
 (      ) 
    ||/  
    ||   
    ||   
  º/||                           
__|_||_o___________________________");
            Thread.Sleep(70);
            Console.Clear();
            Console.WriteLine(@"    ()   
   (  )  
  (    )  
 (      ) 
 (      ) 
    ||/  
    ||   
    ||      o 
    ||      |/º                    
____||______|______________________");






        }

        /// <summary>
        /// O MÉTODO CALCULA A ÁREA
        /// </summary>
        public static void CalculoArea()
        {

            var tipo = "0";
            double bse, altura, result;
            Console.WriteLine(@"Qual o tipo de ambiente cuja área deve ser calculada? Digite: 
1 - Para QUADRADO
2 - Para RETÂNGULO 
3 - Para TRIÂNGULO");
            tipo = Console.ReadLine();
            result = 0;
          
                switch (tipo)
                {
                    case "1":
                        Console.WriteLine("Qual a medida dos lados em metros?");
                        altura = Convert.ToDouble(Console.ReadLine());
                        result = altura * altura;
                        break;
                    case "2":
                        Console.WriteLine("Qual é a medida da altura em metros?");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Qual é a medida da base em metros?");
                        bse = Convert.ToDouble(Console.ReadLine());
                        result = bse * altura;
                        break;
                    case "3":
                        Console.WriteLine("Qual é a medida da altura em metros?");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Qual é a medida da base em metros?");
                        bse = Convert.ToDouble(Console.ReadLine());
                        result = bse * altura;
                        break;
                    default:
                        Console.WriteLine("VOCÊ NÃO SELECIONOU UMA OPÇÃO VÁLIDA!");
                        break;
                }
            if (result > 0)
                Console.WriteLine($"A área total é de {result}m²");
            else
            {
                Console.WriteLine(@"Ainda deseja efetuar o cálculo?
1 - SIM
2 - NÃO");
                var resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "1":
                        CalculoArea();
                        break;
                    case "2":
                        Console.WriteLine("APERTE QUALQUER TECLA PARA SAIR.");
                        break;
                }   

            }
            
             }
        /// <summary>
        /// IMPRIME UMA LISTA DE CERVEJAS
        /// </summary>
        public static void ListaCervejas()
        {
            var listaCervejas = new List<string>();
            listaCervejas.Add("Stella Artois");
            listaCervejas.Add("Boehmia");
            listaCervejas.Add("Norteña");
            listaCervejas.Add("Patagonia");
            listaCervejas.Add("Budweiser");
            Console.WriteLine("------------- LISTA DE CERVEJAS ------------");
            listaCervejas.ForEach(itemCerveja => Console.WriteLine(itemCerveja));


        }
        /// <summary>
        /// IMPRIME UMA LISTA DE MARCAS DE CARROS
        /// </summary>
        public static void ListaMarcasCarros()
        {
            var listaCarros = new List<string>();
            listaCarros.Add("Fiat");
            listaCarros.Add("Renault");
            listaCarros.Add("Kia");
            listaCarros.Add("Hyundai");
            listaCarros.Add("Honda");
            Console.WriteLine("------------- LISTA DE MARCAS DE CARROS ------------");
            listaCarros.ForEach(itemCarros => Console.WriteLine(itemCarros));
        }
        }

    }




