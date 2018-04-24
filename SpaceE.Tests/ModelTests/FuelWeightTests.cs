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
            var newFuel = new FuelWeight(1000, 1400, "Los Angeles");

            //Act
            var weightResult = newFuel.Weight;
            var distanceResult = newFuel.Distance;

            //Assert
            Assert.AreEqual(1000, weightResult);
            Assert.AreEqual(1400, distanceResult);
        }

        [TestMethod]
        public void Set_ReturnVoid_Void()
        {
            //Arrange
            var newFuel = new FuelWeight(1000, 1400, "Los Angeles");

            //Act
            newFuel.Weight = 2000;

            //Assert
            Assert.AreEqual(2000, newFuel.Weight);
        }

        [TestMethod]
        public void GetTotalFuel_ReturnsFuelWeight_Int()
        {
            //Arrange
            var weight = new FuelWeight(1000, 1400, "Los Angeles");

            //Act
            weight.CalcWeight();

            //Assert
            Assert.AreEqual(595, weight.Fuel);
        }
        
        [TestMethod]
        public void GetTotalFuel_ReturnsFuelWeight2_Int()
        {
            //Arrange
            var weight = new FuelWeight(2000, 9400, "International Space Station");

            //Act
            weight.CalcWeight();

            //Assert
            Assert.AreEqual(43886, weight.Fuel);
        }
    }
}
