using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SpaceE.Models;

namespace SpaceE.Tests
{
    [TestClass]
    public class FuelWeightTests
    {
        [TestMethod]
        public void GetWeight_ReturnWeight_Int()
        {
            //Arrange
            var newFuel = new FuelWeight(1000, 1400);

            //Act
            var weightResult = newFuel.Weight;
            var distanceResult = newFuel.Distance;

            //Assert
            Assert.AreEqual(1000, weightResult);
            Assert.AreEqual(1400, distanceResult);
        }

        [TestMethod]
        public void GetTotalFuel_ReturnsFuelWeight_Int()
        {
            //Arrange
            var weight = new FuelWeight(1000, 1400);

            //Act
            var result = Math.Round((double) weight.CalcWeight());
            int intResult = (int)result;

            //Assert
            Assert.AreEqual(595, intResult);
        }
        
        [TestMethod]
        public void GetTotalFuel_ReturnsFuelWeight2_Int()
        {
            //Arrange
            var weight = new FuelWeight(2000, 9400);

            //Act
            var result = Math.Round((double)weight.CalcWeight());
            int intResult = (int)result;

            //Assert
            Assert.AreEqual(43886, intResult);
        }
    }
}
