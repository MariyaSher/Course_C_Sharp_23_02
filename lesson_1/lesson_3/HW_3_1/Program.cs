// 1.напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void CheckPalindromicNumber(int number)
{
    if(number >= 10000)
    {
        int num1 = number / 10000;
        int num2 = number % 10;
 
            if(num1 == num2)
            {
                number = number / 10;
                int num3 = (number / 100)% 10;
                int num4 = number % 10;
                if(num3== num4)
                    Console.WriteLine("Да");
            }
            else 
            Console.WriteLine("Нет");
            
    }
    else
    Console.WriteLine("Некорректное число!");
}
 
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);