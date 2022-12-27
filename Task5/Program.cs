string task5 = "Напишите программу"
+ " которая заполнит спирально массив 4 на 4"
+ " Например, на выходе получается вот такой массив:"
+ " 01 02 03 04"
+ " 12 13 14 05"
+ " 11 16 15 06"
+ " 10 09 08 07";
Console.WriteLine(task5);
Console.WriteLine();
// Программа
int[,] array = {
                     {0,0,0,0},
                     {0,0,0,0},
                     {0,0,0,0},
                     {0,0,0,0},
                    };
void PrintSnakeFillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((i == 0 && j == 0) || (i == 0 && j == 1) || (i == 0 && j == 2) || (i == 0 && j == 3) || (i == 01 && j == 3) || (i == 2 && j == 3) || (i == 3 && j == 3) || (i == 3 && j == 2) || (i == 3 && j == 1))
            {
                Console.Write($"0{matrix[i, j]} ");
            }
            else
            {
                Console.Write($"{matrix[i, j]} ");
            }
        }

        Console.WriteLine();
    }
}
void PrintArray(int[,] matr2D)
{
    for (int i = 0; i < matr2D.GetLength(0); i++)
    {
        for (int j = 0; j < matr2D.GetLength(1); j++)
        {
            Console.Write($"{matr2D[i, j]} ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}
//Вывод нулевой матрицы 
Console.WriteLine($"Вначале матрица {array.GetLength(0)} x {array.GetLength(1)} заполнена нулями:");
PrintArray(array);
Console.WriteLine();
int[,] GetSnakeFillArray(int m,int n)
{
    int rowStart = 0;
    int rowFinish = 0;
    int colStart = 0;
    int colFinish = 0;

    int stepCount = 1;
    int rowCount = 0;
    int colCount = 0;
    int [,] array =  new int[m,n];
    while (stepCount <= m * n)
    {
        array[rowCount, colCount] = stepCount;
        if (rowCount == rowStart && colCount < n - colFinish - 1)
            ++colCount;
        else if (colCount == n - colFinish - 1 && rowCount < m - rowFinish - 1)
            ++rowCount;
        else if (rowCount == m - rowFinish - 1 && colCount > colStart)
            --colCount;
        else
            --rowCount;

        if ((rowCount == rowStart + 1) && (colCount == colStart) && (colStart != n - colFinish - 1))
        {
            rowStart++;
            rowFinish++;
            colStart++;
            colFinish++;
        }
        stepCount++;
    }
    return array;
}
int[,] matrix2Dsnake = GetSnakeFillArray(array.GetLength(0), array.GetLength(1));
Console.WriteLine($"Матрица {matrix2Dsnake.GetLength(0)} x {matrix2Dsnake.GetLength(1)} заполнена змейкой:");
Console.WriteLine();
PrintSnakeFillArray(matrix2Dsnake);


