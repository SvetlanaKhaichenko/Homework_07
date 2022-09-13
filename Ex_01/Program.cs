// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] NewRandomMas(int rows, int columns)
{
    double[,] mas = new double[rows, columns];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().NextDouble()*10;
        }
    }
   
    return mas;
}

void PrintArray(double[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}

int rows = 3;
int columns = 4;
double[,] randmas = NewRandomMas(rows, columns);
PrintArray(randmas);


