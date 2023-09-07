// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввел пользователь.
// Console.Clear();

// int Prompt(string message) // метод запроса числа от пользователя
// {
//     Console.Write(message);
//     int num = Convert.ToInt32(Console.ReadLine()); 
//     return num;
// }
// int numM = Prompt("Сколько чисел вы хотите ввести? ");
// int result = 0;

// for (int i= 0; i<numM; i++)
// {
//     if (Prompt("Введите число: ")>0) result++;
// }
// Console.WriteLine($"Введено положительных чисел: {result}.");

// Задача 43. Напишите программу,которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1*x+b1, y = k2*x+b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// Для решения надо решаем систему уравнений и получаем, что точкой пересечения 
// будет точка с координатами: x= (b2-b1)/(k1-k2); y = k2*(b2-b1)/(k1-k2)+b2

Console.Clear();

double Prompt(string message) // метод запроса числа от пользователя
{
    Console.Write(message);
    double num = Convert.ToInt32(Console.ReadLine()); 
    return num;
}

double b1 = Prompt("Введите b1: ");
double k1 = Prompt("Введите k1: ");
double b2 = Prompt("Введите b2: ");
double k2 = Prompt("Введите k2: ");


// double x=(b1-b2)/(k1-k2);
// double y=(k2*(b1-b2))/(k1-k2)+b2;
// Console.WriteLine($"({x}; {y})");

 Console.WriteLine($"({(b2-b1)/(k1-k2)}; {k2*(b2-b1)/(k1-k2)+b2})");