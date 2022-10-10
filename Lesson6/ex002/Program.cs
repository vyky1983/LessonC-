using static System.Console;
Clear();

// using System.Linq;

string text="(1,2)(2,3)(4,6)(6,7)".Replace("(","");
text="(1,2)(2,3)(4,6)(6,7)".Replace(")","");
WriteLine(text);

var data =text.Split(" ").ToArray();
       // .;
for (int i = 0; i < data.Length; i++)
{
 WriteLine(data[i]);
}