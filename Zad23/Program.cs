// 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
//     является ли второе число кратным первому.
//     Если число 2 не кратно числу 1, то программа выводит остаток от деления.


Console.Write("Введите первое число:");
int.TryParse(Console.ReadLine(), out int a);
Console.Write("Введите второе число:");
int.TryParse(Console.ReadLine(), out int b);

int c = (a % b);
int d = (b % a);


if (a > b)
{
  if (c == 0) Console.WriteLine($"Число {a} кратно {b}");
  else  Console.WriteLine($"Число {a} не кратно {b} , остаток {c}");
}
else
{
  if (d == 0) Console.WriteLine($"Число {b} кратно {a}");
  else  Console.WriteLine($"Число {b} не кратно {a} , остаток {d}");
}