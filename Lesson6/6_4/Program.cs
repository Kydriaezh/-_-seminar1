// See https://aka.ms/new-console-template for more information

void Print(int[] arr)
{
    int col = arr.GetLength(1);
    int raw = arr.GetLength(0);

    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
            Console.Write($"{arr[i]} ");
    Console.WriteLine();
    }
}

int[] MassNums(int raw, int col)
{
    int[,] arr = new int[raw, col];

    for (int i = 0; i < raw; i++)
    for (int j = 0; j < col; j++)
    {
        arr[i,j] = new Random().Next(100, 999);
    }
    return arr;
}

int[,] MasClone(int[,]  arr)
{
    int col = arr.GetLength(1);
    int raw = arr.GetLength(0);
    int[,] new_arr = new int [raw, col];

    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
            new_arr[i,j] = arr[i, j];
    }
    return new_arr;
}
int[,] arr_1 = MassNums(int.Parse(Console.ReadLine()));
Print (arr_1);
int[,] arr_2 = MasClone(arr_1);
Print(arr_2);

