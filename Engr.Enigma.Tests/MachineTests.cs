using Engr.Enigma.Kernel;
using Engr.Enigma.Kernel.Plugboard;
using Engr.Enigma.Kernel.Reflector;
using Engr.Enigma.Kernel.Rotors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Engr.Enigma.Tests
{
    [TestClass]
    public class MachineTests
    {
        [TestMethod]
        public void TestSubstitute()
        {
            var pairs = new SteckeredPairs()
            {

            };

            var machine = new Machine
            {
                Plugboard = new Plugboard(pairs),
                Rotors = new IRotor[]
                {
                    new RotorI('A', 'A'),
                    new RotorII('A', 'A'),
                    new RotorIII('A', 'A'),
                },
                Reflector = new ReflectorB()
            };


            ;
            Assert.AreEqual('U', machine.Substitute('A'));
        }


    }

    [TestClass]
    public class OtherTests
    {
        [TestMethod]
        public void TestOffset()
        {
            Assert.AreEqual('A', Tools.Offset('A', 0));
            Assert.AreEqual('Z', Tools.Offset('A', -1));
            Assert.AreEqual('A', Tools.Offset('Z', 1));
            Assert.AreEqual('Z', Tools.Offset('Z', 0));
            Assert.AreEqual('F', Tools.Offset('A', 5));
        }
    }
}