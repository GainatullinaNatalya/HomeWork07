// Показать двумерный массив размером m×n заполненный вещественными числами

void FillMatrix(double [,] matr)
{
    Random arr = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = arr.NextDouble();
        }
    }
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matr[i, j], 3)} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер массива mxn: ");

Console.Write("m = ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("n = ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] matrix = new double[m, n];

FillMatrix(matrix);

PrintMatrix(matrix);