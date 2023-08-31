// Задача 34. Задайте массив заполненный случайными положительными 
// трехзначными числами. Напишите программу, которая покажет количество
// четных чисел в массиве.

Console.Clear();
int arrayLength = 10;
int[]  array = new int[arrayLength];
int sumPol = 0;

for (int i= 0; i<array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i] + " ");
    if (array[i]%2==0)
    {
        sumPol++;
    }
}
Console.WriteLine();
Console.WriteLine(sumPol + " положительных чисел");
