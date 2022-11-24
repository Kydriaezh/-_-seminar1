// Напишите программу, которая на вход принимает одно число, а на выходе показывает все целые числа в промежутке от -N lj N
Console.WriteLine("Введите число");
string N_s = Console.ReadLine();
int N = int.Parse(N_s);
int OtrN = -N;

while(OtrN <= N)
{
    Console.Write($"{OtrN}");
    OtrN +=1;
}