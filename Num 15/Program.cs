//Программа, по определению рабочего или выходного дня недели.
Console.Write("Введите день недели: ");
string DenNedeli = Console.ReadLine();

if(DenNedeli.ToLower() == "1")
{
    Console.WriteLine("Понедельник");
}
if(DenNedeli.ToLower() == "2")
{
    Console.WriteLine("Вторник");
}
if(DenNedeli.ToLower() == "3")
{
    Console.WriteLine("Среда");
}
if(DenNedeli.ToLower() == "4")
{
    Console.WriteLine("Четверг");
}
if(DenNedeli.ToLower() == "5")
{
    Console.WriteLine("Пятница");
}
if(DenNedeli.ToLower() == "6")
{
    Console.WriteLine("Суббота, УРА выходной!");
}
if(DenNedeli.ToLower() == "7")
{
    Console.WriteLine("Воскресенье, УРА выходной!");
}
else 
{
    Console.Write("В неделе всего 7 дней");
}