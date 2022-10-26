// В прямоугольной матрице найти строку с наименьшей суммой элементов
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

int FindMinInd(int[] array)
{
    int min = array[0];
    int minInd = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
            minInd = i;
        }
    }
    return minInd;
}

Console.WriteLine("Введите размер массива: ");

Console.Write("Количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];

FillMatrix(matrix, 1, 50);
PrintMatrix(matrix);

Console.WriteLine();

int[] array2 = new int[m];

for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i,j];
        }
        array2[i] = sumRow;
    }  
Console.WriteLine();  

int minIn = FindMinInd(array2);
Console.Write($"Номер строки с наименьшей суммой элементов: {minIn+1}");
