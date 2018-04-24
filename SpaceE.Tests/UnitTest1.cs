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
    }
}
