using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;


namespace Acessando_Informação
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
            Console.ReadKey();
        }

        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu: ");
            Console.WriteLine("1 - Calculo de área");
            Console.WriteLine("2 - Mostrar Animação");
            Console.WriteLine("3 - sair do sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    {
                        CalculaArea();
                        MenuSistema();
                    }
                    break;
                case 2:
                    {
                        AnimacoesEmFrames.Arvore();
                        Console.ReadKey();
                    }

                    break;
                case 3:
                    {
                        Console.WriteLine("Saindo...");
                        return;
                    }

               }
        }


        public static void CalculaArea()
        {
            Console.WriteLine("Informa o lado do quadrado: ");
            var ladoQuadrado = int.Parse(Console.ReadLine());
            var bibliotecaCalculos = new CalculosDeArea();
            Console.WriteLine($"A área é de {bibliotecaCalculos.CalculaAreaQuadrado(ladoQuadrado)}");
            Console.ReadKey();
        }
    }
}
