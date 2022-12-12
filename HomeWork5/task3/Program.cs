// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (100 - 1) + 1, 2);
    }
    return arr;
}

void Dif(double[] arr)
{
  double max = arr [0];
  double min = arr [0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)        
            max = arr[i];
        
        else if (arr[i] < min)        
            min = arr[i];        
    }
  Console.WriteLine($"Максимальное число {max}, Минимальное число {min}");
  Console.WriteLine($"Разница между максимальным и минимальным числом: {Math.Round(max - min, 2)}");
}

double[] arr_1 = MassNums(int.Parse(Console.ReadLine()));
Print (arr_1);
Dif(arr_1);
