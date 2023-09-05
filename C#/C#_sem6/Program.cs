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

Console.Clear();

Console.Write("Введите десятичное число:");
int num = Convert.ToInt32(Console.ReadLine());
string result ="";

while (num>0)
{
    result = num%2+result;
    num= num/2;
}

Console.WriteLine(result);



