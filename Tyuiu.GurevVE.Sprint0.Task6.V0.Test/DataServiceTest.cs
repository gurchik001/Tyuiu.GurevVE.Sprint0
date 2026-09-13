using Tyuiu.GurevVE.Sprint0.Task6.V0.lib;
namespace Tyuiu.GurevVE.Sprint0.Task6.V0.Test
{

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5,};
            var res = DataServiceTest.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstractionArray(numbers);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void CheckMultArrayValid()
        {
            var numbers = new int[] {1, 2, 3, 4, 5};
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }

        private static double AdditionArray(int[] numbers)
        {
            throw new NotImplementedException();
        }
    }
    }


    public class TestClassAttribute : Attribute
    {
    }