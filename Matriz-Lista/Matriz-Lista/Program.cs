using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayLinear = new string[2];
            arrayLinear[0] = "Felipe";
            arrayLinear[1] = "Gilmar";

            List<string> listaLinear = new List<string>
            {
                "Felipe",
                "Giomar",
                "ok"
            };
            Console.WriteLine(listaLinear[0]);
            Console.WriteLine(arrayLinear[0]);
            var keyPress = Console.ReadKey().KeyChar.ToString();

        }
    }
}
