﻿//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int NumbCount (int n)

{
    int count = 0;
    int summa = 0;
    while (n>0)
    {
        summa = summa + n % 10;
        n = n / 10;        
        count ++;
    }
    return summa;
}
Console.WriteLine(NumbCount(int.Parse(Console.ReadLine())));
