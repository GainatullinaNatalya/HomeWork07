// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.WriteLine("Введите размер массива: ");

Console.Write("Количество строк: ");
int row = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Количество столбцов: ");
int column = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[row, column];


    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();    
    }

