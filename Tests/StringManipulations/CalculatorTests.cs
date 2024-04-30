using Petras.StringManipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.StringManipulations
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(3, 5);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Add_NegativeAndPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(-3, 5);

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}
