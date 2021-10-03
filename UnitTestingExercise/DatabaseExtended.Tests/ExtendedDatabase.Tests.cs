using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase extendedDatabase;

        [SetUp]
        public void Setup()
        {
            extendedDatabase = new ExtendedDatabase.ExtendedDatabase();
        }

        [Test]
        public void CtorIsValid()
        {
            var person = new Person[5];

            for (int i = 0; i < person.Length; i++)
            {
                person[i] = new Person(i, $"Pesho: {i}");
            }

            extendedDatabase = new ExtendedDatabase.ExtendedDatabase(person);

            Assert.That(extendedDatabase.Count, Is.EqualTo(person.Length));
        }

        [Test]
        public void CtorIsNotValid()
        {
            var person = new Person[17];

            for (int i = 0; i < person.Length; i++)
            {
                person[i] = new Person(i, $"Pesho: {i}");
            }

            Assert.Throws<ArgumentException>(() => extendedDatabase = new ExtendedDatabase.ExtendedDatabase(person));
        }

        [Test]
        public void CountTest()
        {
            Assert.AreEqual(extendedDatabase.Count, 0);
        }

        [Test]
        public void AddRangeThrowException()
        {
            var person = new Person[17];
            Assert.Throws<ArgumentException>(() => extendedDatabase = new ExtendedDatabase.ExtendedDatabase(person));
        }

        [Test]
        public void AddRangeTest()
        {
            var person = new Person[5];

            for (int i = 0; i < person.Length; i++)
            {
                person[i] = new Person(i, $"Pesho {i}");
            }

            extendedDatabase = new ExtendedDatabase.ExtendedDatabase(person);

            Assert.That(extendedDatabase.Count, Is.EqualTo(person.Length));
        }

        [Test]
        public void AddThrowException()
        {
            var person = 16;

            for (int i = 0; i < person; i++)
            {
                extendedDatabase.Add(new Person(i, $"Pesho: {i}"));
            }

            //extendedDatabase = new ExtendedDatabase(person);

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(new Person(16, "saf")));
        }

        [Test]
        public void AddThrowName()
        {
            var name = "Pesho";
            extendedDatabase.Add(new Person(1, name));

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(new Person(2, name)));
        }

        [Test]
        public void AddThrowId()
        {
            var id = 1;
            extendedDatabase.Add(new Person(id, "Pesho"));

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(new Person(1, "adg")));
        }

        [Test]
        public void RemoveTest()
        {
            extendedDatabase.Add(new Person(1, "Pesho"));
            extendedDatabase.Add(new Person(2, "Ivan"));

            extendedDatabase.Remove();

            Assert.That(extendedDatabase.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Remove());
        }

        [Test]
        public void FyndByUserNameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => extendedDatabase.FindByUsername(null));
        }

        [Test]
        public void FindByUserNameTest()
        {          
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindByUsername("Gosho"));
        }

        [Test]
        public void FindByIdIsZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => extendedDatabase.FindById(-1));
        }

        [Test]
        public void FindByIdThrow()
        {
            var id = 1;
            extendedDatabase.Add(new Person(id, "Pesho"));

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindById(2));
        }
    }
}