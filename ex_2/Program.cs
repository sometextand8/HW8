//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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

void MinSum(int[,] matrix)
{
    int[] sumOfColumn = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumOfColumn[i] = sum;
    }
    int theLowSum = sumOfColumn[0];
    int ind = 0;

    for (int i = 1; i < sumOfColumn.Length; i++)
    {
        if (sumOfColumn[i] < theLowSum)
        {
            theLowSum = sumOfColumn[i];
            ind = i;
        }
    }
    Console.WriteLine($"Наименьший номер колонки - {ind + 1}");
    Console.WriteLine($"Сумма элементов - {theLowSum}");

}




int[,] X = CreateMatrixMxN(3, 4);

PrintMatrix(X);
Console.WriteLine();

MinSum(X);