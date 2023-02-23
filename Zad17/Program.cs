Task1();
void Task1()
{
  int x = ReadInt("x");
  int y = ReadInt("y");

  GetQuarter(x,y);

  Console.WriteLine($"(quarter): [{x} - {y}]");
}

int GetQuarter(int x, int y)
{
  if (x == 0 || y == 0)
  {
    return -1;
  }
  if (x > 0 && y > 0) 
  {
    return 1;
  }
  else if (x < 0 && y > 0)
  {
    return 2;
  }
  else if (x < 0 && y < 0)
  {
    return 3;
  }
  else
  {
    return 4;
  }
}

int ReadInt(string argumentName)
{
  Console.WriteLine($"Input {argumentName}");

  int number = 0;
  while (!int.TryParse(Console.ReadLine(), out number))
  {
    Console.WriteLine("It's not a number");
  }

  return number;
  
}