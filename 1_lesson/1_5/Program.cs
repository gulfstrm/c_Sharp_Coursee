﻿// Напишите программу, которая на вход принимает два числа и выдает
// , какое число большее , а каое меньшее.
Console.WriteLine("Введите число 1 ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

if(num1>num2)
{
    Console.WriteLine("max = num1");
}
else
Console.WriteLine("max = num2");