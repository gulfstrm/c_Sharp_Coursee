//  Напиши программу , которая на вход принимает число N ,
//  а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Введите число  ");

int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)

    Console.WriteLine("Четное");

else
    Console.WriteLine("нечетное");