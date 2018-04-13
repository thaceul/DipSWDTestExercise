using System;
using NUnit.Framework;
using DipTestingExercises;
using DipTestingExercises.Mocking;

namespace DipTestingExcercises.UnitTests
{
    [TestFixture]
    public class DriverTest
    {

        Driver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new Driver("First", "Last", "Male", "Car");
        }

        [Test]
        public void Constructor_WhenCalled_SetsVariables()
        {
            Assert.That(_driver.fname, Is.EqualTo("First"));
            Assert.That(_driver.lname, Is.EqualTo("Last"));
            Assert.That(_driver.getGender(), Is.EqualTo("Male"));
            Assert.That(_driver.getLicenceType(), Is.EqualTo("Car"));
        }
        [Test]
        public void GetLicenceType_WhenCalled_ReturnsLicenceType()
        {
            Assert.That(_driver.getLicenceType(), Is.EqualTo("Car"));
        }
    }
}
