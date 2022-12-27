// Напишите программу, которая найдёт точку пересечения двух прямых, заданными уровнениями
// y=k1*x +b1, y=k28x+b2, значения b1, k1, b2, k2 здаются пользователем

void Tp (double b1, double b2, double k1, double k2)

{   
    if (x != 0 && y != 0) 
    {    
    double x = (b2-b1)/(k1-k2);
    double y = b1*x + k1;    
    Console.WriteLine($" точка пересечения {x},{y}");
    }
    else
    Console.Write("нет точек пересечения");
}

Tp(int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()));