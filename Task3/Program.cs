// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 11);
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
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int SumElementsOfMainDiagonal(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) sum = sum + matr[i, j];
        }
    }
    Console.WriteLine("Сумма элементов, находящихся на главной диагонали: " + (sum));
    return sum;
}

Random rand = new Random();
int m = rand.Next(2, 6);
int n = rand.Next(2, 6);
int[,] matrix = FillMatrix(m, n);

PrintMatrix(matrix);
SumElementsOfMainDiagonal(matrix);

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

// int MatrixEdit(int[,] matrix)
// {
//     int result = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if ((i == j))
//             {
//                 result += matrix[i, j];
//             }
//         }
//     }
//     return result;
// }


// System.Console.WriteLine("Введите rows и cols: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// int cols = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();
// int[,] array2d = FillMatrix(rows, cols);
// PrintMatrix(array2d);
// System.Console.WriteLine();
// System.Console.WriteLine(MatrixEdit(array2d));