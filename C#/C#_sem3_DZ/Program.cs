// Задача 19. Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно полиндромом.

// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num>=100000)||(num<10000))
//     Console.WriteLine("Это не пятизначное число.");

// // int num1 = num/10000;
// // int num2 = (num/1000)%10
// // int num4 = (num%100)/10
// // int num5 = num%10;

// if ((num/10000 == num%10)&&((num/1000)%10==(num%100)/10))
// {
//     Console.WriteLine("Это полиндром.");
// }
// else 
//     Console.WriteLine("Это не полиндром.");

// Задача 21. Напишите програму, которая принимает на вход 
// координаты двух точек и находит расстояние между ними 
// в трехмерном пространстве.

Console.Clear();
Console.WriteLine("Введите координаты первой точки: ");
int X1 = Convert.ToInt32(Console.ReadLine());
int Y1 = Convert.ToInt32(Console.ReadLine());
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
int X2 = Convert.ToInt32(Console.ReadLine());
int Y2 = Convert.ToInt32(Console.ReadLine());
int Z2 = Convert.ToInt32(Console.ReadLine());

double Result = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
Result = Math.Round(Result,2);
Console.WriteLine(Result);