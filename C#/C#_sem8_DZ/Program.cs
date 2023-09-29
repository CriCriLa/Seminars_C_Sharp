// Задача 54. Задайте двухмерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

Console.Clear();

Console.Write("Введите количество строчек:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонок:");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows, columns];

void FillMatrix()
{
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
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

int[] GetRowAsaList(int numOfRow);
{
    int[] rowAsaList = new int[matrix.GetLength(1)];
    for (int i=0; i<matrix.GetLength(1); i++)
    {
        rowAsaList[i] = matrix[numOfRow,i];
    }
    return rowAsaList;
}

void SortArrayMaxMin(int[] array)
{
    int temp = 0;
    for (int j=0; j<array.Length-2; j++)
    {
        for (int i= 1; i<array.Length-j; i++) 
        {
            if (array[i]>array[i-1])
            {
                temp = array[i-1];
                array[i-1] = array[i];
                array[i] = temp;
            }
        }
    }
}

void PutRowInMatrix(int[] array, int[,] matrix, int numRow)
{
    for (int i=0; i<array.Length; i++)
    {
        matrix[numRow,i] = array[i];
    }
}

void ChangeMatrix()
{
    int[] tempRow = new int[matrix.GetLength(1)];
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        tempRow = GetRowAsaList (i);
        SortArrayMaxMin(tempRow);
        PutRowInMatrix(tempRow, matrix, i);
    }    
}

FillMatrix();
PrintMatrix(matrix);
Console.WriteLine ("_______________");
ChangeMatrix();
PrintMatrix(matrix);