using Engr.Enigma.Kernel.Rotors;

namespace Engr.Enigma.Kernel
{
    public static class Tools
    {
        public static char AdjustForOffset(IRotor rotor, char input)
        {
            if (rotor == null) return input;
            return Constants.CharacterSet[Constants.CharacterSet.IndexOf(input) - Constants.CharacterSet.IndexOf(rotor.Ground)];
        }

        public static char Offset(char input, int number)
        {
            var num = Constants.CharacterSet.IndexOf(input) + number;
            if (num > 25)
            {
                num -= 26;
            }
            if (num < 0)
            {
                num += 26;
            }
            return Constants.CharacterSet[num];
        }
    }
}