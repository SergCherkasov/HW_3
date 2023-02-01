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
        [TestMethod]
        [DataRow(2, 2, 0)]
        [DataRow(0, 130, -130)]
        [DataRow(4, -2, 6)]
        public void DividingInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            string inputExpression = $"{firstNumber}-{secondNumber}";
            string transformedExpression = cm.TransformExpression(inputExpression);
            var actualResult = cm.Counting(transformedExpression);
            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(0, 130, 0)]
        [DataRow(4, -2, -8)]
        public void MultiplyInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            string inputExpression = $"{firstNumber}*{secondNumber}";
            string transformedExpression = cm.TransformExpression(inputExpression);
            var actualResult = cm.Counting(transformedExpression);
            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        [DataRow(2, 2, 1)]
        [DataRow(100, 10, 10)]
        [DataRow(4, -2, -2)]
        public void SubstractInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            string inputExpression = $"{firstNumber}/{secondNumber}";
            string transformedExpression = cm.TransformExpression(inputExpression);
            var actualResult = cm.Counting(transformedExpression);
            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void Severaloperations()
        {
            string inputExpression = "2+2*2/2";
            string transformedExpression = cm.TransformExpression(inputExpression);
            var actualResult = cm.Counting(transformedExpression);
            Assert.AreEqual(actualResult, 4);
        }

        [TestMethod]
        public void ifDot()
        {
            string inputExpression = "4.3";
            string transformedExpression = cm.SyntaxAnalyz(inputExpression);
            Assert.AreEqual(transformedExpression,"4,3");
        }
        [TestMethod]
        public void WrongChar()
        {
            string inputExpression = "4a";
            string transformedExpression = cm.SyntaxAnalyz(inputExpression);
            Assert.AreEqual(transformedExpression, string.Empty);
        }
    }
}