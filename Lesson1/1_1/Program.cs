﻿// Напишите программу которая на вход принимает два числа и проверяет является ли первое число квадратом второго
Console.WriteLine("ВВедите число 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("ВВедите число 2");
int num2 = int.Parse(Console.ReadLine());

if (num2 == num1 * num1)
{
    Console.WriteLine("да");
}
else 
    Console.WriteLine("нет");

