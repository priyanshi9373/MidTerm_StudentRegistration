using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistration;
using NUnit.Framework;
using System.Web;

namespace StudentRegistrationTest
{
    [TestFixture]
    public class RegistrationTests
    {
        [Test]
        public void NameTestCase1_ValidInput_ReturnValid()
        {
            string name = "Priyanshi Jadeja";
            string expected = name;

            Registartion registration = new Registartion();
            string actual = registration.RegisterName(name);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NameTestCase2_ValidInput_ReturnValid()
        {
            string name = "Jignasha";
            string expected = name;

            Registartion registration = new Registartion();
            string actual = registration.RegisterName(name);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NameTestCase3_ValidInput_ReturnValid()
        {
            string name = "Rajveersinh";
            string expected = name;

            Registartion registration = new Registartion();
            string actual = registration.RegisterName(name);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]  
        public void AgeTestCase4_ValidInput_ReturnValid()
        {
            int age = 12;
            int expected = age;

            Registartion registartion = new Registartion(); 
            int actual = registartion.RegisterAge(age);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AgeTestCase5_ValidInput_ReturnValid()
        {
            int age = 56;
            int expected = age;

            Registartion registartion = new Registartion();
            int actual = registartion.RegisterAge(age);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AgeTestCase6_ValidInput_ReturnValid()
        {
            int age = 100;
            int expected = age;

            Registartion registartion = new Registartion();
            int actual = registartion.RegisterAge(age);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GroupSizeTestCase7_ValidInput_ReturnValid()
        {
            int groupSize = 7;
            int expected = groupSize;

            Registartion registered = new Registartion();
            int actual = registered.RegisterGroupSize(groupSize);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GroupSizeTestCase8_ValidInput_ReturnValid()
        {
            int groupSize = 15;
            int expected = groupSize;

            Registartion registered = new Registartion();
            int actual = registered.RegisterGroupSize(groupSize);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GroupSizeTestCase9_ValidInput_ReturnValid()
        {
            int groupSize = 11;
            int expected = groupSize;

            Registartion registered = new Registartion();
            int actual = registered.RegisterGroupSize(groupSize);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
