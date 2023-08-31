// Задача 31. Задайте массив , заполненный случайными числами 
// их промежутка [-9,9]. Найти сумму отрицательных и положителных 
// элементов массива. НАпример в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Console.Clear();
// int arrayLength = 12;
// int[] array = new int[arrayLength];
// int positiveNumber = 0;
// int negNumber = 0;

// for (int i=0; i< array.Length; i++)
// {
//     array[i] = new Random().Next(-9,10);

//     if (array[i]>0)
//     {
//         // positiveNumber = positiveNumber + array[i];
//         positiveNumber += array[i];
//     }
//     else
//     {
//         negNumber+=array[i];
//     }

//     Console.Write (array[i]+ " ");
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма положительных: {positiveNumber} и отрицательных: {negNumber};");

// Задача 32. Заменить элементы массива: положительные 
// на соответствующие отрицательные и наоборот.

// Console.Clear();
// int arrayLength = 10;
// int[] array = new int[arrayLength];

// for (int i=0; i< array.Length; i++)
// {
//     array[i] = new Random().Next(-9,10);
//     Console.Write (array[i]+ " ");
// }
// Console.WriteLine();

// for (int i=0; i< array.Length; i++)
// {
//     array[i] = array[i] * -1;
//     Console.Write (array[i]+ " ");
// }
// Console.WriteLine();

// Задача  33. Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.

// Console.Clear();
// int arrayLength = 10;
// int[] array = new int[arrayLength];

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool isFind=false;

// for (int i=0; i< array.Length; i++)
// {
//     array[i] = new Random().Next(-9,10);
//     Console.Write (array[i]+ " ");

//     if (num==array[i])
//     {
//         isFind = true;
//     }
// }
// Console.WriteLine();
// if (isFind==true)
// { 
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача 35. Задать одномерный массиы из 123 случайных чисел. 
// Найти количество элементов массива, значения которых лежат в отрезке [10,99]

// Console.Clear();
// int arrayLength = 123;
// int[] array = new int[arrayLength];

// int result=0;

// for (int i=0; i< array.Length; i++)
// {
//     array[i] = new Random().Next(123);
//     Console.Write (array[i]+ " "); 
//     if ((array[i]>9)&&(array[i]<100))
//     {
//         result+=1;
//     }
// }
// Console.WriteLine("Кол-во = " + result);
 
//  Задача 37. Найти произведение пар числе в массиве. 
//  Парой считаются первое и последнее, второе и предпоследнее 
//  число и т.д. Результат вывести в новом массиве.

Console.Clear();
int arrayLength = 7;
int[] array = new int[arrayLength];
int[] array2 = new int[array.Length/2+array.Length%2];

for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = 0; i<array2.Length; i++)
{
    array2[i] = array[i]*array[array.Length-1-i];
    if (i==arrayLength-1-i)
    {
    
        array2[i] = array[i];
    
    }
    Console.Write(array2[i] + " ");
}
Console.WriteLine();