﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Kv (int N)
{
    int i = 0;
    double pere;
    while (i < N)
    {
        i+=1;
        pere = Math.Pow(i,3);
        Console.Write($"{pere}");
    }
}
Console.WriteLine("введите число");
int chislo = int.Parse(Console.ReadLine());
Kv(chislo);
