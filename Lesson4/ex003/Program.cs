using static System.Console;

Clear();
int[,] matrix =new int[5,8];

int[,] matrix1 =new int [6,6];
matrix1[0,4] =6;
matrix1[1,3] =9;
matrix1[2,5] =4;
//PrintArray(matrix);
PrintArray(matrix1);

void PrintArray(int[,] matrix)
{
    int[,] matr = new int[5, 8];

    for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int colum = 0; colum < matr.GetLength(1); colum++)
        {
            Write($"{matr[row, colum]} ");
        }
        WriteLine();
    }
}

