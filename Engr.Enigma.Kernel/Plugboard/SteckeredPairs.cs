using System.Collections.Generic;

namespace Engr.Enigma.Kernel.Plugboard
{
    public class SteckeredPairs : List<KeyValuePair<char, char>>
    {
        public void Add(char key, char value)
        {
            Add(new KeyValuePair<char, char>(key, value));
        }
    }
}