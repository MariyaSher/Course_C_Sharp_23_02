// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine(" Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);

void Div(int n)
{
    if(n % 7 ==0 & n % 23 ==0)
        Console.WriteLine(" Кратно ");
        else
        Console.WriteLine(" Некратно ");
}
Div(n);
