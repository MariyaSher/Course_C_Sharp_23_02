// 5.4 Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.


int[] MultiMas(int[] arr)
{
    int size = arr.Length;
    int[] newMass = new int[size / 2 + size % 2];
    for (int i = 0; i < size / 2; i++)
    {
        newMass[i] = arr[i] * arr[size - 1 - i];
    }
    return newMass;
}

Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапазона случайного числа:  ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапазона случайного числа:  ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

int[] newNewMass = MultiMas(mass);
Print(newNewMass);