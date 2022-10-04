using static System.Console;
Clear();

// f(x,y,z) = x² +7;
Write(" Введите число х --> ");
int x = Convert.ToInt32(ReadLine());
Function(x);

void Function (int x)
{
 int result = x*x+7;
 WriteLine($" Ваш результат = [{result}] ");
 //return result;
}