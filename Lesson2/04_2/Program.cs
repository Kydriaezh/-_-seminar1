// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write number 1");
int first = int.Parse(Console.ReadLine());

string Crat (int num)
{
    if (num % 23 == 0 && num % 7 == 0)   
        return "kratno";
    else    
        return "nekratno";
}
Console.WriteLine (Crat(first));
