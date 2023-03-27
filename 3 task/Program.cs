//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] array = new int [3,3];

for(int i=0;i<array.GetLength(0);i++)
{
    for(int j=0;j<array.GetLength(1);j++)
    {
        array[i,j] = new Random().Next(1,9);
        System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
}

double first = 0;

for(int i=0;i<array.GetLength(1);i++)
{
    for(int j=0;j<array.GetLength(0);j++)
    {
       first = first + array[i,j];
    }
    double result = first / array.GetLength(0);
    System.Console.Write(result + " ");
}



