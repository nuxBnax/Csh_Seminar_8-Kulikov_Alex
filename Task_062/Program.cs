// Задача 62:

// Напишите программу, которая заполнит спирально
// массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Main()
{
    int row = ReadInt("Enter number of rows in genarating array: ");
    int column = ReadInt("Enter number of columns in genarating array: ");
    int[,] matrix = FillMatrix(row, column, 0, 10);
    PrintMatrix(matrix);

}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange)
{
    int[,] matrix = new int[row, col];
    int number = leftRange;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] += number;
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


void PrintAverageMatrix(double[] matrix)
{
    System.Console.WriteLine("Average of each column: " + string.Join("; ", matrix));
}

Main();