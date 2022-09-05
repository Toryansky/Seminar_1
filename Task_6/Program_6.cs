// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число для проверки и нажмите Enter");
        int Number = Convert.ToInt32(Console.ReadLine());

        if (Number % 2 == 0)
        {
            Console.WriteLine("Введенное число чётное");
        }
        else if (Number % 2 != 0)
        {
            Console.WriteLine("Введенное число нечётное");
        }
    }
}