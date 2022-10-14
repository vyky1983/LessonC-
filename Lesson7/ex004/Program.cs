using static System.Console;

Clear();

/* Вычислить aⁿ */

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; result *= a)
        result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    //return n==0?1:PowerRec(n-1)*a;
    if (n == 0)
        return 1;
    else
        return PowerRec(a, n - 1) * a;
}

WriteLine(PowerFor(2, 10));
WriteLine(PowerRec(2, 10));
