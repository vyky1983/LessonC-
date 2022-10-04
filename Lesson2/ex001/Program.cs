using static System.Console;
Clear();
// f(x) = x*x +7


Write(" Введите число x --> ");
int x = Convert.ToInt32(ReadLine());
function(x);

int function (int x)
{
 int result = x*x+7;
 System.Console.WriteLine(result);
 return result;
}