using static System.Console;

Clear();
string res = Method4(10, "text");
System.Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

