// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int ReadNumber (string massage)
{
    Console.Write (massage);
    var s = Console.ReadLine();
    int a = s == null ? 0: int.Parse (s);
    return a;
}

double Distant (int ax, int ay, int az, int bx, int by, int bz)
{
    double result;
    result = Math.Sqrt (Math.Pow (bx-ax,2)+ Math.Pow (by - ay, 2) + Math.Pow (bz - az, 2));
    return result;
}

int ax = ReadNumber("введите ax:");
int ay = ReadNumber("введите ay:");
int az = ReadNumber("введите az:");
int bx = ReadNumber("введите bx:");
int by = ReadNumber("введите by:");
int bz = ReadNumber("введите bz:");

Console.WriteLine (Math.Round(Distant(ax, ay, az, bx, by, bz), 2));
