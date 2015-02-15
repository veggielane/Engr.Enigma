namespace Engr.Enigma.Kernel.Reflector
{
    public abstract class BaseReflector : IReflector
    {

        public string Wiring { get; private set; }

        protected BaseReflector(string wiring)
        {
            Wiring = wiring;
        }

        public char Substitute(char input)
        {
            return Wiring[Constants.CharacterSet.IndexOf(input)];
        }
    }
}