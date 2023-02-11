// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[m, n];
int[,] backnum = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        int Temp = new Random().Next(0, 10);
        num[i, j] = Temp;
        Console.Write($" {num[i, j]}");
    }
    Console.WriteLine();
}
Console.WriteLine();
int Max = num[0, 0];
for (int i = 0; i < num.GetLength(0); i++)
{
    int d = 0;
    for (int j = 0; j < num.GetLength(1); j++)
    {
        for (int k = d; k < num.GetLength(1); k++)
        {
            if (Max < num[i, k])
            {
                int t = Max;
                Max = num[i, k];
                num[i, k] = t;
            }
        }
        backnum[i, j] = Max;
        d++;
        Console.Write($" {backnum[i, j]}");
        Max = 0;
    }
    Console.WriteLine();
}
