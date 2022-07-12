// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("Введите количество вводимых чисел: ");
int m = int.Parse(Console.ReadLine()!);

int Count(int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        int number = int.Parse(Console.ReadLine()!);
        if (number > 0) count = count + 1;
    }
    return count;
}

int result = Count(m);
Console.WriteLine($"Количество чисел больше 0 = {result} ");