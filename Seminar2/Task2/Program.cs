﻿//     Напишите программу, которая выводит случайное трехзначное 
//     число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine($"{num}");
int digit1 = num / 100;
int digit2 = num % 10;
Console.WriteLine($"{digit1}{digit2}");