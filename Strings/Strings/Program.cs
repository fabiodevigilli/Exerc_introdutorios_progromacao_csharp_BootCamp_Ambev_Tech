﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var teste = @"alguma coisa lblkoa
sjiosjdoiadadasuihsuasyihdiuadaj";
            var teste1 = Console.ReadLine();
            var teste2 = Console.ReadLine();
            Console.WriteLine(teste);
                                   //quebra de linha
            var teste3 = teste1 + "\r\n" + teste2;
            Console.WriteLine(teste3);       
            Console.ReadKey();*/
            var testeTemplate = @"Nome do usuario:{0} 
Idade:{1}
Descrição:{2}
Descrição:{0}";
            var finishText = string.Format(testeTemplate
                ,Console.ReadLine()
                , Console.ReadLine()
                , Console.ReadLine());
            Console.WriteLine(finishText);
            Console.ReadKey();


        }
    }
}
