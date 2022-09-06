// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.







Console.WriteLine("Введите размерность первой матрицы:");
Console.WriteLine("Введите число строк m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int [m,n];

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

Console.WriteLine("Введите размерность второй матрицы:");
Console.WriteLine("Введите число строк р:");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов с:");
int c = Convert.ToInt32(Console.ReadLine());
int[,] Twomatr = new int [p,c];

void SecondPrintArray (int[,] Twomatr)
{
    for (int i = 0; i < Twomatr.GetLength(0); i++)
    {
        for (int j = 0; j < Twomatr.GetLength(1); j++)
        {
        Console.Write($"{Twomatr[i, j]} ");
        }
Console.WriteLine();
    }
}

void SecondFillRndArray(int[,] Twomatr)
{
    for (int i = 0; i < Twomatr.GetLength(0); i++)
    {
        for (int j = 0; j < Twomatr.GetLength(1); j++)
        {
        Random rand = new Random();
        Twomatr[i, j] = rand.Next(1, 10);
        }
    }   
}


int[,] ResultMatrix(int[,] matr, int[,] Twomatr)
{
        {
            
            int[,] result = new int[matr.GetLength(0), Twomatr.GetLength(1)];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < Twomatr.GetLength(1); j++)
                {
                    for (int k = 0; k < Twomatr.GetLength(0); k++)
                    {
                        result[i,j] += matr[i,k] * Twomatr[k,j];
                    }
                }
            }
            return result;
        }
}
void PrintResultMatrix (int[,] result)
{
    for (int i = 0; i < ResultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ResultMatrix.GetLength(1); j++)
        {
        Console.Write($"{ResultMatrix[i, j]} ");
        }
Console.WriteLine();
    }
}
FillRndArray(matr);
PrintArray(matr);
Console.WriteLine();
SecondPrintArray(Twomatr);
SecondFillRndArray(Twomatr);
Console.WriteLine();
ResultMatrix(matr, Twomatr);
PrintResultMatrix (ResultMatrix);
