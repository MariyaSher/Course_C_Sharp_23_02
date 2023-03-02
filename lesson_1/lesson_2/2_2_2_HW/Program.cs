 // 2.Напишите программу, которая выводит случайное трехзначное число и 
//   удаляет вторую цифру этого числа.

string SecondNum(int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
        return $"{num} -> {num / 100 *10 + num % 10}";
    return "число не является трехзначным";    
}

Console.WriteLine(SecondNum(int.Parse(Console.ReadLine()!)));
