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


            Console.WriteLine("UNDISPUTED WELTERWEIGHT BOXING CHAMPIONSHIP");
            Console.WriteLine();
            Console.WriteLine("Southpaw vs. Orthodox");
            Console.WriteLine();

            Console.WriteLine("CONTROLS");
            Console.WriteLine("ATTACK: 1");
            Console.WriteLine("DEFEND: 2");
            Console.WriteLine("CLINCH: 3");



            Console.WriteLine();
            Console.WriteLine("ROUND 1");
            Console.WriteLine();
            Console.WriteLine("Referee: Box!");
            bool boxing = true;
            Console.WriteLine();

            int southpawMove;
            int orthodoxMove;

            try
            {
                while (boxing)
                {
                    Console.Write("Southpaw move: ");
                    southpawMove = Convert.ToInt32(Console.ReadLine());

                    if (southpawMove == 1)
                    {
                        southpaw.Attacking();
                    }
                    else if (southpawMove == 2)
                    {
                        southpaw.Defending();
                    }
                    else if (southpawMove == 3)
                    {
                        southpaw.Clinching();
                        referee.Separating();
                    }
                    else
                    {
                        southpaw.Bouncing();
                    }
                    Console.WriteLine();

                    Console.Write("Orthodox move: ");
                    orthodoxMove = Convert.ToInt32(Console.ReadLine());

                    if (orthodoxMove == 1)
                    {
                        orthodox.Attacking();
                    }
                    else if (orthodoxMove == 2)
                    {
                        orthodox.Defending();
                    }
                    else if (orthodoxMove == 3)
                    {
                        orthodox.Clinching();
                        referee.Separating();
                    }
                    else
                    {
                        orthodox.Bouncing();
                    }
                    Console.WriteLine();
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("REFEREE: FOUL! DISQUALIFIED!");

            }
            
            Console.WriteLine();

            /*
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
            */
        }
    }
}
