// 02.11.2022
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число "); 
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень "); 
// int b = Convert.ToInt32(Console.ReadLine());

// void  Exponentiation(Int32 x, Int32 y)
// {
//     Int32 result = Convert.ToInt32(Math.Pow(x, y));
//     Console.WriteLine(result);
// }
// Exponentiation(a, b);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число "); 
// int a = Convert.ToInt32(Console.ReadLine());

// void SummOfNumbers(int x)
// {
//     int sum = 0;
//     while (x != 0)
//     {
//         sum = sum + (x % 10);
//         x = x / 10;

//     }
//     Console.WriteLine($"Сумма цифр в числе: {sum}");
// }

// SummOfNumbers(a);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит 
// массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillingArray()
{
int [] array = new int [8];

for (int i=0; i<8; i++) 
{
    Console.WriteLine("Введите число "); 
    int a = Convert.ToInt32(Console.ReadLine());
    array[i] = a;
}
for (int j=0; j<8; j++)
{
    Console.Write($"{array[j]} ");
}
}

FillingArray();