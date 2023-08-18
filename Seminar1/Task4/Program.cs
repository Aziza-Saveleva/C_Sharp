// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа
// Например:
// 456 - 6

System.Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{num % 10}");
