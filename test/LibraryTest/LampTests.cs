using NUnit.Framework;
using Library;

namespace LibraryTest
{
    public class Tests
    {
        private Lamp lamp;

        [SetUp]
        public void Setup()
        {
            lamp = new Lamp();
        }

        [Test]
        public void CreateLampTest()
        {
            Assert.IsNotNull(lamp);
        }

        [Test]
        public void TurnOnLamp()
        {
            lamp.TurnOn();
            Assert.IsTrue(lamp.IsOn);
        }

        [Test]
        public void TurnOffLamp()
        {
            lamp.TurnOff();
            Assert.IsFalse(lamp.IsOn);
        }

        [TearDown]
        void TearDown()
        {
            lamp = null;
        }
    }
}