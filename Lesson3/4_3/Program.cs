// See https://aka.ms/new-console-template for more information
void Kv (int N)
{
    int i = 0;
    double pere;
    while (i < N)
    {
        i+=1;
        pere = Math.Pow(i,2);
        Console.Write($"{pere}");
    }
}
Console.WriteLine("введите число");
int chislo = int.Parse(Console.ReadLine());
Kv(chislo);