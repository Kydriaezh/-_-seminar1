// Напишите программу,которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23

Console.WriteLine("Write number 1");
int first = int.Parse(Console.ReadLine());

string Crat (int num = 7, int num2 = 23)
{
    if (first % num == 0 && first % num2 == 0)   
        return "kratno";
    else    
        return "nekratno";
}
Console.WriteLine (Crat(first));

