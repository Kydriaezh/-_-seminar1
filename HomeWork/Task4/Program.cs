// Напишите программу, которая на вход принимает число N, а на выходе
// показывет все чётные числа от 1 до N

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int i = 2;
while (i <= num)
    {
        Console.WriteLine($"{i}");
        i += 2;
    }
