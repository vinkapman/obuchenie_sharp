/*Урок 7. Двумерные массивы
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9


void NewArray (int rows, int cols) {
    double[,] nums = new double[rows, cols];

    double value;

    for (int i = 0; i < nums.GetLength(0); i++) {
        for (int j = 0; j < nums.GetLength(1); j++) {
        
            nums[i, j] = value = new Random().NextDouble();
            Console.Write(nums[i, j]+"\t");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
NewArray(m, n);
*/





/*
Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого 
найденого числа или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

void NewArray (int rows, int cols, int num) {
    int[,] nums = new int[rows, cols];

    int value;

    for (int i = 0; i < nums.GetLength(0); i++) {
        for (int j = 0; j < nums.GetLength(1); j++) {
        
            nums[i, j] = value = new Random().Next(0, 10);
            Console.Write(nums[i, j]+"\t");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < nums.GetLength(0); i++) {
            for (int j = 0; j < nums.GetLength(1); j++) {
        
                if (nums[i, j] == num) {
                    Console.WriteLine($"Индекс числа {num} = {i} , {j}");
                    return;
                }    
                }
                
            }
    Console.WriteLine("Такого числа нет");        
    }


Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для поиска:");
int num = Convert.ToInt32(Console.ReadLine());

NewArray(m, n, num);
*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void NewArray (int rows, int cols) {
    int[,] nums = new int[rows, cols];
    int rowsSum = rows;
    double[] sumArr = new double [rowsSum];
    int value;
    for (int i = 0; i < nums.GetLength(0); i++) {
        for (int j = 0; j < nums.GetLength(1); j++) {
        
            nums[i, j] = value = new Random().Next(0, 10);
            Console.Write(nums[i, j]+"\t");
        }
        Console.WriteLine();
    }

    for (int j = 0; j < nums.GetLength(1); j++) {
        double sum = 0;
            for (int i = 0; i < nums.GetLength(0); i++) {
        
                sum += nums[i,j];
                
                }    
            sum = sum / nums.GetLength(0);     
            Console.Write(sum+"\t");
            sumArr[j] = sum;
            }
    Console.Write("Среднее арифметическое каждого столбца: ");
    foreach(double i in sumArr) {
        Console.Write(i+"\t");
    }

    }


Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

NewArray(m, n);