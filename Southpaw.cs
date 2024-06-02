using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Southpaw : IAttack, IDefend, IClinch, IBounce
    {
        public void Defending()
        {
            Console.WriteLine("Southpaw is moving head!"); ;
        }
        public void Attacking()
        {
            Console.WriteLine("Southpaw is throwing a combo of jabs and crosses!"); ;
        }
        public void Clinching()
        {
            Console.WriteLine("Southpaw is clinching Orthodox!"); ;
        }
        public void Bouncing()
        {
            Console.WriteLine("Southpaw is bouncing!");
        }
    }
}
