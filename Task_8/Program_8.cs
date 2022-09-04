// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число и нажмите Enter");
int Number = Convert.ToInt32(Console.ReadLine());

int i;
for (i = 2; i <= Number; i += 2) 
Console.WriteLine(i);
