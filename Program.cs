using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment11
{

    class Program
    {
        public static LargeDataCollection agent { get; private set; }

        static void Main()
        {
            agent = new LargeDataCollection(new string[] { "\nJack Sparrow", "Johnny Depp", "Anthony De Torre", "Tom Cruise", "Leonardo DiCaprio" });
            {

                agent.Add("Will Smith");
                agent.Add("Hugh Jackman");

                Console.WriteLine("\nAccessing Agents");
                Console.WriteLine(agent[0]);
                Console.WriteLine(agent[1]);
                Console.WriteLine(agent[2]);
                Console.WriteLine(agent[3]);
                //Console.WriteLine(agent[4]);
                //Console.WriteLine(agent[5]);
                //Console.WriteLine(agent[6]);

                agent.Remove("Ai Pacino");

                Console.WriteLine("\nCollection after removing 'Ai Pacino':\n");

                Console.WriteLine("Agents Count: " + agent.Count);

                for (int i = 0; i < agent.Count; i++)
                {
                    Console.WriteLine(agent[i]);
                }

                agent.Dispose();
                Console.ReadKey();

            }
        }
    }
}
