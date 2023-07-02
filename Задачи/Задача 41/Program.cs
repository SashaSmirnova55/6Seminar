// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Main()
{
    int[] array = ReadInt("Введите через пробел числа: ");
    PrintArray(array);
    System.Console.WriteLine($"Количество введённых положительных чисел равно: {Counter(array)}");
}

int[] ReadInt(string text)
{
    System.Console.WriteLine(text);
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",  ", array) + "]");
}

int Counter(int[] array)
{
  
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

//--------------------------------------------------------------------------------

Main();