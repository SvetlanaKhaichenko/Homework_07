// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] NewRandomMas(int rows, int columns)
{
    int[,] mas = new int[rows, columns];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().Next(0, 16);
        }
    }
    return mas;
}

int[] CheckMas(int[,] mas, int value)
{
    int[] desired = new int[2];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (mas[i, j] == value)
            {
                desired[0] = i + 1;
                desired[1] = j + 1;
            }
        }
    }
    return desired;
}

void PrintArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Print(int[] mas)
{
    if (mas[0] == 0 || mas[1] == 0)
    {
        System.Console.Write("Такого числа в массиве нет");
    }
    else
    {
        for (int i = 0; i < 1; i++)
        {
            for (int j = 1; j < mas.Length; j++)
            {
                System.Console.Write($"Позиция элемента в массиве: ({mas[i]}, {mas[j]})");
            }
        }
    }
}

System.Console.WriteLine("Введите значение числа в массиве: ");
int value = Convert.ToInt32(Console.ReadLine());
int[,] valuuemas = NewRandomMas(3, 4);
PrintArray(valuuemas);
Print(CheckMas(valuuemas, value));
