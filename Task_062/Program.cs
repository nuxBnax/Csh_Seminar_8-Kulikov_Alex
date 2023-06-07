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
    int[,] matrix = FillMatrix(row, column, 0);
    PrintMatrix(matrix);
    System.Console.WriteLine();
    PrintMatrix(ArrayNumbering(matrix, row, column, 0));

}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int n)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = n;
        }
    }

    return matrix;
}

int[,] ArrayNumbering(int[,] arr, int row, int column, int N)
{
    int i = 0;
    int j = 0;
    while (j <= column - 1)
    {
        arr[i, j] = N + 1; N++; j++;
    }

    i = 1;
    j = column - 1;
    while (i <= row - 1)
    {
        arr[i, j] = N + 1; N++; i++;
    }

    i = row - 1;
    j = column - 2;
    while (j >= 0)
    {
        arr[i, j] = N + 1; N++; j--;
    }

    i = row - 2;
    j = 0;
    while (i >= 1)
    {
        arr[i, j] = N + 1; N++; i--;
    }

    i = 1;
    j = 1;
    while (j <= column - 2)
    {
        arr[i, j] = N + 1; N++; j++;
    }

    i = 2;
    j = column - 2;
    while (i <= row - 2)
    {
        arr[i, j] = N + 1; N++; i++;
    }

    i = row - 2;
    j = column - 3;
    while (j >= 1)
    {
        arr[i, j] = N + 1; N++; j--;
    }

    return arr;
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

Main();