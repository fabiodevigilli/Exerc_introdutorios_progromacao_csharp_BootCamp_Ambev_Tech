using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;


namespace AcessandoDLLDeTereceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
            Console.ReadKey();
        }
        /// <summary>
        /// MOSTRA O MENU 
        /// </summary>
        private static void MenuSistema()
        {

            Console.WriteLine("Escolha uma das opções do menu: ");
            Console.WriteLine("1 - Calculo de área");
            Console.WriteLine("2 - Mostrar Animação");
            Console.WriteLine("3 - Mostrar Lista de Cervejas");
            Console.WriteLine("4 - Mostrar Lista de Carros");
            Console.WriteLine("5 - sair do sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    {
                        var metodoAreaA = new MinhaBiblioteca.CalculosDeArea();
                        Console.WriteLine(metodoAreaA.CalculaAreaDoQuadrado(3));
                        MenuSistema();
                    }
                    break;
                case 2:
                    {
                        MinhaBiblioteca.Arvore.ArvoreDesenho();
                        MenuSistema();
                    }

                    break;
                case 3:
                    {
                        MinhaBiblioteca.ListaCerveja.Cervejas();
                        MenuSistema();
                    }

                    break;
                case 4:
                    {
                        MinhaBiblioteca.ListaCarros.Carros();
                        MenuSistema();
                    }

                    break;
                case 5:
                    {
                        Console.WriteLine("Saindo...");
                        return;
                    }


            }

            
        }
    }
}

