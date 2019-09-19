using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N1.Model;

namespace N1
{
    class Program
    {
        static void Main(string[] args)
        {
            var friendsList = new List<Amigos>();
            {
                friendsList.Add(new Amigos()
                {
                    Nome = "N1",
                    TempoDeAmizade = 3
                    

                });
                friendsList.Add(new Amigos()
                {
                    Nome = "N2",
                    TempoDeAmizade = 5


                });
                friendsList.Add(new Amigos()
                {
                    Nome = "N3",
                    TempoDeAmizade = 10


                });
                friendsList.ForEach(i => Console.WriteLine($"Nome: {i.Nome}, Tempo de amizade: {i.TempoDeAmizade}"));
                Console.ReadKey();

            }


        }
        
  
    }
}
