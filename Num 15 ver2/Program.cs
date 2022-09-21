//Программа, по определению рабочего или выходного дня недели.
Console.WriteLine("Введите число соотвествующее дню недели: ");
      int number = Convert.ToInt32(Console.ReadLine());
      string[] DenNedeli = {"рабочий день!","рабочий день!","рабочий день!","рабочий день!","рабочий день!","выходной день, ура!","выходной день, ура!"};
      if (number > 7)
      {
        Console.WriteLine("Число не соотвествует дню недели!"); 
      }
      else
      {
          Console.Write("Сегодня ");
          Console.Write(DenNedeli[number-1]);
      }