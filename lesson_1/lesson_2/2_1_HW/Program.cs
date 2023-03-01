// 1. Напишите программу, которая принимает на вход трехзначное число и на выходе
//    показывает вторую цифру этого числа.
int TakeNum(int num )
{
    Console.WriteLine(num);
    return (num % 100)/10;
}

int result = TakeNum(new Random().Next(100, 1000));
 Console.WriteLine(result);