
===========================================Задача 34
int[]Number = new int[10];
void EvenNumbered(int[]Number)
{
    int lenght = Number.Length;
    int index = 0;
    int count = 0;

       while (index < lenght)
    {
        Number[index] = new Random().Next(100, 999);
        //Console.Write($"{Number[index]} "); Делал эту строку для самоконтроля :-)
        if(Number[index]%2 == 0)
          count++;
          index++;
    }
    Console.WriteLine(count);
}
EvenNumbered(Number);
===================================================Задача 36

int [] Number = new int[5];
void SumUnevenPoint(int [] Number)
{
    int index = 0;
    int lenght = Number.Length;
    int Result = 0;
    
        while (index < lenght)
        {
            Number[index] = new Random().Next(-99, 99);
            Console.Write($"{Number[index]} ");
            if (index%2 != 0)
            Result = Result + Number[index];
            index++;
        }
        Console.WriteLine($"Сумма: {Result}");

}
SumUnevenPoint(Number);
===========================================================Задача 38

double[]Number = new double[]{1.9, 3.4 , 15, 58, 90.59};
void MaxMin( double[]Number)

{
    int index = 0;
    int lenght = Number.Length;
    double Max = Number[0];
    double Min = Number[0]; 
       while (index < lenght)
    {
         if (Number[index] > Max)
         {
         Max= Number[index];
         }
      
         if (Number[index] < Min)
        {
          Number[index] = Min;
        }
    index++;
    }
    Console.WriteLine(Max - Min);
}
MaxMin(Number);
