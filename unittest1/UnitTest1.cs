using batch2022;

namespace unittest1
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
            calculate c = new calculate();
            int result = c.Add(10, 20);
            Assert.AreEqual(30, result);    
        }
    }
}