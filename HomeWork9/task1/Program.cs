// Задайте значение N. Напишите программу, которая выведет все чётные натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.



void NumSum (int m, int n)
{
    
       if (m > n) return;
    {   
        int sum =0;
        sum = sum + m++; 
        Console.WriteLine($" {sum} ");
        NumSum (m+1, n);
    }
      
}
NumSum(4,8);