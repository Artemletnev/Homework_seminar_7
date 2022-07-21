//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Enter rows number:");
int row = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter columns number:");
int column = Int32.Parse(Console.ReadLine());
double[,] array = new double [row, column];
Console.WriteLine("Finish Array:");
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().NextDouble() * 100;
        Console.Write(Math.Round(array[i,j], 2) + "\t");
    }
    Console.WriteLine();
}




