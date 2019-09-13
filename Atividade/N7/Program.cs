using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N7
{
    class Program
    {
        static void Main(string[] args, int vogA, int vogE, int vogI, int vogO, int vogU, int vogTodas)
        {
            var indice = 0;
            var text = Texto();
            var contador = 0;
            var CarText = text[contador];


            while (indice < (text.Length - 1))
            {
                QtdVogais(text);
                indice++;
                contador++;
            }
            string textFinal;
            textFinal = $@"SEU TEXTO POSSUI
{vogA} letas 'a'
{vogE} letas 'e'
{vogI} letas 'i'
{vogO} letas 'o'
{vogU} letas 'u'
{vogTodas} vogais";


        }
        /// <summary>
        /// SOLICITA UM TEXTO E O GRAVA
        /// </summary>
        /// <returns></returns>
        private static string Texto()
        {
            Console.WriteLine("-------------- INSIRA UM TEXTO --------------");
            var texto = Console.ReadLine();
            return texto;


        }
        /// <summary>
        /// Conta as vogais
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        private static void QtdVogais(string carText)
        {

            int vogA = 0;
            int vogE = 0;
            int vogI = 0;
            int vogO = 0;
            int vogU = 0;
            int VogTodas = 0;


            switch (carText)
            {
                case ("a"):
                    vogA++;
                    break;
                case ("e"):
                    vogE++;
                    break;
                case ("i"):
                    vogI++;
                    break;
                case ("o"):
                    vogO++;
                    break;
                case ("u"):
                    vogU++;
                    break;

                    VogTodas = (vogA + vogE + vogI + vogO + vogU);

            }


        }
       
    }
 
        
         



    }

