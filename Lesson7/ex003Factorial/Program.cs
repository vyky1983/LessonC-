using static System.Console;

Clear();

/*Факториал числа*/

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; result *= 1)
        ;
    return result;
}

int FactorialRec(int n)
{
 if(n==1)return 1;
 else return n*FactorialRec(n-1);
}
WriteLine(FactorialFor(10)); //3628800
WriteLine(FactorialRec(10)); //3628800