// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

Console.WriteLine("Введите число строк массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [m,n];

void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write($"{matr[i, j]} ");
        }
Console.WriteLine();
    }
}

void FillRndArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Random rand = new Random();
        matr[i, j] = rand.Next(1, 10);
        }
    }   
}

void SwapArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1;  k++)
      {
        if (array[i, k] > array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

FillRndArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SwapArray(matrix);
PrintArray(matrix);

