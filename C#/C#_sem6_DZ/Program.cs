// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввел пользователь.
// Console.Clear();

// Console.Write("Сколько чисел вы хотите ввести? ");
// int numM = Convert.ToInt32(Console.ReadLine());
// // int[] array= new int [numM];
// int result = 0;

// for (int i= 0; i<numM; i++)
// {
//     Console.Write("Введите число: ");
//     // array[i]=Convert.ToInt32(Console.ReadLine());
//     // if (array[i]>0) result++;
//     if (Convert.ToInt32(Console.ReadLine())>0) result++;
// }

// Console.WriteLine($"Введено положительных чисел: {result}.");

// Задача 43. Напишите программу,которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1*x+b1, y = k2*x+b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// Для решения надо решаем систему уравнений и получаем, что точкой пересечения 
// будет точка с координатами: x= (b1-b2)/(k1-k2); y = k2*(b1-b2)/(k1-k2)+b2

Console.Clear();

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x=(b1-b2)/(k1-k2);
double y=(k2*(b1-b2))/(k1-k2)+b2;

// Console.WriteLine($"({(b1-b2)/(k1-k2)}; {k2*(b1-b2)/(k1-k2)+b2})");
Console.WriteLine($"({x}; {y})");