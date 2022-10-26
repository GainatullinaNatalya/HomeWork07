// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillMatrix(int[,] matr, int min, int max)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();    
    }
}

Console.WriteLine("Введите размер массива: ");

Console.Write("Количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Изначальный массив: ");

int[,] matrix = new int[m, n];

FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);

Console.WriteLine();
Console.WriteLine("Новый массив: ");

for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0) matrix[i,j] = matrix[i,j] * matrix[i,j];
            Console.Write($"{matrix[i,j]} ");

        }
        Console.WriteLine();
    }
