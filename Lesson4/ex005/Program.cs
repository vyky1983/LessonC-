using static System.Console;

Clear();

//int[,] doubleArray = new int[3, 6];
int[,] array = new int[3, 3];
//FillArray(doubleArray);
FillArray(array);

void FillArray(int[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i, j] = new Random().Next(1, 10);
            Write($"{doubleArray[i, j]} ");
        }
        WriteLine();
    }
}
//FillArray(Array);
