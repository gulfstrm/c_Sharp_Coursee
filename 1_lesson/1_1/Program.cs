﻿// 1.Напишите программу ,которая на вход принимает два числа и проверяет,
//   является ли первое число квадратм второго.


Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

if(num1>num2)
{
   Console.WriteLine("да");
}

else
   Console.WriteLine("нет");