using static System.Console;

Clear();
int[] array1 = new int [25];
int[] array = new int[10];
FillArray(array1);
PrintArray(array1);

void FillArray(int[] colection)
{
    int lenght = colection.Length;
    int index = 0;
    while (index < lenght)
    {
        colection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Write(col[position] + ", ");
        position++;
    }
}
