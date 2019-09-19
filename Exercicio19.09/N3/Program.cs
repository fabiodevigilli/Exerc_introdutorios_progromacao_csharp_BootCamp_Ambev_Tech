using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N3.Model;

namespace N3
{
    class Program
    {
        static void Main(string[] args)
        {
            Formulario();
        }
        public static void Formulario()
        {
            Console.WriteLine("-------- Cadastro de Carros --------");
             var listaCarros = new List<Carro>();
         
           
                Console.WriteLine("Qual a marca do carro?");
                string marca = Console.ReadLine();
                Console.WriteLine("Qual o modelo do carro?");
                var modelo = Console.ReadLine();
                Console.WriteLine("Qual o ano do carro?");
                var ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor deste carro?");
                double valor = double.Parse(Console.ReadLine());


                listaCarros.Add(new Carro()
                {
                    Marca = marca,
                    Modelo = modelo,
                    Ano = ano,
                    Valor = valor
                });
                Console.Clear();
            
            listaCarros.ForEach(Indice => Console.WriteLine($@"--------- Carro Cadastrado ----------
Marca: {Indice.Marca}
Modelo: {Indice.Modelo}
Ano: {Indice.Ano}
Valor: {Indice.Valor.ToString("c")}
------ Aperte qualquer tecla para continuar ------"));
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(@"Deseja cadastrar mais um carro?
1 - Não
2 - Sim");
            if (Console.ReadLine() == "2")
            {
                Console.Clear();
                Formulario();
            }


        }
    }
}
