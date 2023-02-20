// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.

string i = 1234567;

Console.Write("Введите цифру, обозначающую день недели:");
int.TryParse(Console.ReadLine(), out int den);
string s = den.ToString();

if (den == 5 && den == 6 ) 
{
   Console.WriteLine($"Этот день является выходным");
}
else  
{
Console.WriteLine($"Этот день не является выходным");
}