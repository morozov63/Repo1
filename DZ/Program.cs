
==================================================Задача 25
Console.Write("Введите число A:  ");
int A = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число B:  ");
int B = Convert.ToInt32 (Console.ReadLine());
int Result = 1;
void DegreeNumber (int A, int B)
{  
   { 
    for ( int Count = 0;  Count < B; Count ++)
    Result = Result * A ;
   }
   Console.WriteLine(Result);
}   
DegreeNumber(  A, B);

=======================================================Задача 27

Console.Write("Введите число :  ");
int A = Convert.ToInt32 (Console.ReadLine());
 
int i = 10;
int Result = 0;
  while (i < A*10)
 {   
   Result =  Result + A%i/(i/10);
    i= i*10;
 }
Console.WriteLine(Result);

==============================================Задача 29
int [] eight = new int[8];
void  FillArray(int [] eight)
{
   int length = eight.Length;
   int index = 0;
       while (index < length)
    {
        eight[index] = new Random().Next(1, 99);
        Console.Write($"{eight[index]} ");
        
        index++;
    }
}
FillArray(eight);
Console.WriteLine();