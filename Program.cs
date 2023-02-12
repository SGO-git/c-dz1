//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Введите 2 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    System.Console.WriteLine($"Max = {a}");
}
else
{
    System.Console.WriteLine($"Max = {b}");
}