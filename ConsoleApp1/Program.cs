using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //inciando uma cosntante int
        const int testeConst = 999;
        
        static void Main(string[] args)
        {
            string testeprimitivo = string.Empty;
            String teste2;
            bool testComp;
            bool? testeBoolNull;   
            Boolean testeComp1;
            int numeroInte = 999;
            long numeroIntLongo = 8598215;

            var testeFora = string.Empty;
            testeFora = "teste";
            var um = "teste"; //texto
            var dois = 't'; //char
            var três = 9; //int
            var quatro = 3.5; //Double
            var cinco = 0x0f; //Hex

            Console.WriteLine(testeFora);
            Console.ReadKey();
                }
    }
}
