using NUnit.Framework;
using System;

namespace Tests
{
    public class DatabaseTests
    {
        private Database.Database database;

        [SetUp]
        public void Setup()
        {
            this.database = new Database.Database();
        }

        [Test]
        public void CtorTestAddValud()
        {
            var element = new int[] { 1, 2, 3};
            database = new Database.Database(element);

            Assert.That(database.Count, Is.EqualTo(element.Length));
        }

        [Test]
        public void CtorTestAddIsNotValid()
        {
            Assert.Throws<InvalidOperationException>(() => database = new Database.Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17));
        }

        [Test]
        public void CountTest()
        {
            database.Add(1);
            database.Add(3);

            Assert.AreEqual(database.Count, 2);
        }

        [Test]
        public void AddIncrementTest()
        {
            var n = 5;
            for (int i = 0; i < n; i++)
            {
                database.Add(i);
            }

            Assert.That(database.Count, Is.EqualTo(n));
        }

        [Test]
        public void AddThrowExceptionTest()
        {
            var element = new int[17];
            Assert.Throws<InvalidOperationException>(() => database = new Database.Database(element));
        }

        [Test]
        public void RemoveTest()
        {
            database.Add(1);
            database.Add(2);

            database.Remove();

            Assert.AreEqual(database.Count, 1);
        }

        [Test]
        public void RemoveThrowExceptioAreZero()
        {

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void FetchTest()
        {
            database.Add(1);
            database.Add(2);
            var first = database.Fetch();
            database.Add(3);
            var second = database.Fetch();

            Assert.That(first, Is.Not.EqualTo(second));
        }
    }
}