namespace Engr.Enigma.Kernel.Rotors
{
    public interface IRotor
    {
        char Ring { get; set; }
        char Ground { get; set; }
        string Wiring { get; }
        char Forward(char input);
        char Backward(char input);
    }

    public class BaseRotor:IRotor
    {
        public char Ring { get; set; }
        public char Ground { get; set; }
        public string Wiring { get; private set; }

        protected BaseRotor(string wiring, char ring, char ground)
        {
            Wiring = wiring;
            Ring = ring;
            Ground = ground;
        }

        public char Forward(char input)
        {
            var offset = Constants.CharacterSet.IndexOf(Ground);
            return Wiring[Constants.CharacterSet.IndexOf(input) + offset];
        }

        public char Backward(char input)
        {
            return Constants.CharacterSet[Wiring.IndexOf(input)];
        }

    }

    public class RotorI:BaseRotor
    {
        public RotorI(char ring, char ground)
            : base("EKMFLGDQVZNTOWYHXUSPAIBRCJ", ring, ground)
        {

        }
    }
    public class RotorII : BaseRotor
    {
        public RotorII(char ring, char ground)
            : base("AJDKSIRUXBLHWTMCQGZNPYFVOE", ring, ground)
        {

        }
    }
    public class RotorIII : BaseRotor
    {
        public RotorIII(char ring, char ground)
            : base("BDFHJLCPRTXVZNYEIWGAKMUSQO", ring, ground)
        {

        }
    }

}