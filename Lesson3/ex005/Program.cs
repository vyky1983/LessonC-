using static System.Console;

Clear();

/*1. Найти позицию минимального Элемента в неотсортированной части масива
2. Пройзвести обмен этого элемента со значении первой неотсортированной позиции
3. Повторять пока есть неотсортированные элементы */

int[] array = { 1, 9, 3, 4, 5, 6, 2, 1, 1 };
PrintArray(array);
SelectionSort(array);

void PrintArray(int[] array)
{
    //int count = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++) 
        {
         if(array[j]<array[minPosition]) minPosition=j;
         }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(array);
SelectionSort(array);
