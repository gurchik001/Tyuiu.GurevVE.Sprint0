using Tyuiu.GurevVE.Sprint0.Task3.V0.lib;

namespace Tyuiu.GurevVE.Sprint0.Task3.V0.Test



{
    [TestClass]
    public class DataServiceTest
    {
    }

    public class TestClassAttribute : Attribute
    {
    }

    public class TestMethodAttribute : Attribute
    {


        [TestMethod]
        public void ChekedValid()
        {


            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}   