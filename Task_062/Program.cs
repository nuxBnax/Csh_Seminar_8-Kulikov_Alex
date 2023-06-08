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
    // PrintMatrix(matrix);
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
    int remainder = row * column % 2;

    if (remainder % 2 != 0) remainder = 1;
    int circle = row * column / 4 + remainder;
    

    for (int k = 0; k < circle; k++)
    {
        int i = k;
        int j = k;
        while (j <= column - (1 + k))
        { arr[i, j] = N + 1; N++; j++; }

        i = (1 + k);
        j = column - (1 + k);
        while (i <= row - (1 + k))
        { arr[i, j] = N + 1; N++; i++; }

        i = row - (1 + k);
        j = column - (2 + k);
        while (j >= k)
        { arr[i, j] = N + 1; N++; j--; }

        i = row - (2 + k);
        j = k;
        while (i >= (1 + k))
        { arr[i, j] = N + 1; N++; i--; }
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