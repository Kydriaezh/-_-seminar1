﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int ThirdDigit(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
