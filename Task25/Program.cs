// Задание 25.
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= num2; i++)
{
    result *= num1;
 }
 Console.Write($"{num1} в степени {num2} равно {result}", num1, num2, result);