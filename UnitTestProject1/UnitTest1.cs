using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RyanMcDonald_S00199690;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPriceDecrease()
        {
            //Arrange
            Game testGame = new Game();
            testGame.Price = 50m;
            decimal expectedPrice = 30m;

            //Act
            testGame.DecreasePrice(20m);
            //Assert
            Assert.AreEqual(expectedPrice, testGame.Price);
           
        }

        [TestMethod]
        public void TestMultiplePriceDecreases()
        {
            //Arrange
            Game testGame = new Game();
            testGame.Price = 50m;
            decimal expectedPrice = 20m;

            //Act
            testGame.DecreasePrice(20m);
            testGame.DecreasePrice(5m);
            testGame.DecreasePrice(5m);
            //Assert
            Assert.AreEqual(expectedPrice, testGame.Price);

        }


    }
}
