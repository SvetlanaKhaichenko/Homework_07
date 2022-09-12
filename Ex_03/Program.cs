// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



void PrintArray(double[] mas1)
{
    for (int i = 0; i < mas1.Length; i++)
    {
        Console.Write($"{mas1[i]} ");
    }
}

double[] ArraySR(int[,] mas)
{
    double[] sum = new double[mas.GetLength(1)];

    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            sum[j] = sum[j] + mas[i, j];

        }
    }
    for (int k = 0; k<sum.Length; k++)
    {
        sum [k] = sum [k] / mas.GetLength(0);
    }

    return sum;
}





int[,] givenArray = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintArray(ArraySR(givenArray));


