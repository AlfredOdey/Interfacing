using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Referee : ISeparate
    {
        public void Separating()
        {
            Console.WriteLine("Referee is separating both fighters!"); ;
        }
    }
}
