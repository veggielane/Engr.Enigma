using System;
using Engr.Enigma.Kernel;
using Engr.Enigma.Kernel.Plugboard;
using Engr.Enigma.Kernel.Reflector;
using Engr.Enigma.Kernel.Rotors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Engr.Enigma.Tests
{
    [TestClass]
    public class PlugboardTests
    {
        [TestMethod]
        public void TestSubstitute()
        {
            var pairs = new SteckeredPairs()
            {
                { 'A', 'Z' },
                { 'B', 'P' },
                { 'C', 'H' },
            };
            var plug = new Plugboard(pairs);
            Assert.AreEqual('Z',plug.Substitute('A'));
            Assert.AreEqual('G',plug.Substitute('G'));
            Assert.AreEqual('A',plug.Substitute('Z'));
        }
    }

    [TestClass]
    public class ReflectorTests
    {
        [TestMethod]
        public void TestSubstitute()
        {
            var reflector = new ReflectorA();
            Assert.AreEqual('E', reflector.Substitute('A'));
            Assert.AreEqual('A', reflector.Substitute('E'));
        }
    }
    [TestClass]
    public class RotorTests
    {
        [TestMethod]
        public void TestForwardSubstitute()
        {
            var rotor = new RotorI('A','A');
            Assert.AreEqual('E', rotor.Forward('A'));
            Assert.AreEqual('K', rotor.Forward('B'));
            Assert.AreEqual('N', rotor.Forward('K'));
        }
        [TestMethod]
        public void TestBackwardSubstitute()
        {
            var rotor = new RotorI('A', 'A');
            Assert.AreEqual('L', rotor.Backward('T'));
        }

        [TestMethod]
        public void TestOffset()
        {
            var rotor = new RotorI('A', 'B');
            var value = rotor.Forward('A');
            Assert.AreEqual('K', value);
            Assert.AreEqual('J', Tools.AdjustForOffset(rotor, value));
            

            Assert.AreEqual('M', new RotorI('A', 'C').Forward('A'));
        }
    }
}
