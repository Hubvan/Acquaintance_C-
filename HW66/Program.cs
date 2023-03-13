//Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
int IntInput(string intName) 
{
    int num;

    Console.Write($"Введите число {intName}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ошибка!!!");
    }
    return  num;
}

double[,] makeArray(int rowNum, int colNum)
{
    double[,] tdArray = new double[rowNum, colNum];
    Random rnd = new Random();
    for (int i = 0; i <= rowNum-1; i++)
    {
        for (int j=0; j <= colNum-1; j++)
        {
            tdArray[i,j] = Math.Round(rnd.NextDouble()+rnd.Next(-20,20), 1); 
        }
    }
    return tdArray;
}

void printArray(double[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    string stringRes;
    for (int i = 0; i <= rows-1; i++)
    {
        for (int j = 0; j <= columns-1; j++)
        {
            
            stringRes = string.Format("{0:f2}", arr[i,j]);
            Console.Write(stringRes + "  ");
        }    
        Console.WriteLine();
    }

    for(int i=1; i<3; i++) Console.WriteLine();
   
}
    int m = IntInput("M");
    int n = IntInput("N");
    Console.WriteLine(NumbersSum(m,n));

void PauseString()
{
    Console.WriteLine( "Для продолжения нажмите 'Ввод'...");
    Console.ReadLine();
}

string NumbersRec(int a, int b) 
{
if (a <= b) return $"{b} " + NumbersRec(1, b-1);
else return String.Empty;
}

int NumbersSum(int n, int m) 
{
int rev = 0;
if (n <= m) 
{
    return n + NumbersSum(n+1, m);
}
else 
{

    return 0;
}
}

int AkkFunc(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AkkFunc(n - 1, 1);
    else
      return AkkFunc(n - 1, AkkFunc(n, m - 1));
}