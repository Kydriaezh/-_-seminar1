// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзнчное число");
int num = int.Parse(Console.ReadLine());
num = num / 10;
Console.WriteLine(num % 10);


