//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

System.Console.Write("Введите ваше число: ");
int number = int.Parse(Console.ReadLine());

int [,] array = new int[3,3];

for(int i=0;i<array.GetLength(0);i++)
{
    for(int j=0;j<array.GetLength(1);j++)
    {
        array[i,j] = new Random().Next(1,9);
        System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
}


int result = 0;
    for(int i=0;i<array.GetLength(0);i++)
{
    for(int j=0;j<array.GetLength(1);j++)
    {
        if(array[i,j] == number)
        {
            result = result + 1;
        }
    }
}


if(result > 0)
{
    System.Console.WriteLine($"Число в вашем массиве '{number}' > существует!");
}
else
{
    System.Console.WriteLine($"Число в вашем массиве '{number}' > не существует!");
}