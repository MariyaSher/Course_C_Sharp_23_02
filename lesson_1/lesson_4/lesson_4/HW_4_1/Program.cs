// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.

double PowNum(int a, int b)
{
    double n_pow = 1;
    int b_abs = Math.Abs(b);

    for (int i = 1; i <= b_abs; i++)
    {
        if (b > 0)
            n_pow*=a;
            else
                n_pow /=a;
    }
    return n_pow;
}

Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввести степень числа: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(PowNum(num1, num2));