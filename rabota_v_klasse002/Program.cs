// Программа нахождения первой и последней цифры в трёхзначном числе.
int CreateNumber()
{
    int number = new Random().Next(100,1000);
    return number;
}

int fsnumber(int number)
{
    int Decimal = number / 10;
    int Ed = number % 10;
    int Sot = number / 100;
    return Sot * 10 + Ed;
}

int a = CreateNumber();
Console.Write("Придуманное трёхзначное число: ");
Console.WriteLine(a);
int FS = fsnumber(a);
Console.Write("Первая и последняя цифра в числе: ");
Console.WriteLine(FS);