/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7*/
//Программа считает сумму элементов в каждой строке и выдаёт 
//номер строки с наименьшей суммой элементов: 1 строка
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
//Метод печати массива 
void PrintArray2D(int[,] matr2D)

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
void PrintArray1D(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Сумма элементов строки {i} = {arr[i]}, ");
    }
}
int[] GetRowSun(int[,] matr2D)
{
    int[] array = new int[matr2D.GetLength(0)];

    for (int i = 0; i < matr2D.GetLength(0); i++)
    {
        int k = i;
        int rowSum = 0;
        for (int j = 0; j < matr2D.GetLength(1); j++)
        {
            rowSum = rowSum + matr2D[i, j];
        }
        array[k] = rowSum;
    }

    return array;
}
(int,int) GetIndexRowSum(int[] arr)
{
    int minValue = arr[0];
    int indexMinValue = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minValue)
        {
            minValue = arr[i];
            indexMinValue = i;
        }
    }
    return(minValue, indexMinValue);
}
int rowNum = GetNumber("Введите число строк:");
int colNum = GetNumber("Введите число столбцов:");
int[,] matrix2D = InitArray(rowNum, colNum);
Console.WriteLine("Массив для дальнейшей работы:");
PrintArray2D(matrix2D);
int[] array1D = GetRowSun(matrix2D);
PrintArray1D(array1D);
(int value, int indexMinSumRow) = GetIndexRowSum(array1D);
Console.WriteLine($"Наименьшая сумма элементов {value}: {indexMinSumRow + 1} строка");