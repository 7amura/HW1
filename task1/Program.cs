// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7 
// a = 2 b = 10 -> max = 10 
// a = -9 b = -3 -> max = -3


Console.WriteLine("Enter the number n1");
int n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the number n2");
int n2 = int.Parse(Console.ReadLine()!);

if (n1 < n2)
{
    Console.WriteLine("The first number is Less than the second");
}
if (n1 > n2)
{
    Console.WriteLine("The first number is greater than the second");
}
else
{
    Console.WriteLine("These numbers are equal");
}
