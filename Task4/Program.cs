/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, 
 добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
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
// Метод инициализации матрицы заполненной неповторяющимися двузначными числами
int[,,] InitAndSelectArray(int m, int n, int l)
{
    int[,,] arr = new int[m, n, l];
    Dictionary<int, int> dictbook = new Dictionary<int, int>();
    Random rnd = new Random();
    int newnumber = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                newnumber = rnd.Next(1, 99);
                if (dictbook.ContainsKey(newnumber))
                {
                    continue;
                }
                else
                {
                    dictbook.Add(newnumber, 1);
                    arr[i, j, k] = newnumber;
                }
            }
        }
    }
    return arr;
}
// Вывести матрицу на экран
void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)

        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
                Console.Write("");
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
}

int numXdirect = GetNumber("Введите размер X трёхмерного массива:");
int numYdirect = GetNumber("Введите размер Y  трёхмерного массива:");
int numZdirect = GetNumber("Введите размер Z трёхмерного массива:");
Console.WriteLine($"Получен  массив {numXdirect} x {numYdirect} x {numZdirect}:");

int[,,] array3D = InitAndSelectArray(numXdirect, numYdirect, numZdirect);
PrintArray(array3D);