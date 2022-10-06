// using static System.Console;

// Clear();

// //Вид 1.

// void Method1()
// {
//     WriteLine("--> Я автор ...");
// }
// Method1();

// // Вид 2.
// void Method2(string smg) //принимает входные
// {
//     WriteLine(smg);
// }
// Method2("--> Текст сообщения");

// void Method21(string smg, int count) // прнимает аргумены
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(smg);
//         i++;
//     }
// }
// Method21(smg: " текст", count: 4);

// //Method2("--> Текст сообщения");


// // Вид 3.

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// Method3();
// int year = Method3();
// WriteLine(year);

//Вид 4.

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res =Method4(10, "text");
System.Console.WriteLine(res);
