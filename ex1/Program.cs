// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число : "); //ввод числа
int NumberResult = Convert.ToInt32(Console.ReadLine());
int result = ((NumberResult - (NumberResult % 10)) / 10) % 10;
Console.WriteLine($"{NumberResult} {result}");

