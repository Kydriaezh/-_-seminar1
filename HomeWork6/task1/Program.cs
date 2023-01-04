// Пользователь вводит с клавиатуры М чисел.
// Посчитать сколько чисел больше 0 ввёл пользователь

Console.Write("Сколько чисел хотите ввести?: ");
int a = int.Parse(Console.ReadLine());
int Check (int num)
{
    int count = 0;    
    for (int i = 1; i <= num; i++)
    {
        Console.Write("Введите число");
        int a = int.Parse(Console.ReadLine());
        if (a > 0) count++;
    }
    return count;
}


Console.WriteLine($"Количество чисел больше 0: {Check(a)}");