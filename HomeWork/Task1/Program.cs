// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число больше, а какое меньше.

Console.WriteLine("ВВедите число 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("ВВедите число 2");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
   Console.Write($"Число {num1} больше чем {num2}");
}
else 
   Console.Write($"Число {num1} меньше чем {num2}");
