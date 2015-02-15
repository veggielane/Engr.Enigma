using System.Collections.Generic;

namespace Engr.Enigma.Kernel.Plugboard
{
    public class Plugboard : IPlugboard
    {
        private readonly Dictionary<char, char> _substitutions = new Dictionary<char, char>();

        public Plugboard(IEnumerable<KeyValuePair<char, char>> pairs)
        {
            foreach (var pair in pairs)
            {
                _substitutions.Add(pair.Key,pair.Value);
                _substitutions.Add(pair.Value,pair.Key);
            }
        }
        public Plugboard()
            : this(new List<KeyValuePair<char, char>>())
        {

        }

        public char Substitute(char input)
        {
            return _substitutions.ContainsKey(input) ? _substitutions[input] : input;
        }
    }
}