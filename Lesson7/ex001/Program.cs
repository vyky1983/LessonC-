using static System.Console;
Clear();

/*Собрать строку с числами от а до b, a ≤ b*/

string NumbersFor(int a, int b)
{
 string result = string.Empty;
 for(int i = a; i <=b; i++)
 
 {
  result+=$"{i} ";
 }
 return result;
}

string NumbersRec(int a, int b)
{
 if(a<=b)return $"{a} "+ NumbersRec(a+1,b);
 else return string.Empty;
}
WriteLine(NumbersFor(1,10));
WriteLine(NumbersFor(1,10));