// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
string NumberAtxt = Convert.ToString(NumberA);
if (NumberAtxt.Length > 2)
{
  Console.WriteLine("третья цифра -> " + NumberAtxt[2]);
}

else 
{
  Console.WriteLine("-> третьей цифры нет");
}

