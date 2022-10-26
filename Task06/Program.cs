// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

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

int[,] matrix = new int[m, n];

FillMatrix(matrix, 1, 20);
PrintMatrix(matrix);

Console.WriteLine();

int[] array = new int[n];

for(int j = 0; j < matrix.GetLength(1); j++)
    {
        int sumColumn = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            sumColumn += matrix[i,j];
        }
        array[j] = sumColumn;
    }  

Console.WriteLine(); 
Console.Write($"Среднее арифметическое по каждому столбцу: ");
Console.WriteLine();
for(int j = 0; j < n; j++) Console.Write($"{array[j] / m} ");
