// Задача 31. Задайте массив , заполненный случайными числами 
// их промежутка [-9,9]. Найти сумму отрицательных и положителных 
// элементов массива. НАпример в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();
int arrayLength = 12;
int[] array = new int[arrayLength];
int positiveNumber = 0;
int negNumber = 0;

for (int i=0; i< array.Length; i++)
{
    array[i] = new Random().Next(-9,10);

    if (array[i]>0)
    {
        // positiveNumber = positiveNumber + array[i];
        positiveNumber += array[i];
    }
    else
    {
        negNumber+=array[i];
    }

    Console.Write (array[i]+ " ");
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных: {positiveNumber} и отрицательных: {negNumber};");