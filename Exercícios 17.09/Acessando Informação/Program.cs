﻿using System;
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
                        CalculaArea();
                        MenuSistema();
                    }
                    break;
                case 2:
                    {
                        AnimacoesEmFrames.Arvore();
                        MenuSistema();
                    }

                    break;
                case 3:
                    {
                        ListarCervejas.ListaCervejasME();
                        MenuSistema();

                    }

                    break;
                case 4:
                    {
                        ListarCarros.ListarCarrosMe();
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

        /// <summary>
        /// CALCULA A ÁREA TOTAL DE UM QUADRADO
        /// </summary>
        public static void CalculaArea()
        {
            Console.WriteLine("Informa o lado do quadrado: ");
            var ladoQuadrado = int.Parse(Console.ReadLine());
            var bibliotecaCalculos = new CalculosDeArea();
            Console.WriteLine($"A área é de {bibliotecaCalculos.CalculaAreaQuadrado(ladoQuadrado)}");
            Console.ReadKey();
            Console.Clear();
        }
  

        }
    }

