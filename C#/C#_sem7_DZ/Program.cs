// Задача 47. Задать двумерный массив размером m*n, 
// заполненный случайными вещественными числами.

Console.Clear();

int Prompt(string message) // метод запроса числа от пользователя
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine()); 
    return num;
}
int rows = Prompt("Введите количество рядов: ");
int columns = Prompt("Введите количество столбцов: ");

double[,] matrix = new double[rows, columns];

for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j = 0; j<matrix.GetLength(1); j++) 
    {
        matrix[i,j] = Math.Round(new Random().NextDouble()*10, 2);
        Console.Write($"{matrix[i,j]}  ");
    }
    Console.WriteLine();
}