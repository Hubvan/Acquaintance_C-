// Задача 19. Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число:");
string chislo = Console.ReadLine();


if (chislo[0] == chislo[chislo.Length-1] && chislo[1] == chislo[(chislo.Length-2)])
//if (chislo[0] == chislo[4] && chislo[1] == chislo[3])
{
   Console.WriteLine($"Число {chislo} является палиндромом");
}
else
{
Console.WriteLine($"Число {chislo} не является палиндромом");
}