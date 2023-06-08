// Задача 58:

// Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Main()
{
    int row = ReadInt("Enter number of rows in genarating arrays: ");
    int column = ReadInt("Enter number of columns in genarating arrays: ");
    int[,] matrix = FillMatrix(row, column, 0, 10);
    // int rowTwo = ReadInt("Enter number of rows in second genarating array: ");
    // int columnTwo = ReadInt("Enter number of columns in second genarating array: ");
    int[,] matrixTwo = FillMatrix(row, column, 0, 10);
    PrintMatrix(matrix);
    System.Console.WriteLine();
    PrintMatrix(matrixTwo);
    System.Console.WriteLine();
    PrintMatrix(MatrixMult(matrix, matrixTwo, row, column));

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

int[,] MatrixMult(int[,] array, int[,] arrayTwo, int row, int column)
{
    int[,] arraySum = new int[row, column];

    for (int i = 0; i < arraySum.GetLength(0); i++)
    {
        for (int j = 0; j < arraySum.GetLength(1); j++)
        {
            if (i == 0 && j == 0) arraySum[0, 0] = array[0, 0] * arrayTwo[0, 0] + array[0, 1] * arrayTwo[1, 0];
            if (i == 0 && j == 1) arraySum[0, 1] = array[0, 0] * arrayTwo[0, 1] + array[0, 1] * arrayTwo[1, 1];
            if (i == 1 && j == 0) arraySum[1, 0] = array[1, 0] * arrayTwo[0, 0] + array[1, 1] * arrayTwo[1, 0];
            if (i == 1 && j == 1) arraySum[1, 1] = array[1, 0] * arrayTwo[0, 1] + array[1, 1] * arrayTwo[1, 1];
        }

    }
    return arraySum;
}


Main();
