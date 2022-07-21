//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int arrayRow = 4;
int arrayColumn = 4;
int[,] array = new int [arrayRow, arrayColumn];
for(int i = 0; i < arrayRow; i++)
{
    for(int j = 0; j < arrayColumn; j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}


//var 1
// for (int i = 0; i < arrayRow; i++)
// {
//   double arithmeticMean = 0;
//   for (int j = 0; j < arrayColumn; j++)
//   {
//     arithmeticMean = arithmeticMean + array[j, i];
//   }
//   arithmeticMean = Math.Round(arithmeticMean / arrayRow, 2);
//   Console.WriteLine($"Arithmetic mean of the {i+1} column = {arithmeticMean}");  
// }

//var 2
double[] finishArray = new double[arrayColumn];

for (int i = 0; i < arrayRow; i++)
{
  double arithmeticMean = 0;
    for (int j = 0; j < arrayColumn; j++)
  {
    arithmeticMean = arithmeticMean + array[j, i];    
  }  
  arithmeticMean = Math.Round(arithmeticMean / arrayRow, 2);
  finishArray [i] = arithmeticMean;  
}
Console.WriteLine($"Arithmetic mean of each column {String.Join(";", finishArray)}");

