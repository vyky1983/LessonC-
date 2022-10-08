using static System.Console;

Clear();

int[,] array = new int[6, 6];
PrintArray(array);

void PrintArray(int[,] arr)
{
    for (int sow = 0; sow < arr.GetLength(0); sow++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int rnd = new Random().Next(1, 10);
            arr[sow, j] = rnd;
            Write($"{arr[sow, j]} ");
        }
        WriteLine();
    }
}
