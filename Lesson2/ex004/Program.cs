using static System.Console;

Clear();

//               0   1   2   3   4    5   6  7   8
int[] array = { 619, 12, 32, 64, 151, 64, 27, 8, 91 };
array[6] = 12;
 //WriteLine($"El --> {array[5]}");

int max = Max(
 Max(array[0], array[1], array[2]), 
 Max(array[3], array[4], array[5]),
 Max(array[6], array[7], array[8]));
System.Console.WriteLine($"Mаксимальное число --> {max} ");

int Max(int arg1, int arg2, int arg3 )
{
 int result = arg1;
 if(result<arg2) result=arg2;
 if(result<arg3) result=arg3;
 return result;
}