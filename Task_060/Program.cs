// Задача 60:

// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет
// построчно выводить массив, добавляя индексы каждого
// элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)

// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void Main()
{
    int row = ReadInt("Enter number of rows in genarating array: ");
    int column = ReadInt("Enter number of columns in genarating array: ");
    int depth = ReadInt("Enter number of depths in genarating array: ");
    int[,,] matrix = FillMatrix(row, column, depth, 0, 10);
    PrintMatrix(matrix);

}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] FillMatrix(int row, int col, int dep, int leftRange, int rightRange)
{
    int[,,] matrix = new int[row, col, dep];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rand.Next(leftRange, rightRange + 1);
            }
        }

    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(string.Join(" ", matrix[i, j, k] + "(" + i + "," + j + "," + k + ")") + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    
}

Main();
