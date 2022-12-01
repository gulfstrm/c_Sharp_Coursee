// 3.Напишите программу , которая на вход принимает одно число
// (n) , а на выходе показывает все целые числа в промежутке от -n до n.

Console.WriteLine("Введите число: ");
string A = Console.ReadLine();
int N = int.Parse(A);
int NegN = - N;

while(NegN < N)
{
    Console.Write($"{NegN} ") ;
    NegN +=1;
}