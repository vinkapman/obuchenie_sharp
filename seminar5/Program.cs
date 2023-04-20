// Задача 39: Напишите программу, 
//которая перевернёт одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
/*
Console.Clear();
int[] array = GetRandomArray(12, 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
MyReverse2(array);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

void MyReverse2(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int tmp = array[i];
        array[i] = array(array.Length - 1 - i);
        array[array.Length - 1 - i] = tmp;
    }

    return reverse;
}



// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
// с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int[] triangle = {0, 0, 0};
Console.WriteLine("Введите сторону А:");
triangle[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B:");
triangle[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C:");
triangle[2] = Convert.ToInt32(Console.ReadLine());
        if (triangle[0] < (triangle[1]+triangle[2]) && triangle[1] < (triangle[2]+triangle[0]) && triangle[2] < (triangle[1]+triangle[0])) Console.WriteLine("Треугольник существует");
        else Console.WriteLine("Треугольник не существует");





int Enter (string num);
    {
        Console.Write(numb);
        string numb = Console.ReadLine();
        int result = int.Parse(numb);
        return result;
    }

bool CheckTheTrue (int A, int B, int C)
    {
        if (A<(B+C) && B<(A+C) && C<(A+B)) return true;
        else return folse;
    }

...

*/

