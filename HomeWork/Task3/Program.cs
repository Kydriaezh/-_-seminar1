// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.WriteLine("Write number");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.Write("чётное");
}

else 
    Console.Write("не чётное");

