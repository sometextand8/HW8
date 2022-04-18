//Задача 1: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] CreateMatrixMxN(int row, int col)
{
    int[,] matrixFromUser = new int[row, col];

    for (int i = 0; i < matrixFromUser.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFromUser.GetLength(1); j++)
        {
            matrixFromUser[i, j] = new Random().Next(1, 10);
        }
    }
    return matrixFromUser;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SortRowInMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxVal = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, maxVal])
                {
                    maxVal = k;
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, maxVal];
                    matrix[i, maxVal] = temp;
                }
            }
        }
    }
    return matrix;
}


int[,] X = CreateMatrixMxN(5, 5);
PrintMatrix(X);
Console.WriteLine();
int[,] sorted = SortRowInMatrix(X);
PrintMatrix(sorted);

