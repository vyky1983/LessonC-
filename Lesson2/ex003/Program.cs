using static System.Console;

Clear();

// Max();


int Max(int arg1, int arg2, int arg3 )
{
 int result = arg1;
 if(result<arg2) result=arg2;
 if(result<arg3) result=arg3;
 return result;
}

int a1 = 124;
int b1 = 5;
int c1 = 21;

int a2 = 14;
int b2 = 5361;
int c2 = 212;

int a3 = 14;
int b3 = 53;
int c3 = 316;

int max1 =Max(a1,b1,c1);
System.Console.WriteLine(max1);

int max2 =Max(a2,b2,c2);

int max3 =Max(a3,b3,c3);

int max =Max(max1,max2,max3);
Write($"Максимальное число --> {max}");




// int max = a1;
// if (b1 > max)
//     max = b1;
// if (c1 > max)
//     max = c1;

// if (a2 > max)
//     max = a2;
// if (b2 > max)
//     max = b2;
// if (c2 > max)
//     max = c2;

// if (a3 > max)
//     max = a3;
// if (b3 > max)
//     max = b3;
// if (c3 > max)
//     max = c3;
// Write($"Максимальное число --> {max}");
