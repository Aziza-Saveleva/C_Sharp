﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int digit = 0;
while (num > 999)
    num /= 10;
digit = num % 10;
if (num < 100)
    Console.WriteLine("Третьей цифры нет");
else   
Console.WriteLine($"Третья цифра {digit}");