// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число и нажмите Enter");
        int FirstNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Введите второе число и нажмите Enter");
        int SecondNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Введите третье число и нажмите Enter");
        int ThirdNumber = Convert.ToInt32(Console.ReadLine());
        
        int max;
        max = FirstNumber;

        if (FirstNumber < SecondNumber)
        {
        max = SecondNumber;
        }
        if (ThirdNumber > max)
        {
        max = ThirdNumber;
        }
    
        Console.Write("Максимальное число ");
        Console.Write(max);
    }   
}