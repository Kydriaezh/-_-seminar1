﻿// Напишите программу, которая на вход принимает два числа A и B, и возводит число A 
// в целую степень B. с помощью рекурсии. 

int Num (int a, int b)
{
    if (b==0) return 1;
    return Num (a, b-1) * a;
}

Console.Write(Num(3,5));
