// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со 
//сторонами такой длинны

void Rectan()

{
    int c = int.Parse(Console.ReadLine());
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    if (a < b+c & b < a+c & c < a+b)
    Console.WriteLine("yes");
    else
    Console.WriteLine("No");
}
Rectan();