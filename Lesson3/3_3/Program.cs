// See https://aka.ms/new-console-template for more information
int ReadNumber (string massage)
{
    Console.Write (massage);
    var s = Console.ReadLine();
    int a = s == null ? 0: int.Parse (s);
    return a;
}

double Distant (int ax, int ay, int bx, int by)
{
    double result;
    result = Math.Sqrt (Math.Pow (bx-ax,2)+ Math.Pow (by - ay, 2));
    return result;
}

int ax = ReadNumber("введите ax:");
int ay = ReadNumber("введите ay:");
int bx = ReadNumber("введите bx:");
int by = ReadNumber("введите by:");

Console.WriteLine (Math.Round(Distant(ax, ay, bx, by), 2));
