//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
//Сделать отдельный метод который генерирует двумерный массив и отдельный метод который выводит его на экран.

Console.Clear();
Console.WriteLine("Задача 47");
Console.Write("Введите кол-во строк для массива: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите кол-во столбцов для массива: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

Console.WriteLine();
Print2DoubleArray(Generate2DArray(m, n));


double[,] Generate2DArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.Next(-10, 10) + random.NextDouble(), 1);
        }
    }
    return array;
}

void Print2DoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine();
    }
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine();
int[,] array50 = GenerateRandom2DArray();

int[,] GenerateRandom2DArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(2, 11), random.Next(2, 11)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}
void Print2Darray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");

        }
        Console.WriteLine();
    }

}

Console.WriteLine("Задача 50");
Console.Write("Введите номер строки массива: ");
bool isParsedR = int.TryParse(Console.ReadLine(), out int r);
Console.Write("Введите номер столбца массива: ");
bool isParsedC = int.TryParse(Console.ReadLine(), out int c);
if (!isParsedR || !isParsedC || r == 0 || c == 0)
{
    Console.WriteLine("Ошибка!");
    return;
}
if (r > array50.GetLength(0)|| c > array50.GetLength(1) )
{
    Print2Darray(array50); // для проверки
    Console.WriteLine($"В заданном массиве нет элемента с индексом ({r},{c})");
    
    return;
}
else
{
    Console.WriteLine($"Элемент {r},{c} = {array50[r - 1, c - 1]}");
    Print2Darray(array50); // для проверки
    
}



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце. 
// Поиск среднее арифметического в отдельном методе.

Console.WriteLine();
Console.WriteLine("Задача 52");

int[,] array52 = GenerateRandom2DArray();
Print2Darray(array52);


double[,] AverageInColums(int[,] array)
{
    double[,] averageArray = new double[1, array.GetLength(1)];
    double sum = 0;

    for (int colums = 0; colums < array.GetLength(1); colums++)
    {
        sum = 0;
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {

            sum += array[rows, colums];
        }
        averageArray[0, colums] = sum / array.GetLength(0);
    }

    return averageArray;

}
Console.WriteLine();
Console.WriteLine("Среднее по столбцам: ");
Print2DoubleArray(AverageInColums(array52));














