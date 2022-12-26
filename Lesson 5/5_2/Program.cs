// Напишите программу хамена элеметов массива: положительные элементы 
// замените на соответсвующие отрицательные, и наоборот.

void Print (int [] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}");
    Console.WriteLine();    
}

int MassNums (int size, int from, int to)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;    
}

void Massive(int[] arr_1)
{
    for (int i = 0; i < arr_1.Length; i++);
    arr_1[i] = -arr_1[i];
}
int[] arr_1 = Massive(int.Parse(Console.ReadLine()));
Print (arr_1);
Massive(arr_1);
Print(arr_1);