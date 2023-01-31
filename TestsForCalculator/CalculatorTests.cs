using HW_3.CalculatorMechanics;

namespace TestsForCalculator
{
    [TestClass]
    public class CalculatorTests
    {
        private static CalculatorMechanics cm;

        [TestInitialize]

        public void Initialize() { cm = new CalculatorMechanics(); }

        [TestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(0, 130, 130)]
        [DataRow(4, -2, 2)]
        public void AddingInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            string inputExpression = $"{firstNumber}+{secondNumber}";
            string transformedExpression = cm.TransformExpression(inputExpression);
            var actualResult = cm.Counting(transformedExpression);
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}