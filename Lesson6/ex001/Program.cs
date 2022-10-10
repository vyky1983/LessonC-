using static System.Console;

Clear();

// const double Pi =3.1514;
// int a;

// string caption = "Intensiv C# demo text";
// int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
// int screenHeightPosition = Console.WindowHeight / 2;

// DrawText(caption, screenWidth, screenHeightPosition);

// DrawText(TextReader: caption,
//        top: screenHeightPosition);

/*Пример 1*/
double a = 1,
    b = -26,
    c = 120;
var d = b * b - 4 * a * c;
double x1 = (-b + Math.Sqrt(d)) / (2 * a);
double x2 = (-b - Math.Sqrt(d)) / (2 * a);
Write("Пример 1 --> ");
WriteLine($"x1= {x1} x2= {x2}");



/* Пример 2*/

a = 2;
b = 1;
c = -3;
d = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b - Math.Sqrt(d)) / (2 * a);
x2 = (-b - Math.Sqrt(d)) / (2 * a);
Write("Пример 2 --> ");
WriteLine($"x1= {x1} x2= {x2}");

/* Пример 3*/

a = 1;
b = 1;
c = -6;
d = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b - Math.Sqrt(d)) / (2 * a);
x2 = (-b - Math.Sqrt(d)) / (2 * a);
Write("Пример 3 --> ");
WriteLine($"x1= {x1} x2= {x2}");
