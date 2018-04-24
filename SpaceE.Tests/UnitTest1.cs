using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceE.Models;

namespace SpaceE.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var planner = new Planner();
            planner.Hours = 1;
            planner.Tasks = 4;

            decimal astronauts = planner.AstroNumber();

            Assert.AreEqual(1, astronauts);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var planner = new Planner();
            planner.Hours = 24;
            planner.Tasks = 80;

            decimal astronauts = planner.AstroNumber();

            Assert.AreEqual(2, astronauts);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var planner = new Planner();
            planner.Hours = 168;
            planner.Tasks = 1234;

            decimal astronauts = planner.AstroNumber();

            Assert.AreEqual(3, astronauts);
        }
    }
}
