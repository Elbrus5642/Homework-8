/*Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

//Метод ввода количества строк/столбцов/позиций элемента
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
//Метод инициализации массива
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
//Метод сортировки строк массива по убыванию элементов
void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//цикл по строкам
    {
        for (int j = 0; j < array.GetLength(1); j++) //цикл по столбцам

        {
            int maxPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++) //цикл внутри строки
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i,k];
                    array[i, k] = array[i, maxPosition];
                    array[i,maxPosition] = temp;
                }
            }

        }

    }
}

int mRow = GetNumber("Введите количество строк:");
int nCol = GetNumber("Введите количество столбцов:");
int[,] array2D = InitArray(mRow, nCol);
PrintArray(array2D);
SelectionSort(array2D);
PrintArray(array2D);

