// 3. Напишите программу, которая принимает на вход число N  и выдает произведение чесел от 1 дл N. 

int CompositionNum(int num)
{
    int mutiply = 1;
    for (int i = 1; num >=i; i++)
        mutiply *=i;

        return mutiply;
}

int A = int.Parse(Console.ReadLine()!);
int result = CompositionNum(A);
Console.WriteLine (result);
