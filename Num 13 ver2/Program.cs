Console.WriteLine("Введите число: ");
      String number = Console.ReadLine();
      Console.WriteLine("Имеем число! ");
      Console.WriteLine(number);
      if (number.Length < 3)
      {
          Console.WriteLine("Нет третьего числа");
      }
      else
      {
      char[] line = number.ToCharArray();
      Console.WriteLine("Третье число: ");
      Console.Write(line[2]);
      }