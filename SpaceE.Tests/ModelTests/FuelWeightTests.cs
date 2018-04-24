using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SpaceE.Models;

namespace SpaceE.Tests
{
    [TestClass]
    public class FuelWeightTests
    {
        [TestMethod]
        public void GetTotalFuel_ReturnsFuelWeight_Int()
        {
            //Arrange
            var weight = new FuelWeight();

            //Act
            var result = Math.Round((double) weight.CalcWeight(1000, 1400));
            int intResult = (int)result;

            //Assert
            Assert.AreEqual(595, intResult);
        }
        
        [TestMethod]
        public void GetTotalFuel_ReturnsFuelWeight2_Int()
        {
            //Arrange
            var weight = new FuelWeight();

            //Act
            var result = Math.Round((double)weight.CalcWeight(2000, 9400));
            int intResult = (int)result;

            //Assert
            Assert.AreEqual(43886, intResult);
        }
    }
}
