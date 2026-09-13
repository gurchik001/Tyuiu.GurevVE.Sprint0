using Tyuiu.GurevVE.Sprint0.Task2.V0.lib;


namespace Tyuiu.GurevVE.Sprint0.Task2.V0.Test;

public class DataServiceTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CheckMessageValid()
    {
        var name = "Влад";
        var res = DataService.GetMessage(name);
        Assert.AreEqual("Привет, Влад", res);
        
    }
}