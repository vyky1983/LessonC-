using static System.Console;
Clear();

//Вид 1.

void Method1()
{
 WriteLine("--> Я автор ...");
}  
Method1();


// Вид 2.
void Method2(string smg)
{
 WriteLine(smg);
}
Method2("--> Текст сообщения");


void Method21(string smg, int count)
{
 int i =0;
 while(i<count)
 {
  System.Console.WriteLine(smg);
  i++;
 }
}
Method21(smg:" текст", count: 4);
//Method2("--> Текст сообщения");


// Вид 3.

