// Задача 24. Напишите программу, которая принимает на вход число А 
// и выдает сумму чисел от 1 до А.

// Console.Clear();

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int GetSumNumber()
// {
//     int sum = 0;
   
//     for (int count=1; number >= count; count++)
//     {
//         sum = sum + count;
//     }
//     return  sum;
// }

// int result = GetSumNumber();
// Console.WriteLine(result);

// Задача 26. Принимает на вход число и выдает количестко цифр в числе. 

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetCountNumber()
{
   int count = 0;
   
     while (number>0)
     {
         number = number/10;
         count++;
     }
     return  count;
 }

 Console.WriteLine(GetCountNumber());