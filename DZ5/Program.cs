===============================Задача 64
//вариант1
int Numbers (int N)
{
   if (N==1)
   return 1;
   else return 1 + Numbers (N-1 );
    }
    for (int i=10; i>=1; i--)
    {
    Console.Write($"{Numbers(i)} ");
}
Console.WriteLine()

//вариант2 это по лекции дополнительной :-)
string Numbers (int a)
{
    if ( a >= 1)
    return  $"{a} " + Numbers (a - 1) ;
    else
    return String.Empty;
}
Console.Write (Numbers(10))
=====================================Задача 66
int Numbers (int M, int N)
{
    if (M == N) 
    return N;
    else
    return M +  Numbers ( M + 1,  N);
}
int x = Numbers (4, 8);
Console.WriteLine(x);