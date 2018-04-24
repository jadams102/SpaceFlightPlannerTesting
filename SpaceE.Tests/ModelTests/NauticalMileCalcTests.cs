using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceE.Models;

namespace SpaceE.Tests
{
    [TestClass]
    public class NauticalMileCalcTests
    {
        [TestMethod]
        public void NauticalTestMethod1()
        {
            var nautDist = new NauticalDistance();
            nautDist.latDeg = 28;
            nautDist.latMin = 33;
            nautDist.latDir = "N";
            nautDist.lonDeg = 80;
            nautDist.lonMin = 34;
            nautDist.lonDir = "W";

            var result = nautDist.FindDist();

            Assert.AreEqual(2, result, 1);
        }
        [TestMethod]
        public void NauticalTestMethod2()
        {
            var nautDist = new NauticalDistance();
            nautDist.latDeg = 28;
            nautDist.latMin = 34;
            nautDist.latDir = "N";
            nautDist.lonDeg = 80;
            nautDist.lonMin = 32;
            nautDist.lonDir = "W";

            var result = nautDist.FindDist();

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void NauticalTestMethod3()
        {
            var nautDist = new NauticalDistance();
            nautDist.latDeg = 45;
            nautDist.latMin = 29;
            nautDist.latDir = "N";
            nautDist.lonDeg = 120;
            nautDist.lonMin = 29;
            nautDist.lonDir = "W";

            var result = nautDist.FindDist();

            Assert.AreEqual(2144, result);
        }
    }
}
