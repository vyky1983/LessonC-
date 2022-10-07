using static System.Console;
Clear();

int Factorial (int n)
{
 if(n==1)return 1;
 else return n* Factorial(n-1);
}
WriteLine(Factorial(3));