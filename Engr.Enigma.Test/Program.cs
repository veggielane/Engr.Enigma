using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engr.Enigma.Kernel.Plugboard;

namespace Engr.Enigma.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var pairs = new SteckeredPairs
            {
                { 'A', 'B' }
            };

            var t = new Plugboard(pairs);


        }
    }
}
