// 2. Напишите программу, которая принимает на вход три числаи выдает 
//    максимальное из них.

Console.WriteLine("Нахождение наибольшего из трех чисел");

int a = 2;
int b = 3;
int c = 7;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write( "max =");
Console.WriteLine (max);