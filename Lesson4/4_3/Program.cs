// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

int Proiz(int num)
{
    int allpr = 1;
    for (int i = 1; i <= num; i++)
    {
        allpr = allpr*i;

    }
    return allpr;
}
Console.WriteLine(Proiz(int.Parse(Console.ReadLine())));
