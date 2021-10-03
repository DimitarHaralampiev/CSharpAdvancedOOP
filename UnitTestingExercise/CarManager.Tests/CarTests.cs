
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            this.car = new Car("Make", "Model", 5, 100);
        }

        [Test]
        [TestCase("", "Model", 5, 100)]
        [TestCase(null, "Model", 5, 100)]
        [TestCase("Make", "", 5, 100)]
        [TestCase("Make", null, 5, 100)]
        [TestCase("Make", "Make", 0, 100)]
        [TestCase("Make", "Make", -5, 100)]
        [TestCase("Make", "Make", 5, 0)]
        [TestCase("Make", "Make", 5, -5)]
        public void CtorThrowExceptionWhenDataIsInvlid(string make, string model, double fuelConsuption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsuption, fuelCapacity));
        }

        [Test]
        public void CtorInitializationTest()
        {
            string make = "Make";
            string model = "Model";
            double fuelConsuption = 5;
            double fuelCapacity = 100;
            Assert.That(car.Make, Is.EqualTo(make));
            Assert.That(car.Model, Is.EqualTo(model));
            Assert.That(car.FuelConsumption, Is.EqualTo(fuelConsuption));
            Assert.That(car.FuelCapacity, Is.EqualTo(fuelCapacity));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-10)]
        public void RefuelThrowExceptionWhenIsZeroOrNegative(double fuel)
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(fuel));
        }

        [Test]
        public void RefuelIncrease()
        {
            var refuelAmount = car.FuelCapacity / 2;
            car.Refuel(refuelAmount);

            Assert.That(car.FuelAmount, Is.EqualTo(refuelAmount));
        }

        [Test]
        public void RefuelSetFuelAmountToCapacity()
        {
            car.Refuel(car.FuelCapacity * 1.2);
            Assert.That(car.FuelAmount, Is.EqualTo(car.FuelCapacity));
        }

        [Test]
        public void DriveThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(100));
        }

        [Test]
        public void DriveDecrease()
        {
            double initialFule = car.FuelCapacity;
            car.Refuel(initialFule);
            car.Drive(100);

            Assert.That(car.FuelAmount, Is.EqualTo(initialFule - car.FuelConsumption));
        }

        
    }
}