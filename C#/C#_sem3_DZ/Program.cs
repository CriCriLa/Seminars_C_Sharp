// Задача 19. Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно полиндромом.

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num>=100000)||(num<10000))
    Console.WriteLine("Это не пятизначное число.");

// int num1 = num/10000;
// int num2 = (num/1000)%10
// int num4 = (num%100)/10
// int num5 = num%10;

if ((num/10000 == num%10)&&((num/1000)%10==(num%100)/10))
{
    Console.WriteLine("Это полиндром.");
}
else 
    Console.WriteLine("Это не полиндром.");


