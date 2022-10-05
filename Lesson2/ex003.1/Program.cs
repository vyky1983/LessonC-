using static System.Console;
Clear();

int x =125;
int y =65;
int z =965;
// int max= Max(x,y,z);
// WriteLine(max);
Max(x,y,z);

int Max(int arg1,int arg2,int arg3)
{
 int res =arg1;
 if(arg2>res)res=arg2;
 if(arg3>res)res=arg3;
 Write($" максимальное число --> {res}");
 return res;
 }
//Write(res);
