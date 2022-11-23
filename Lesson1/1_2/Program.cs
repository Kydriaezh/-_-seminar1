// Напишите программу, которая будет выдаваьб название для недели по заданному номеру.
Console.WriteLine("ВВедите число");
int num1 = int.Parse(Console.ReadLine());

if (num1 == 1)
{
    Console.WriteLine("Понедельник");
}
else if (num1 == 2)
{
    Console.WriteLine("Вторник");
}
else if (num1 == 3)
{
    Console.WriteLine("Среда");
}
else if (num1 == 4)
{
    Console.WriteLine("Четверг");
}
else if (num1 == 5)
{
    Console.WriteLine("Пятница");
}
else
{
    Console.WriteLine("error");
}