//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Введите 2 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a)
{
    max = b;
    System.Console.WriteLine($"Max = {max}");
}
else
{
    System.Console.WriteLine($"Max = {max}");
}