// Напишите программу, которая на вход принимает одно число (N),а на выходе  показывает все целые числа в промежутке от -N до N
// Например:
// 4: -4, -3, -2, -1, 0, 1, 2, 3, 4

System.Console.WriteLine("Введите число");
int numN = Convert.ToInt32(Console.ReadLine());
int i = -numN;

while (i <= numN)
{
    System.Console.Write($"{i} ");
    i = i + 1;
}
System.Console.WriteLine();
