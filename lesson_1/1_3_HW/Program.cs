// 3. Напишите программу, которая на вход принимает число и выдает, является ли число четным.

int a;
a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0)

{
    Console.WriteLine("число четное");
}

else
{
    Console.WriteLine("число нечетное");
}