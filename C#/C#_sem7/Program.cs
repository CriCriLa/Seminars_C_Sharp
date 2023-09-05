// Задача 46. Задать двумерный массив размером m*n, 
// заполненный случайными целыми числами.

// Console.Clear();

// Console.Write ("Введите первое число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write ("Введите второе число: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix=new int[rows,columns];

// for (int i= 0; i<matrix.GetLength(0); i++)
// {
//     for (int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         Console.Write (matrix [i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// Задача 48. Задать двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.


Console.Clear();

Console.Write ("Введите первое число: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix=new int[rows,columns];

for (int i= 0; i<matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j] = i+j;
        Console.Write (matrix [i,j]+ " ");
    }
    Console.WriteLine();
}