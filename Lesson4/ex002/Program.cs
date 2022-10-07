using static System.Console;
Clear();

int[,] matrix = new int[3,4];

for (int row = 0; row < 3; row++)
{
 for (int column = 0; column < 4; column++)
 {
  Write($"{matrix[row,column]}");
 }
System.Console.WriteLine();
}
