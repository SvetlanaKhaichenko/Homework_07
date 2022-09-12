// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[] NumberPosition(string a)
{
    a = a.Replace("(", "");
    a = a.Replace(")", "");
    string[] mas1 = a.Split(",");
    int[] mas = new int[mas1.Length];
    for (int i = 0; i < mas1.Length; i++)
    {
        mas[i] = Convert.ToInt32(mas1[i]);
    }
    return mas;
}

void PrintValuePosition(int[,] mas, int[] given)
{
    if (given[0] > 0 && given[1] > 0 && given[0] <= mas.GetLength(0) && given[1] <= mas.GetLength(1))
    {

        int i = given[0] - 1;
        int j = given[1] - 1;
        Console.WriteLine($"Значение в массиве равно: {mas[i, j]}.");

    }
    else
    {
        Console.WriteLine("Такой позиции не существует в матрице.");
    }
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

int[,] givenArray = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
System.Console.WriteLine("Введите позицию элемента в матрице через запятую");
PrintValuePosition(givenArray, NumberPosition(Console.ReadLine()));
System.Console.WriteLine();
PrintArray(givenArray);