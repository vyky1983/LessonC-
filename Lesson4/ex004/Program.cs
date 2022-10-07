using static System.Console;

Clear();

int[,] matrix = new int[4, 8];
PrintArray(matrix);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
        WriteLine();
    }
}
