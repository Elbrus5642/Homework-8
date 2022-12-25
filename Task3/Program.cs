/* Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
// Получить значения для числа строк/столбцов матрицы
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
    }
    return result;
}
// Метод инициализации матрицы
int[,] InitArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
    return arr;
}
// Вывести матрицу на экран
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}
//Метод скалярного произведения матриц

int[,] GetScalarMultiArray(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixAB = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            for (int r = 0; r < matrixB.GetLength(1); r++)
            {
                matrixAB[i, j] += matrixA[i, r] * matrixB[r, j];
            }
        }
    }
    return matrixAB;
}
    
    // Скалярное произведение двух матриц
    int numRows = GetNumber("Введите количество строк массива:");
    int numColumns = GetNumber("Введите количество столбцов массива:");
    int[,] arrayA = InitArray(numRows,numColumns);
    int[,] arrayB = InitArray(numRows, numColumns);
    Console.WriteLine("Массив А:");
    PrintArray(arrayA);
    Console.WriteLine("Массив В:");
    PrintArray(arrayB);
    Console.WriteLine("Скалярное произведение массива А на массив В - массив С:");
    int[,] arrayC = GetScalarMultiArray(arrayA,arrayB);
    PrintArray (arrayC);