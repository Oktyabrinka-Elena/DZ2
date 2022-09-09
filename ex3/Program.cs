// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7 ");
int num = Convert.ToInt16(Console.ReadLine());

switch (num)
{
    case 1: Console.WriteLine("Понедельник - будний день"); break;
    case 2: Console.WriteLine("Вторник - будний день"); break;
    case 3: Console.WriteLine("Среда - будний день"); break;
    case 4: Console.WriteLine("Четверг - будний день"); break;
    case 5: Console.WriteLine("Пятница - будний день"); break;
    case 6: Console.WriteLine("Суббота - выходной день"); break;
    case 7: Console.WriteLine("Воскресенье - выходной день"); break;
}
