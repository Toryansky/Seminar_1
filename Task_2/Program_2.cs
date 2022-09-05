// Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число и нажмите Enter");
        int FirstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число и нажмите Enter");
        int SecondNumber = Convert.ToInt32(Console.ReadLine());

        if (SecondNumber == FirstNumber)
        {
            Console.Write("Второе число равно первому");
        }
        else if (SecondNumber > FirstNumber)
        {
            Console.Write("Второе число больше первого");
        }   
        else
        {
            Console.Write("Первое число больше второго");
        }
    }
}