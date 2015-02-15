using System.Collections.Generic;
using System.Linq;
using Engr.Enigma.Kernel.Plugboard;
using Engr.Enigma.Kernel.Reflector;
using Engr.Enigma.Kernel.Rotors;

namespace Engr.Enigma.Kernel
{
    public class Machine:IMachine,ISubstituter
    {
        public IPlugboard Plugboard { get; set; }
        public IList<IRotor> Rotors { get; set; }
        public IReflector Reflector { get; set; }
        public Machine()
        {
            Plugboard = new Plugboard.Plugboard();
        }

        public char Substitute(char input)
        {
            var ret = Plugboard.Substitute(input);
            IRotor previous = null;
            foreach (var rotor in Rotors.Reverse())
            {
                ret = rotor.Forward(Tools.AdjustForOffset(previous, ret));
                previous = rotor;
            }
            ret = Reflector.Substitute(ret);
            previous = null;
            foreach (var rotor in Rotors)
            {
                ret = rotor.Backward(Tools.AdjustForOffset(previous, ret));
                previous = rotor;
            }
            ret = Plugboard.Substitute(ret);
            return ret;
        }
    }
}