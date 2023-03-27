//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

System.Console.Write("Введите колл-во строк: ");
int row = int.Parse(Console.ReadLine());

System.Console.Write("Введите колл-во столбцов: ");
int collums = int.Parse(Console.ReadLine());

double [,] array = new double [row,collums];

for(int i =0;i<array.GetLength(0);i++)
{
    for(int j=0;j<array.GetLength(1);j++)
    {
        array[i,j] = new Random().NextDouble()*100;
        System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
}