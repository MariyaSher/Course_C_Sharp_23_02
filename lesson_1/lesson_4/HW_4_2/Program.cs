// 2. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

int SumNums_1(int num)
{
    int n_sum = 0;

    while (num > 0)
    {
        n_sum += num % 10;
        num /=10;
    }
    return n_sum;
}

int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNums_1(num1));

