using System;
using MotorizedVehicles;
using Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMotorizedVehicle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDrivingClass()
        {
            Coupe coupe = new Coupe();
            bool isDriving = coupe.Driving();
            Assert.AreEqual(false, isDriving);

            bool hasStarted = coupe.Driving(true);
            Assert.IsTrue(hasStarted);

            bool hasStopped = coupe.Driving(false);
            Assert.IsFalse(hasStopped);
        }
    }
}
