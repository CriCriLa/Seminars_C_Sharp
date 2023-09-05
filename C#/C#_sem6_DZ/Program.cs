// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввел пользователь.
Console.Clear();

Console.Write("Сколько чисел вы хотите ввести? ");
int numM = Convert.ToInt32(Console.ReadLine());
// int[] array= new int [numM];
int result = 0;

for (int i= 0; i<numM; i++)
{
    Console.Write("Введите число: ");
    // array[i]=Convert.ToInt32(Console.ReadLine());
    // if (array[i]>0) result++;
    if (Convert.ToInt32(Console.ReadLine())>0) result++;
}

Console.WriteLine($"Введено положительных чисел: {result}.");
