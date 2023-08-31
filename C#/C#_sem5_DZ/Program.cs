// Задача 34. Задайте массив заполненный случайными положительными 
// трехзначными числами. Напишите программу, которая покажет количество
// четных чисел в массиве.

// Console.Clear();
// int arrayLength = 10;
// int[]  array = new int[arrayLength];
// int sumPol = 0;

// for (int i= 0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     Console.Write(array[i] + " ");
//     if (array[i]%2==0)
//     {
//         sumPol++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine(sumPol + " положительных чисел");

// Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найти сумму элементов, стоящих на нечетных позициях.

// Console.Clear();
// int arrayLength = 5;
// int[]  array = new int[arrayLength];
// int sum = 0;

// for (int i= 0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(99);
//     Console.Write(array[i] + " ");
//     if (i%2==1)
//     {
//         sum = sum+array[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Сумма элементов: "+ sum);

// Задача 38. Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементом массива.

Console.Clear();
int arrayLength = 5;
double[]  array = new double[arrayLength];
double maxNum = 0;
double minNum = 0;

for (int i= 0; i<array.Length; i++)
{
    array[i] = new Random().NextDouble()*40;
    Console.Write(array[i] + " ");
    if (i==0)
    {
        maxNum=array[i];
        minNum = array[i];
    }
    else 
    {
        if (array[i]>maxNum) 
        {
            maxNum = array[i];
        }
        else if (array[i]<minNum)
        {
            minNum  = array[i];
        }
    }
}
Console.WriteLine();
Console.WriteLine("Разница между max и min: "+ (maxNum-minNum));