===================================================Задача 41

Console.Write("Введите длину массива:  ");
int lenght = Convert.ToInt32 (Console.ReadLine());
int[] numbers  = new int[lenght];
for(int Index = 0;Index < lenght; Index++)
   {
     Console.Write("Введите число :  ");
numbers[Index] = Convert.ToInt32 (Console.ReadLine());
   }

//int[] numbers = Array.ConvertAll<string,int>(Console.ReadLine().Split(','), //вот этот вариант ввода с запятыми я 
//elem => { return System.Convert.ToInt32 (elem);}); //даже и не понял ;-(

void Number(int[] numbers)
{
int lenght = numbers.Length;
int count = 0;
{
    for(int Index = 0; Index < lenght; Index++)
    {
        if (numbers[Index]> 0)
        {
            count++;
        }

    }
    Console.WriteLine(count);
}
}
Number(numbers);

=======================================================Задача 43

Console.Write("Введите число k1:  ");
double k1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число b1:  ");
double  b1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число k2:  ");
double  k2 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число b2:  ");
double  b2 = Convert.ToInt32 (Console.ReadLine());
/*Нашел в инете вот такую систему уравнений ,
 которая опеделяет точку пересечения двух отрезков:
 Y = k1*X + b1
 Y = k2*X + b2
соотвтственно его решение, из первого вычитаем второе :
Y - Y = k1*X + b1 - k2 * X + b2
Y = k2 * X + b2

X = (b2 - b1)/(k1 - k2)
Y = k2*((b2 - b1)/(k1 - k2)) + b2*/

double  X =(b2 - b1)/(k1 - k2);
double  Y = k2*X +b2;

Console.WriteLine($"X ={X}, Y ={Y}");