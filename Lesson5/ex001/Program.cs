using static System.Console;
Clear();

int[] array =new int[10];
PrintArray(array);

 void PrintArray(int[] arr)
 {
  for(int i=0; i<arr.Length; i++)
  {
   int rnd =new Random().Next(1,10);
   arr[i] =rnd;
   Write($"{arr[i]} ");
  }
 }