using Tut2_s26735_Part2;


namespace Tut2_s26735_Part2_Tests
{
    public class Tests
    {
        [Test]
        public void TestAddition()
        {
            Calculator calculator = new Calculator(10, 5, '+');
            Assert.That(calculator.Calculation(), Is.EqualTo(15.0).Within(0.001));
        }

        [Test]
        public void TestExtraction()
        {
            Calculator calculator1 = new Calculator(3527, 7374, '-');
            Assert.That(calculator1.Calculation(), Is.EqualTo(-3847).Within(0.001));
        }

        [Test]
        public void TestMultiplication()
        {
            Calculator calculator2 = new Calculator(94, 23, '*');
            Assert.That(calculator2.Calculation(), Is.EqualTo(2162).Within(0.001));
        }

        [Test]
        public void TestDivision()
        {
            Calculator calculator3 = new Calculator(75, 3, '/');
            Assert.That(calculator3.Calculation(), Is.EqualTo(25).Within(0.001));
        }

        [Test]
        public void TestDivisionByZero()
        {
            Calculator calculator = new Calculator(40, 0, '/');
            Assert.Throws<DivideByZeroException>(() => calculator.Calculation());
        }

        [Test]
        public void TestMultiplicationByZero()
        {
            Calculator calculator = new Calculator(55,0,'*');
            Assert.That(calculator.Calculation(), Is.EqualTo(0));
        }

        [Test]
        public void TestInvalidOperation()
        {
            Calculator calculator = new Calculator(3, 3, '=');
            Assert.Throws<InvalidOperationException>(() => calculator.Calculation());
        }

        [Test]
        public void TestExtremelyLargeNumbers()
        {
            Calculator calculator = new Calculator(double.MaxValue, 938457934853, '*');
            Assert.IsTrue(double.IsInfinity(calculator.Calculation()), "Expected result is too big.");
        }

        [Test]
        public void TestExtremelySmallNumbers()
        {
            Calculator calculator = new Calculator(double.MinValue, 938457934853, '*');
            Assert.IsTrue(double.IsNegativeInfinity(calculator.Calculation()), "Expected result is too small.");
        }



    }
}