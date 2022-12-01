// Напишите программу которая впринимает на вход координаты точки Х У,
void Qtrs (int x, int y)
{
    if (x == 0 || y == 0)
    Console.WriteLine("x=0 or y=0");
    else if (x > 0 && y > 0)
    Console.WriteLine("I");
    else if (x < 0 && y > 0)
    Console.WriteLine("II");
    else if (x << 0 && y < 0)
    Console.WriteLine("III");
    else if (x > 0 && y < 0)
    Console.WriteLine("IV");

}
Qtrs(7,8);