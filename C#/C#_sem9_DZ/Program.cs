// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Clear();
// Console.Write("Введите число: "); 
// int num = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// string PrintNum (int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start+ " " + PrintNum(start-1, end));
// }

// Console.WriteLine(PrintNum(num, count));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
// Console.Write("Введите первое число: "); 
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: "); 
// int num2 = Convert.ToInt32(Console.ReadLine());

// int SumElement (int start, int end)
// {
//     if (start == end)
//     {
//         return start;
//     }
//     return (start+ SumElement(start+1, end));
// }

// if (num1<num2)
// {
//     Console.WriteLine(SumElement(num1, num2));
// }
// else 
// {
//     Console.WriteLine(SumElement(num2, num1));
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите первое число: "); 
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: "); 
int num2 = Convert.ToInt32(Console.ReadLine());

int Akkerman (int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    if (n==0)
    {
        return Akkerman (m-1,1);
    }
    return Akkerman(m-1, Akkerman (m,n-1));
}

Console.WriteLine(Akkerman(num1, num2));