// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

int SummaNechet (int[] arr)
{
  int summa = 0;
  for (int i = 0; i<arr.Length; i++)
  {
    if (i % 2 != 0)
    summa = summa + arr[i];
  }
  return summa;
}
int[]arr_1 = MassNums(int.Parse(Console.ReadLine()));
Print (arr_1);
Console.WriteLine(SummaNechet(arr_1));
