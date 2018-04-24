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
    }
}
