using static System.Console;

Clear();

// int[,] arra = new int[5, 6];
// FillArray(arra);

int[,] array1 = new int[4,4];
FillArray(array1);

void FillArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int colum = 0; colum < array.GetLength(0); colum++)
        {
            array[row, colum] = new Random().Next(1, 10);
            Write($"{array[row, colum]} * ");
        }
        System.Console.WriteLine();
    }
}
