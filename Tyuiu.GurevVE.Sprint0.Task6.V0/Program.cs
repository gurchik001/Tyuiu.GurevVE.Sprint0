using Tyuiu.GurevVE.Sprint0.Task6.V0.lib;
namespace Tyuiu.GurevVE.Sprint0.Task6.V0;

class Program
{
    static void Main(string[] args)
    {
        int[] arraynums = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynums));
        Console.WriteLine("Разность элементов массива = " + DataService.SubstractionArray(arraynums));
        Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arraynums));
        Console.ReadKey();
    }
}