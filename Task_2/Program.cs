//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Enter the index of the row element:");
int enterRow = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter the index of the colomn element:");
int enterColumn = Int32.Parse(Console.ReadLine());
int arrayROW = 5;
int arrayColumn = 5;
int[,] array = new int[arrayROW, arrayColumn];

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(100);
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}

if(enterRow > -1 && enterRow < arrayROW && enterColumn > -1 && enterColumn < arrayColumn)
{
    Console.WriteLine($"The desired element with the [{enterRow}x{enterColumn}] position is {array[enterRow,enterColumn]}");
}
else
{
    Console.WriteLine("There is no such element");
}








