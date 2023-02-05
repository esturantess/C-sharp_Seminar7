// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(-10, 11);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] OddIndexElementsSquare(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if ((i % 2 != 0) && (j % 2 != 0))
            {
                matr[i, j] = (int)Math.Pow(matr[i, j], 2);
            }
        }
    }
    return matr;
}

Random rand = new Random();
int m = rand.Next(1, 10);
int n = rand.Next(1, 10);

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine();
OddIndexElementsSquare(matrix);
PrintMatrix(matrix);


// Решение с семинара:

// int[,] FillMatrix(int rows, int cols)
// {
//     int[,] matr = new int[rows, cols];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matr[i, j] = rand.Next(1, 10);
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write(matr[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void MatrixEdit(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if ((i % 2 != 0) && (j % 2 != 0))
//             {
//                 matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
//             }
//         }

//     }
// }

// int[,] matrix = FillMatrix(3, 3);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// MatrixEdit(matrix);
// PrintMatrix(matrix);