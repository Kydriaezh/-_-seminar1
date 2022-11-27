// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

void Crat (int num, int num2)
{
    if (num % num2 == 0)
        Console.WriteLine("kratno");
    else    
        Console.WriteLine($"nekratno, ostatok = {num % num2}");
}

Console.WriteLine("Write number 1");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("Write number 2");
int second = int.Parse(Console.ReadLine());

Crat(first,second);
