using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTests;

namespace CalculatorTestsLib
{ 
    [TestClass]
    public class CalculatorTests
    {


    [TestMethod]
    public void CalculatorDisplay()
    {
        //Arrange
        var sut = new Calculator();
        //Act
        sut.PowerOn();
        //Assert
        Assert.AreEqual(0, sut.Display);


    }

    [TestMethod]
        public void Add12And25()
        {
            //Arrange
            var sut = new Calculator();
            //Act
            sut.Press("1");

            sut.Press("2");
            sut.Press("+");
            sut.Press("2");
            sut.Press("5");
            sut.Press("=");
            //Assert
            Assert.AreEqual(37, sut.Display);


        }
    }
}
