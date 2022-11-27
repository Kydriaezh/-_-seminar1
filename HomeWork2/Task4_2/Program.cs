// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели");
int n = int.Parse(Console.ReadLine());

string Week (int num)
{
    if (num == 6 || num == 7)   
        return "выходной";
    else    
        return "не выходной";
}
Console.WriteLine (Week(n));
