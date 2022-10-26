// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

int CountNumber(int[,] matr, int number)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == number) count++;
        }
    }
    return count;
}

Console.WriteLine("Введите размер массива: ");

Console.Write("Количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];

FillMatrix(matrix, 1, 30);
PrintMatrix(matrix);

Console.WriteLine();

Console.Write("Введите искомое число: ");
int numb = int.Parse(Console.ReadLine() ?? "0");

int count = CountNumber(matrix, numb);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == numb)
            Console.WriteLine($"Позиция искомого числа: строка {i+1}, столбец {j+1} ");
    }
}    
if (count < 1) Console.WriteLine($"Числа {numb} нет в массиве");
