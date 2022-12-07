// Задача 4: 
// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7 
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Enter the number: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the number: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the number: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;
if (a > b && a > c)
{
    Console.WriteLine("max = a");
}
else if (b > a && b > c)
{
    Console.WriteLine("max = b");
}
else
{
    Console.WriteLine("max = c");
}

