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

// Задача 26. Принимает на вход число и выдает количество цифр в числе. 

// Console.Clear();

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int GetCountNumber()
// {
//    int count = 0;
   
//      while (number>0)
//      {
//          number = number/10;
//          count++;
//      }
//      return  count;
//  }

//  Console.WriteLine(GetCountNumber());

// Задача 28. Принимает число N и выдает произведение чисел от 1 до N.

// Console.Clear();

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int GetNumber()
//  {
//     int result = 1;
   
//       for (int i = 1; i<=number; i++)
//       {
//           result  = result *i;
//       }
//       return  result;
//   }

// Console.WriteLine(GetNumber());

// Задача 30. Выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

Console.Clear();
int arrayLength = 8;
int[] array = new int[arrayLength];

void GetRandomArray()
{ 
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = new Random().Next(0,2);
        Console.Write(array[i]+" ");
      }     
}
GetRandomArray();
Console.WriteLine();