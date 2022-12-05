using ConsoleApp2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumShouldRetrunCorrectValueTest()
        {
            Calculator calculator = new Calculator();
            int res = calculator.Sum(3, 5);

            Assert.AreEqual(8, res);
        }

        [TestMethod]
        public void SubStractionShouldRetrunCorrectValueTest()
        {
            Calculator calculator = new Calculator();
            int res = calculator.Substraction(10, 5);

            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void MultiplyShouldRetrunCorrectValueTest()
        {
            Calculator calculator = new Calculator();
            int res = calculator.Multiply(3, 5);

            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void DivideShouldRetrunCorrectValueTest()
        {
            Calculator calculator = new Calculator();
            int res = calculator.Divide(15, 5);

            Assert.AreEqual(3, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideShouldThrowExceptionTest()
        {
            Calculator calculator = new Calculator();
            int res = calculator.Divide(10, 0);
        }
    }
}