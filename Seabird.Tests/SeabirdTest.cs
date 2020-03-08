using NUnit.Framework;

using SeabirdImpl = Seabird.Implementation.Seabird;

namespace Seabird.Tests
{
    [TestFixture]
    public class SeabirdTest
    {
        private SeabirdImpl _seabird;
        private SeabirdMemory _seabirdMemory;

        [SetUp]
        public void SetUp()
        {
            _seabird = new SeabirdImpl();
            _seabirdMemory = new SeabirdMemory
            {
                // Store internal state before starting engine
                Memento = _seabird.SaveMemento()
            };
        }

        [Test]
        public void TestMemento_TurnOn_Restore()
        {
            // 1. Arrange
            bool isTurnedOn = false;
            int height = 0;
            int speed = 0;
            double degree = 0;

            // 2. Act
            _seabird.TurnOnEngine();
            _seabird.RestoreMemento(_seabirdMemory.Memento);

            // 3. Assert
            Assert.AreEqual(isTurnedOn, _seabird.IsTurnedOn);
            Assert.AreEqual(height, _seabird.Height);
            Assert.AreEqual(speed, _seabird.Speed);
            Assert.AreEqual(degree, _seabird.Degree);
        }

        [Test]
        public void TestMemento_TurnOn_Save_Restore()
        {
            // 1. Arrange
            bool isTurnedOn = true;
            int height = 0;
            int speed = 0;
            double degree = 0;

            // 2. Act
            _seabird.TurnOnEngine();
            _seabirdMemory.Memento = _seabird.SaveMemento();
            _seabird.RestoreMemento(_seabirdMemory.Memento);

            // 3. Assert
            Assert.AreEqual(isTurnedOn, _seabird.IsTurnedOn);
            Assert.AreEqual(height, _seabird.Height);
            Assert.AreEqual(speed, _seabird.Speed);
            Assert.AreEqual(degree, _seabird.Degree);
        }

        [Test]
        public void TestMemento_IncreaseRevs_Restore()
        {
            // 1. Arrange
            bool isTurnedOn = false;
            int height = 0;
            int speed = 0;
            double degree = 0;

            // 2. Act
            _seabird.TurnOnEngine();
            _seabird.IncreaseRevs();
            _seabird.RestoreMemento(_seabirdMemory.Memento);

            // 3. Assert
            Assert.AreEqual(isTurnedOn, _seabird.IsTurnedOn);
            Assert.AreEqual(height, _seabird.Height);
            Assert.AreEqual(speed, _seabird.Speed);
            Assert.AreEqual(degree, _seabird.Degree);
        }

        [Test]
        public void TestMemento_IncreaseRevs_Save_Restore()
        {
            // 1. Arrange
            bool isTurnedOn = true;
            int height = 0;
            int speed = 10;
            double degree = 0;

            // 2. Act
            _seabird.TurnOnEngine();
            _seabird.IncreaseRevs();
            _seabirdMemory.Memento = _seabird.SaveMemento();
            _seabird.RestoreMemento(_seabirdMemory.Memento);

            // 3. Assert
            Assert.AreEqual(isTurnedOn, _seabird.IsTurnedOn);
            Assert.AreEqual(height, _seabird.Height);
            Assert.AreEqual(speed, _seabird.Speed);
            Assert.AreEqual(degree, _seabird.Degree);
        }

        [Test]
        public void TestMemento_TakeOff_Restore()
        {
            // 1. Arrange
            bool isTurnedOn = false;
            int height = 0;
            int speed = 0;
            double degree = 0;

            // 2. Act
            _seabird.TurnOnEngine();
            _seabird.TakeOff();
            _seabird.RestoreMemento(_seabirdMemory.Memento);

            // 3. Assert
            Assert.AreEqual(isTurnedOn, _seabird.IsTurnedOn);
            Assert.AreEqual(height, _seabird.Height);
            Assert.AreEqual(speed, _seabird.Speed);
            Assert.AreEqual(degree, _seabird.Degree);
        }

        [Test]
        public void TestMemento_TakeOff_Save_Restore()
        {
            // 1. Arrange
            bool isTurnedOn = true;
            int height = 100;
            int speed = 50;
            double degree = 10;

            // 2. Act
            _seabird.TurnOnEngine();
            _seabird.TakeOff();
            _seabirdMemory.Memento = _seabird.SaveMemento();
            _seabird.RestoreMemento(_seabirdMemory.Memento);

            // 3. Assert
            Assert.AreEqual(isTurnedOn, _seabird.IsTurnedOn);
            Assert.AreEqual(height, _seabird.Height);
            Assert.AreEqual(speed, _seabird.Speed);
            Assert.AreEqual(degree, _seabird.Degree);
        }

        [Test]
        public void TestMemento_TakeOff_Land_Restore()
        {
            // 1. Arrange
            bool isTurnedOn = false;
            int height = 0;
            int speed = 0;
            double degree = 0;

            // 2. Act
            _seabird.TurnOnEngine();
            _seabird.TakeOff();
            _seabird.IncreaseRevs();
            _seabird.Land();
            _seabird.RestoreMemento(_seabirdMemory.Memento);

            // 3. Assert
            Assert.AreEqual(isTurnedOn, _seabird.IsTurnedOn);
            Assert.AreEqual(height, _seabird.Height);
            Assert.AreEqual(speed, _seabird.Speed);
            Assert.AreEqual(degree, _seabird.Degree);
        }

        [Test]
        public void TestMemento_TakeOff_Land_Save_Restore()
        {
            // 1. Arrange
            bool isTurnedOn = true;
            int height = 0;
            int speed = 40;
            double degree = 0;

            // 2. Act
            _seabird.TurnOnEngine();
            _seabird.TakeOff();
            _seabird.IncreaseRevs();
            _seabird.Land();
            _seabirdMemory.Memento = _seabird.SaveMemento();
            _seabird.RestoreMemento(_seabirdMemory.Memento);

            // 3. Assert
            Assert.AreEqual(isTurnedOn, _seabird.IsTurnedOn);
            Assert.AreEqual(height, _seabird.Height);
            Assert.AreEqual(speed, _seabird.Speed);
            Assert.AreEqual(degree, _seabird.Degree);
        }

        [Test]
        public void TestNoMemento_TakeOff()
        {
            // 1. Arrange
            bool isTurnedOn = true;
            int height = 100;
            int speed = 50;
            double degree = 10;

            // 2. Act
            _seabird.TurnOnEngine();
            _seabird.TakeOff();

            // 3. Assert
            Assert.AreEqual(isTurnedOn, _seabird.IsTurnedOn);
            Assert.AreEqual(height, _seabird.Height);
            Assert.AreEqual(speed, _seabird.Speed);
            Assert.AreEqual(degree, _seabird.Degree);
        }

        [Test]
        public void TestNoMemento_TakeOff_Land()
        {
            // 1. Arrange
            bool isTurnedOn = true;
            int height = 0;
            int speed = 40;
            double degree = 0;

            // 2. Act
            _seabird.TurnOnEngine();
            _seabird.TakeOff();
            _seabird.IncreaseRevs();
            _seabird.Land();

            // 3. Assert
            Assert.AreEqual(isTurnedOn, _seabird.IsTurnedOn);
            Assert.AreEqual(height, _seabird.Height);
            Assert.AreEqual(speed, _seabird.Speed);
            Assert.AreEqual(degree, _seabird.Degree);
        }
    }
}