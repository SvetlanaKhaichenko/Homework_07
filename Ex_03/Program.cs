// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[] Sum(int[,] mas)
{
    int[] sum = new int[mas.GetLength(1)];
    int sum1 = 0;
    for (int k = 0; k < sum.Length; k++)
    {
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            int j = 0;
            while (j < mas.GetLength(1))
            {
                sum1 = sum1 + mas[i, j];
            }
            j++;

        }
        sum[k] = sum1;
    }
    return sum;

}

void PrintArray(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
}


int[,] givenArray = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

PrintArray(Sum(givenArray));


