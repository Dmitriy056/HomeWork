// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
//из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int NUM1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int NUM2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int NUM3 = int.Parse(Console.ReadLine());
int max = NUM1;
if (max < NUM2) max = NUM2;
if (max < NUM3) max = NUM3;
Console.WriteLine($"Максимальное число их этих чисел равно: {max}");
Console.ReadLine();