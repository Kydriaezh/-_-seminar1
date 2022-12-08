// Напишите программу, которая принимает на вход число А и выводит сумму чисел от 1 до А

int SumNum(int num)

{
    int summa = 0;
    for (int i = 1; i <= num; i++)
    {
        summa +=i;
    }
    return summa;
}

Console.WriteLine(SumNum(int.Parse(Console.ReadLine())));