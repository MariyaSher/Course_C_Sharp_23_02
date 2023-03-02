// Напишите программу, которая принимает на вход, цифру, обозначающую день недели и проверяет, является ли этот день выходным.

void Weekend(int num)
{
    string text = "нет";
if (num ==7 || num == 6 ) text = "выходной";
    else if (num < 6 && num > 0) text = "рабочий день";
    else text = "не больше недели";

    Console.WriteLine($"{num} -> {text}");
}

Weekend(int.Parse(Console.ReadLine()!));

