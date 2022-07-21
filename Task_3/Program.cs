//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int arrayRow = 3;
int arrayColumn = 3;
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

for (int i = 0; i < arrayRow; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < arrayColumn; j++)
  {
    arithmeticMean = arithmeticMean + array[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / arrayRow, 2);
  Console.WriteLine($"Arithmetic mean of the {i+1} column = {arithmeticMean}");
}

