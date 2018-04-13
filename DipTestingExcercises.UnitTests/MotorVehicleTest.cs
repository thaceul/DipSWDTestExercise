using System;
using NUnit.Framework;
using DipTestingExercises;
using DipTestingExercises.Mocking;

namespace DipTestingExcercises.UnitTests
{
    [TestFixture]
    public class MotorVehicleTest
    {
        MockVehicle _vehicle;

        [SetUp]
        public void SetUp()
        {
            var _fakedriver = new Driver("First", "Last", "Male", "Car");
            _vehicle = new MockVehicle(_fakedriver, 100, 50, 2);
        }
        [Test]
        public void Constructor_WhenCalled_SetsVariables()
        {

            Assert.That(_vehicle.maxFuel, Is.EqualTo(100));
            Assert.That(_vehicle.currentFuel, Is.EqualTo(50));
            Assert.That(_vehicle.litresPerKM, Is.EqualTo(2));
        }

        [Test]
        public void GetFuelRemaining_WhenCalled_ReturnsFuelRemaining()
        {
            Assert.That(_vehicle.getFuelRemaining(), Is.EqualTo(50));
        }

        [Test]

        public void Refuel_WhenCalled_AdjustFuelCorrectly()
        {
            _vehicle.refuel(50);

            Assert.That(_vehicle.getFuelRemaining(), Is.EqualTo(100));
        }
        [Test]
        public void Refuel_WhenOverfilled_ThrowsException()
        {
            Assert.Throws<Exception>(() => _vehicle.refuel(51));
        }
        [Test]
        public void Refuel_WhenNegativeNumber_ThrowsException()
        {
            Assert.Throws<Exception>(() => _vehicle.refuel(-1));
        }
        [Test]
        public void Travel_WhenCalled_ReturnsCorrectFuelRemaining()
        {
            _vehicle.travel(10);
            Assert.That(_vehicle.getFuelRemaining(), Is.EqualTo(30));
        }
        [Test]
        public void Travel_WhenInsufficientFuel_ThrowsException()
        {
            Assert.Throws<Exception>(() => _vehicle.travel(26));
        }
    }
}
