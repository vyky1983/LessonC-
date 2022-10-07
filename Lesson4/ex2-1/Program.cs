using static System.Console;

Clear();

int[,] matrix = new int[3, 6];
matrix[2,2] = 9;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
}
