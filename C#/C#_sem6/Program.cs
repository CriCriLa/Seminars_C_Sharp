// Задача 40. Принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины. 
// (Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон)

// Console.Write("Введите число:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число:");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if ((num1<num2+num3)&&(num2<num1+num3)&&(num3<num1+num2))
// {
//     Console.WriteLine("Существует.");
// }
// else
// {
//     Console.WriteLine("Такого треугольника не существует.");
// }

// Задача 42. Напишите программу, которая преобразует 
// десятичное число в двоичное.

// Console.Clear();

// Console.Write("Введите десятичное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// string result ="";

// while (num>0)
// {
//     result = num%2+result;
//     num= num/2;
// }

// Console.WriteLine(result);

// Задача 44. Не использую рекурсию, выведите первые 
// N чисел  Фибоначчи. Первые два числа 0 и 1.


// Console.Clear();

// Console.Write("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstNum = 0;
// int secondNum = 1;

// Console.Write(firstNum + " "+secondNum + " ");
// for (int i = 3; i<= num; i++)
// {
//     int newNum = firstNum+secondNum;
//     Console.Write(newNum+" ");
//     firstNum = secondNum;
//     secondNum = newNum;
// }

// Задача 39. Написать программу, которая переврнет одномерный массив
// (последний эл-т будет на первом месте, а первый на последнем и т.д.)

Console.Clear();

int[] array = new int[] {1,2,3,4,5};

for (int i = 0; i< array.Length/2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length-1-i];
    array[array.Length-1-i] = temp;
}

for (int i =0; i<array.Length; i++)
{
    Console.Write(array[i]+ " ");
}

