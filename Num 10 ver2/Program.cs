//Программa, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Имеем число {number}!");

int TwoNumber(int number)
{
    int Decimal = number / 10;
    int Ed = number % 10;
    int Sot = number / 100;
    return Decimal ;
}

int Two = TwoNumber(number) % 10;

Console.Write("Вторая цифра в числе: ");
Console.WriteLine(Two);