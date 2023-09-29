// Задача 63. Задайте значение N. Программа должна вывести 
// все натуральные числа в промежутке от 1 до N

// Console.Clear();   
// Console.Write("Введите число: "); 
// int num = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// string PrintNumber (int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start+ " " + PrintNumber(start+1, end));
// }

// Console.WriteLine(PrintNumber(count, num));


// Задача 65. Задать числа M и N. Вывести все натуральные числа от M до N.

// Console.Clear();   
// Console.Write("Введите первое число: "); 
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: "); 
// int num2 = Convert.ToInt32(Console.ReadLine());

// string PrintNumber (int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start+ " " + PrintNumber(start+1, end));
// }

// Console.WriteLine(PrintNumber(num1, num2));

// Задача 67. Написать программу которая считает сумму цифр
//  в заданном пользователе числе.

// Console.Clear();   
// Console.Write("Введите число: "); 
// int num1 = Convert.ToInt32(Console.ReadLine());


// int SumNumber (int start)
// {
//     if (start<0)
//     {
//         start = start*-1;
//     }
//     if (start <= 0)
//     {
//         return 0;
//     }
//     return (start%10 + SumNumber(start/10));
// }

// Console.WriteLine(SumNumber(num1));

// Задача 69. Принимает два числа A и В  и возводит 
// число А в целую степень числа В с помощью рекурсии.


Console.Clear();   
Console.Write("Введите первое число: "); 
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: "); 
int num2 = Convert.ToInt32(Console.ReadLine());

int GetPow (int start, int rank)
{
    if (rank== 0)
    {
        return 1;
    }
    if (rank ==1)
    {
        return start;
    }
    if (start <= 0)
    {
        return 0;
    }
    return (start * GetPow(start, rank-1));
}

Console.WriteLine(GetPow(num1, num2));