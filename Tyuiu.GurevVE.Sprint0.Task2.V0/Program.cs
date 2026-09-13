using Tyuiu.GurevVE.Sprint0.Task2.V0.lib;
namespace Tyuiu.GurevVE.Sprint0.Task2.V0;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DataService.GetMessage("Влад"));
        Console.ReadKey();
    }
}