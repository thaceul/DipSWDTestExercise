using System;
using NUnit.Framework;
using DipTestingExercises;
using DipTestingExercises.Mocking;

namespace DipTestingExcercises.UnitTests
{
    [TestFixture]
    public class PassengerTest
    {
        Passenger _passenger;

        [SetUp]
        public void SetUp()
        {
            _passenger = new Passenger("First", "Last", "Male", "Ticket");
        }
        [Test]
        public void Constructor_WhenCalled_SetsVariables()
        {
            Assert.That(_passenger.fname, Is.EqualTo("First"));
            Assert.That(_passenger.lname, Is.EqualTo("Last"));
            Assert.That(_passenger.getGender(), Is.EqualTo("Male"));
            Assert.That(_passenger.getTicketType(), Is.EqualTo("Ticket"));
        }
        [Test]
        public void GetTicketType_WhenCalled_ReturnsCorrectTicketType()
        {
            Assert.That(_passenger.getTicketType(), Is.EqualTo("Ticket"));
        }
    }
}
