﻿// Задача 6: 
// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да 
// -3 -> нет 
// 7 -> нет

Console.WriteLine("Enter the number [N1, N2, N3]");
int N = int.Parse(Console.ReadLine()!);

int a = 0;

if (a == N/2)
{
    Console.Write("Деление без остатка");
}

if (a != N/2)
{
    Console.Write("Деление c остатком");
}


