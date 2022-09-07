// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите число строк массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int [m,n];

int minSumm = 0;
int Summ = mamimalArray(matr, 0);
for (int i = 1; i < matr.GetLength(0); i++)
{
  int tempSumm = mamimalArray(matr, i);
  if (Summ > tempSumm)
  {
    Summ = tempSumm;
    minSumm = i;
  }
}


int mamimalArray(int[,] matr, int i)
{
  int Summ = matr[i,0];
  for (int j = 1; j < matr.GetLength(1); j++)
  {
    Summ += matr[i,j];
  }
  return Summ;
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


FillRndArray(matr);
PrintArray(matr);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов -> {minSumm}");

