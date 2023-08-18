// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго
// Например:
// а = 25, b = 5, ответ - да

System.Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
Console.WriteLine(square);

if (num1 == square)
    System.Console.WriteLine("да");
else
    System.Console.WriteLine("нет");
