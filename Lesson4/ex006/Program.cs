using static System.Console;

Clear();

/*как представить черно-белое изображение
int[,] pic =new int[23,25];
0 - закрашенный пиксель
1 - незакрашенный пиксель
как скрасить область ?
*/

int[,] img = new int[23, 25];
PrintArray(img);
// FillArray(13,13);
// PrintArray(img);

void PrintArray(int[,] pic)
{
    for (int i = 0; i < pic.GetLength(0); i++)
    {
        for (int j = 0; j < pic.GetLength(1); j++)
        {
            pic[i,j]= new Random().Next(0,2);
            Write(pic[i,j]);
            if (img[i, j] == 0)
                Write($" ");
            else
                Write($"+");
        }
        System.Console.WriteLine();
    }
}

// void FillArray(int row, int col)
// {
//     if (img[row, col] == 0)
//     {
//         img[row, col] = 1;
//         FillArray(row - 1, col);
//         FillArray(row, col - 1);
//         FillArray(row + 1, col);
//         FillArray(row - 1, col + 1);
//     }
// }
// FillArray(img);
// FillArray(13,13);
// FillArray(img);