// Задача 3: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

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

bool CheckMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix2.GetLength(1) == matrix1.GetLength(0)) return true;
    return false;
}

int[,] Multiply(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(0); j++)
        {
            for (int q = 0; q < matrix2.GetLength(1); q++)
            {
                newMatrix[i, q] += matrix1[i, j] * matrix2[j, q];
            }
        }
    }
    return newMatrix;

}



int[,] firstMat = CreateMatrixMxN(3, 3);
PrintMatrix(firstMat);
Console.WriteLine();
int[,] secondMat = CreateMatrixMxN(3, 3);
PrintMatrix(secondMat);
Console.WriteLine();
bool check = CheckMatrix(firstMat, secondMat);

if (check == true)
{
    int[,] c = Multiply(firstMat, secondMat);
    PrintMatrix(c);
}
else Console.WriteLine("Такие матрицы нельзя умножить.");
