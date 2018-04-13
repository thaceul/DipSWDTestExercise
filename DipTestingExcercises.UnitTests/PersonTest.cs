using System;
using NUnit.Framework;
using DipTestingExercises;
using DipTestingExercises.Mocking;

namespace DipTestingExcercises.UnitTests
{
    [TestFixture]
    public class PersonTest
    {
        Person _person;

        [SetUp]
        public void SetUp()
        {
            _person = new MockPerson("First", "Last", "Male");
        }
        [Test]
        public void Constructor_WhenCalled_SetsVariables()
        {
            Assert.That(_person.fname, Is.EqualTo("First"));
            Assert.That(_person.lname, Is.EqualTo("Last"));
            Assert.That(_person.getGender, Is.EqualTo("Male"));
        }
        [Test]
        public void GetName_WhenCalled_ReturnsFullName()
        {
            Assert.That(_person.getName(), Is.EqualTo("First Last"));
        }
        [Test]
        public void GetGender_WhenCalled_ReturnsGender()
        {
            Assert.That(_person.getGender(), Is.EqualTo("Male"));
        }
    }
}
