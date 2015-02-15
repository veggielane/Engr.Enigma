using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engr.Enigma.Kernel.Plugboard;

namespace Engr.Enigma.Kernel
{
    interface IMachine
    {
        IPlugboard Plugboard { get; }
    }
}
