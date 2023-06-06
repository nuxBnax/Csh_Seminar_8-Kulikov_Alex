// Задача 56: 

// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка

void Main()
{
    int row = ReadInt("Enter number of rows in genarating array: ");
    int column = ReadInt("Enter number of columns in genarating array: ");
    int[,] matrix = FillMatrix(row, column, 0, 10);
    PrintMatrix(matrix);
    System.Console.WriteLine();
    PrintMatr(MinRowSumArray(matrix, column));
    System.Console.WriteLine();
    System.Console.WriteLine("Number of ROW with minimum Sum of elements: " + (FindMinSum(MinRowSumArray(matrix, column)) + 1));
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] MinRowSumArray(int[,] array, int col)
{
    int[] arraySum = new int[col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arraySum[i] = arraySum[i] + array[i, j];
        }
    }
    return arraySum;
}

void PrintMatr(int[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.WriteLine((i + 1) + " row " + matrix[i]);
    }
}

int FindMinSum(int[] MatrSum)
{
    int min = 0;
    for (int i = 1; i < MatrSum.Length; i++)
    {
        if (MatrSum[i] < MatrSum[min]) min = i;
    }
    return min;
}

Main();
