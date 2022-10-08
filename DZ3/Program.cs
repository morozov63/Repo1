=============================================Задача 47
double[,] mnArray(int m,int n)
{
double[,] Array = new double[m,n];

for (m = 0; m < Array.GetLength(0); m++ )
    {
       for (n = 0; n < Array.GetLength(1); n++ ) 
       {
        int x = new Random().Next(1,30);
        Array[m,n] = new  Random().NextDouble() *100 - x;//  вот как то так сделал вещественный массив случайным 
        Array[m,n] = Math.Round (Array[m,n],2);
        Console.Write($"{Array[m,n]} ");
       }
       Console.WriteLine();
    }
return Array; 
}
mnArray(2,3);
===================================================Задача 50
int[,] matr = new int[3,4];

 for (int i = 0; i < matr.GetLength(0); i++)
    {
      for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i,j] = new Random().Next(1,10);
      Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
 }
 void Chek (int x,int y ,int[,] matr)
{ 
if (x > matr.GetLength(0) | y > matr.GetLength(1))
Console.WriteLine("NO");

    for (int i = 0; i < matr.GetLength(0); i++)
      {
      for (int j = 0; j < matr.GetLength(1); j++)
         { 
         if (i==x & j == y)
         {
             Console.WriteLine($"<{matr[i,j]}> ");
         }
        }
       }
    }
Chek (7,1, matr);
===========================================================Задача 52
int[,] matr = new int[3,4];
for (int i = 0; i < matr.GetLength(0); i++)
    {
      for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i,j] = new Random().Next(1,10);
      Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
   }
 Console.WriteLine();

 void Chek ()
{ double res = 0;
double average = 0;

for (int i = 0; i < matr.GetLength(1); i++)
    {
       for (int j = 0; j < matr.GetLength(0);j++)
    {
         res = res + matr[j,i];
         average = res/matr.GetLength(0);
        }    
             Console.WriteLine( Math.Round(average,2));
    }
}
    Chek ();