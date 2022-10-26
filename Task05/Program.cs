// В матрице чисел найти сумму элементов главной диагонали

void FillMatrix(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int SumElemDiag(int[,] matr)
{
    int sumD = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) sumD += matr[i, j];
        }
    }
    return sumD;
}

Console.WriteLine("Введите размер массива: ");

int m = int.Parse(Console.ReadLine() ?? "0");

int n = m;

int[,] matrix = new int[m, n];

Console.WriteLine();

FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);

Console.WriteLine();

int sumDiag = SumElemDiag(matrix);
Console.WriteLine($"Сумма элементов главной диагонали {sumDiag}");
    