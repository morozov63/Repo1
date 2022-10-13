===============================================Задача 54
  int[,]  numbers = {{ 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9}};
  for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1)-1 ; j++)
     {
        for (int z = 0; z < numbers.GetLength(1)-1 ; z++)
            {
            if (numbers[i, z] < numbers[i, z + 1]) 
            {
                int min  = numbers[i, z];
                
                int temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = min;
            }
     }
 }
    
}
for (int i = 0; i < numbers.GetLength(0); i++)
    {
      for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]} ");
        }
       Console.WriteLine();
}   
  
===================================Задача 58
/*С начала я подумал, что перемножить матрицу , значит перемножить просто по соответствующим 
индексам, потом посмотрел в инете , понял , что не прав, все сложнеее, но этот вариант оставил*/
int [,] matrics = {{1,2},{3,4}};
 int [,] matr =  {{5,6},{7,8}};
 int [,] multiply=new int[matrics.GetLength(0),matr.GetLength(0)];

 for(int i = 0;i< matrics.GetLength(0); i++)
 {
    for (int j = 0; j< matrics.GetLength(1); j++)
    {
        multiply[i,j] =  matrics[i,j]* matr[i,j];
        Console.Write($"{multiply[i,j]} ");
    }
    Console.WriteLine();
 }

--------------------------------------------------------

 int [,] matrics = {{1,2},{3,4}};
 int [,] matr =  {{5,6},{7,8}};
 int [,] multiply=new int[matrics.GetLength(0),matr.GetLength(0)];

 for(int i = 0;i< matrics.GetLength(0); i++)
  {
    for (int j = 0; j< matrics.GetLength(1); j++)
    {
        for(int y = 0; y < matr.GetLength(0); y++)

        multiply[i,j] = multiply[i,j] + multiply[i,y]* matr[y,j];
        Console.Write($"{multypley[i,j]} ");
    }
    Console.WriteLine();
 }   
=========================================================Задача 60 
 //Как сделать массив с неповторяющимися данными ,увы, не придумал ;-((
   int[,,] matrics = new int[2,2,2];
 for(int i = 0;i< matrics.GetLength(0); i++)
 {
    for (int j = 0; j< matrics.GetLength(1); j++)
    {
        for (int x = 0; x< matrics.GetLength(2); x++)
           {
              matrics[i,j,x]= new Random().Next(10,100);
              
              Console.Write($"{matrics[i,j,x]}  ({i},{j},{x}) ");
            }
    Console.WriteLine();
    }
 }

 