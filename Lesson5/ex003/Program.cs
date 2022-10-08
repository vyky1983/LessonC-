using static System.Console;

Clear();
int[] array = new int[5] { 1, 2, 3, 4, 5 };
ReverseArray(array);

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        // int rnd = new Random().Next(1, 10);
        // arr[i] = rnd;
        Write($"{arr[i]} ");
    //     System.Console.WriteLine();
     }
}
