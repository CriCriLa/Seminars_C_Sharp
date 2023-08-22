// Задача 25. Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.
// Console.Clear();

// Console.Write("Введите число А:");
// int numA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число В:");
// int numB = Convert.ToInt32(Console.ReadLine());

// int MakeExponent(int num1, int num2)
// {
//     int result = numA;
//     for (int i=1; i<num2; i++)
//     {
//         result = result * numA;
//     }
//     return result;
// }

// Console.WriteLine(MakeExponent(numA, numB));


// Задача 27. Напишите программу, которая принимает на вход число 
// и выдает сумму цифр в числе.

// Console.Clear();

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumNumbers()
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result = result + num%10;
//         num = num/10;
//     }
//     return result;
// }

// Console.WriteLine(SumNumbers());

// Задача 29. Напишите программу, которая задает массив из 
// 8 элементов и выводит их на экран.
Console.Clear();

int lengthMas = 8;
int[] array = new int[lengthMas];

void FillArray()
{
    for (int i=0; i<lengthMas; i++)
    {
        array[i] = new Random().Next(0,50);
    }
}

void PrintArray()
{}


int[] array = 

int SumNumbers()
{
    int result = 0;
    while (num > 0)
    {
        result = result + num%10;
        num = num/10;
    }
    return result;
}

Console.WriteLine(SumNumbers());