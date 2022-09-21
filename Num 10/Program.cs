//Программa, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
string text = Console.ReadLine();
int y = text[text.Length - 2] - '0';

Console.Write("Предпоследняя цифра числа: ");
Console.Write(y);