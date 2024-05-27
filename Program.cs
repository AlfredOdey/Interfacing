using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orthodox orthodox = new Orthodox();
            Southpaw southpaw = new Southpaw();
            Referee referee = new Referee();

            Console.WriteLine("ROUND 1");
            Console.WriteLine();

            orthodox.Attacking();
            southpaw.Defending();

            Console.WriteLine();
            Console.WriteLine("ROUND 6");
            Console.WriteLine();

            southpaw.Attacking();
            orthodox.Defending();

            Console.WriteLine();

            orthodox.Clinching();
            referee.Separating();

            Console.WriteLine();
            Console.WriteLine("Referee gives Orthodox a warning!");

            Console.WriteLine();
            Console.WriteLine("ROUND 12");
            Console.WriteLine();

            Console.WriteLine("Both fighters are tired!");
            Console.WriteLine();
            orthodox.Clinching();
            southpaw.Clinching();
            referee.Separating();

            Console.WriteLine();
            Console.WriteLine("Bell dings! Time up!");

        }
    }
}
