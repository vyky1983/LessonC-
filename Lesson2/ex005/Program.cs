/*Имеется одномерный масив array из n елементов, требуется найти элемент масива равный find

1. Установите счетчик index в позиции 0.
2. Если array[index]=find, алгоритм завершил работу успешно.
3. Увеличить index на 1.
4. Если index<n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.*/

using static System.Console;

Clear();

int[] array = { 1, 2, 13, 4, 5, 16, 71, 8 };

int n = array.Length;

int find = 71;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        WriteLine(index);
        break;
    }
    index++;
}
