using static System.Console;
Clear();

string[,] table = new string[2,5];
//string.Empti
// вот ка выглядет двумерный масив и его индексы
/*table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
  table[1,0] table[1,1] *table[1,2]* table[1,3] table[1,4]*/

table[1,2] = "слово"; /* вот где будет находиться наше слово*/

for (int row = 0; row < 2; row++)
{
 for (int column = 0; column < 5; column++)
 {
  WriteLine($"{table[row,column]}--");
 }
}