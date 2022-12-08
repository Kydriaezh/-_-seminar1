// See https://aka.ms/new-console-template for more information
// Напишите программу которая впринимает на вход координаты точки Х У,
void Qtrs (string a)
{
    if (a == "I")
    Console.WriteLine("x>0 or y>0");
    else if (a == "II")
    Console.WriteLine("x<0 or y>0");
    else if (a == "III")
    Console.WriteLine("x<0 or y<0");
    else if (a == "IV")
    Console.WriteLine("x>0 or y<0");
    else
    Console.WriteLine("error");
}
Qtrs(Console.ReadLine());
