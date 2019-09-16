using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------- INSIRA UM TEXTO ---------------");
            var texto = Console.ReadLine();
            Calculo(texto);
            Console.WriteLine(Calculo(texto));
            Console.ReadKey();


        }
        /// <summary>
        /// RETONAR O CÁLCULO DA QUANTIDADE TOTAL DE VOGAIS DO TEXTO
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        private static string Calculo(string texto)
        {
            
            
            string finalText = string.Empty;
            int result = 0;
            int vogA = 0;
            int vogE = 0;
            int vogI = 0;
            int vogO = 0;
            int vogU = 0;
            var verificador = 0;
            
            while (verificador < (texto.Length))
            {
                switch (texto[verificador])
                {
                    case 'a':
                        vogA++;
                        break;
                    case 'e':
                        vogE++;
                        break;
                    case 'i':
                        vogI++;
                        break;
                    case 'o':
                        vogO++;
                        break;
                    case 'u':
                        vogU++;
                        break;
                         }

                verificador++;
                
    }
            result = (vogA + vogE + vogI + vogO + vogU);
            finalText = $@"Este texto contém:
{vogA} letras'a'
{vogE} letras'e'
{vogI} letras'i'
{vogO} letras'o'
{vogU} letras'u'
E um total de {result} vogal(is)
--------------- APERTE QUALQUER TECLA PARA FECHAR --------------- ";
                    


            return finalText;
            
        }

        

    }
}
