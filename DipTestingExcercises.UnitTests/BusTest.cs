using System;
using NUnit.Framework;
using DipTestingExercises;
using DipTestingExercises.Mocking;

namespace DipTestingExcercises.UnitTests
{
    [TestFixture]
    public class BusTest
    {
        Bus _bus;
        MockPerson _fakePassenger;
        [SetUp]
        public void SetUp()
        {
            var _fakeDriver = new Driver("First", "Last", "Male", "Car");
            _fakePassenger = new MockPerson("Person", "Name", "Male");
            _bus = new Bus(_fakeDriver, 100, 50, 2, 1);
        }
        [Test]
        public void Constructor_WhenCalled_SetsVariables()
        {
            Assert.That(_bus.maxPassengers, Is.EqualTo(1));
        }
        [Test]
        public void GetPassenger_WhenBusEmpty_ReturnsCorrectValue()
        {
            Assert.That(_bus.getPassengerCount, Is.EqualTo(0));
        }
        [Test]
        public void GetPassenger_WhenBusHasPassenger_ReturnsCorrectValue()
        {
            _bus.passengers.Add(_fakePassenger);
            Assert.That(_bus.getPassengerCount(), Is.EqualTo(1));
        }
        [Test]
        public void EmbarkPassenger_WhenCalled_AddsCorrectPassenger()
        {
            _bus.embarkPassenger(_fakePassenger);
            Assert.That(_bus.passengers[0], Is.EqualTo(_fakePassenger));
        }
        [Test]
        public void EmbarkPassenger_BusIsFull_AddsCorrectPassengersAndThrowsException()
        {
            _bus.embarkPassenger(_fakePassenger);
            Assert.That(_bus.getPassengerCount(), Is.EqualTo(1));
            Assert.Throws<Exception>(() => _bus.embarkPassenger(_fakePassenger));
        }
    }
}
