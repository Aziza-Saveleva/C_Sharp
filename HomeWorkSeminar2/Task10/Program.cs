﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int digit = num / 10 % 10;
if (num < 100 || num >= 1000)
    Console.WriteLine("Введённое число не трёхзначное");
else
    Console.WriteLine($"Вторая цифра {digit}");