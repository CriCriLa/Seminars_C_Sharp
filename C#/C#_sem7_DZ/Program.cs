// Задача 47. Задать двумерный массив размером m*n, 
// заполненный случайными вещественными числами.

// Console.Clear();

// int Prompt(string message) // метод запроса числа от пользователя
// {
//     Console.Write(message);
//     int num = Convert.ToInt32(Console.ReadLine()); 
//     return num;
// }
// int rows = Prompt("Введите количество рядов: ");
// int columns = Prompt("Введите количество столбцов: ");

// double[,] matrix = new double[rows, columns];

// for (int i=0; i<matrix.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix.GetLength(1); j++) 
//     {
//         matrix[i,j] = Math.Round(new Random().NextDouble()*10, 2);
//         Console.Write($"{matrix[i,j]}  ");
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

Console.Clear();

int [,] matrix = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

int Prompt(string message) // метод запроса числа от пользователя
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine()); 
    return num;
}
int row = Prompt("Укажите ряд: ");
int column = Prompt("Укажите колонку: ");

if ((row >= matrix.GetLength(0)) || (column >= matrix.GetLength(1)))
{
    Console.WriteLine("Такого числа в массиве нет.");
}
else 
{
    Console.WriteLine($"Запрашиваемый элемент: {matrix[row, column]}");
}