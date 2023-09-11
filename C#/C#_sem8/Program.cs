// Задача 53. Задать двумерный массив. Написать программу, которая
// поменяет местами  первую и последнюю строчку нашего массива.

// Console.Clear();

// Console.Write("Введите количество рядов:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество колонок:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [rows, columns];

// void FillMatrix()
// {
//     for (int i = 0; i<matrix.GetLength(0); i++)
//     {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void PrintMatrix()
// {
//     for (int i = 0; i<matrix.GetLength(0); i++)
//     {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]}   ");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeMatrix()
// {
//     int temp = 0;
//     int indexLastRow = matrix.GetLength(0)-1;
  
//     for (int i = 0; i<matrix.GetLength(1); i++)
//     {
//         temp = matrix[0,i];
//         matrix[0,i] = matrix[indexLastRow,i];
//         matrix[indexLastRow,i] = temp;
//     }

// }

// FillMatrix();
// PrintMatrix();
// ChangeMatrix();
// Console.WriteLine ("_______________");
// PrintMatrix();

// Задача 55. Задать массив. Заменить строки на столбцы и 
// вывести сообщение если это невозможно.

// Console.Clear();

// Console.Write("Введите количество рядов:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество колонок:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [rows, columns];
// int [,] newMatrix = new int [rows, columns];

// void FillMatrix()
// {
//     for (int i = 0; i<matrix.GetLength(0); i++)
//     {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}   ");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeMatrix()
// {
//     if (rows==columns)
//     {
//         for (int i = 0; i<matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j<matrix.GetLength(1); j++)
//             {
//                 newMatrix[j,i] = matrix[i,j];
//             }
//         }
//     }
// }

// FillMatrix();
// PrintMatrix(matrix);
// ChangeMatrix();
// Console.WriteLine ("_______________");
// if (rows==columns)
// {
//     PrintMatrix(newMatrix);
// }
// else Console.WriteLine("Поменять массив невозможно.");

// Задача 59. Задать двумерный массив из целых чисел. Написать программу, 
// котрая удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива.

Console.Clear();

Console.Write("Введите количество строчек:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонок:");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows, columns];
int minValue = int.MaxValue;
int minIndexRows = 0;
int minIndexColumns = 0;

void FillMatrix()
{
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
            if (minValue>matrix[i,j])
            {
                minValue = matrix[i,j];
                minIndexRows = i;
                minIndexColumns = j;
            }
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }
}

void ChangeMatrix()
{
    for (int i = 0; i<matrix.GetLength(0); i++)
        {
            if (i!=minIndexRows)
            {
                for (int j = 0; j<matrix.GetLength(1); j++)
            {
                if (j!=minIndexColumns)
                {
                     Console.Write($"{matrix[i,j]}   ");
                }
            }
            }
            Console.WriteLine();
        }
}

FillMatrix();
PrintMatrix(matrix);
Console.WriteLine ("_______________");
ChangeMatrix();