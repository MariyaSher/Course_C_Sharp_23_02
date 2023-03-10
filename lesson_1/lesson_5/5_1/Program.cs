// 5.1 Напишите программу замена элементов массива:положительные элементы на соответствующие отрицательные, и наоборот. 
// [-4, -8, 8, 2] -> [4, 8, -8,-2]

int[] InputRandomMassive(int lengthMas, int minRangeMas, int maxRangeMas)
{
    int[] masRandom = new int[lengthMas]; //задаем массив
    for (int i = 0; i < lengthMas; i++)
{
    masRandom[i] = new Random().Next(minRangeMas, maxRangeMas); //случайные числа в диапазоне
}
return masRandom;
}
//ввод массива
void PrintMassive(int[] mas)
{
      for (int i = 0; i< mas.Length; i++)
         Console.Write($" {mas[i]} ");
      Console.WriteLine();
}

void MassConverter(int[] arr)
{
    for (int i=0; i< arr.Length; i++)
        arr[i]= -arr[i];
}

Console.WriteLine("Введите длину массива: ");
int lengthMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапазона случайного числа:  ");
int minRangeMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапазона случайного числа:  "); 
int maxRangeMas = int.Parse(Console.ReadLine()!);

int[] masRandom = InputRandomMassive(lengthMas, minRangeMas, maxRangeMas);
PrintMassive(masRandom);
MassConverter(masRandom);
PrintMassive(masRandom);
