using CalculatorProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorProjectTests
{
    [TestClass]
    public class CalculatorProjectTests
    {

        public TestContext? TestContext { get; set; }

        [TestMethod]
        public void CalculatorProjectAdd_2_4_returns_6()
        {
            int x;
            int y;
            x = int.Parse(TestContext?.Properties?["ValueX"]?.ToString());
            y = int.Parse(TestContext?.Properties?["ValueY"]?.ToString());

            // TestContext?.WriteLine("In test: " + TestContext?.TestName?.ToUpper());
            Calculator c = new Calculator();
            int result = c.Add(x, y);
            Assert.AreEqual(14, result); 
        }
    }
}