using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace DLLFelipe
{
    class Program
    {
         static DocumentsAutoGenerate documentsAutoGenerate = new DocumentsAutoGenerate();
        static void Main(string[] args)

        {
            Console.WriteLine("************************ Sistema de Pastas ************************");
            MostraMenu();

        }


        private static void MostraMenu()
        {
            var contador = int.MinValue;
            while(contador != 0)
            {
                Console.Clear();
                Console.WriteLine("********************** MENU DE PASTAS **********************");
                Console.WriteLine(@"Informe uma opção do menu. Digite:
1 - Para criar uma pasta
2 - Para listar as pastas criadas
3 - Para deletar uma pasta");
         
            int opcaoMenu;
            opcaoMenu = int.Parse(Console.ReadLine());

            
                switch (opcaoMenu)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("********************** CRIAR PASTAS **********************");
                            Console.WriteLine("Informe o nome da pasta:");
                            var pasta = Console.ReadLine();
                            documentsAutoGenerate.CriarPastaMeusDocumentos(pasta);
                            Console.WriteLine("Aperte qualquer tecla para voltar");
                            Console.ReadKey();
                            break;
                        }
                       
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("********************** LISTA DE PASTAS **********************");
                            documentsAutoGenerate.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));
                            Console.WriteLine("Aperte qualquer tecla para voltar");
                            Console.ReadKey();
                            break;
                        }
                      
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("********************** DELETAR PASTAS **********************");
                            documentsAutoGenerate.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));
                            Console.WriteLine("Digite o nome da pasta a ser deletada: ");
                            var pastaDel = Console.ReadLine();
                            documentsAutoGenerate.DeletarPastaMeusDocumentos(pastaDel, true);
                            Console.WriteLine("Aperte qualquer tecla para voltar");
                            Console.ReadKey();
                            break;
                        }
                    
                }
                    
            }

        }
    }
}
