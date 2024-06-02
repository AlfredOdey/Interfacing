using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Orthodox : IAttack, IDefend, IClinch
    {
        public void Attacking()
        {
            Console.WriteLine("Orthodox is throwing jabs!"); ;
        }
        public void Defending()
        {
            Console.WriteLine("Orthodox is blocking all punches!"); ;
        }
        public void Clinching()
        {
            Console.WriteLine("Orthodox is clinching Southpaw!"); ;
        }
        public void Bouncing()
        {
            Console.WriteLine("Orthodox is bouncing!");
        }
    }
}
