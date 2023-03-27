internal class Program
{
    private static void Main(string[] args)
    {
    /*    Console.WriteLine("Ввидите число от 0 до 99:");
        int num = new Random().Next(10, 100);
        int numOne = num / 10;
        int numTwo = num % 10;

        Console.WriteLine(num);

        if (numOne > numTwo)
        {
            System.Console.WriteLine("numOne > numTwu");
        }

        else if 
        {
            System.Console.WriteLine("numTwo > numOne");
        }

        else
        {
            System.Console.WriteLine("numOne == numTwo");
        } 
    
    Console.WriteLine("Задача 2");

    int num = new Random().Next(100, 1000);
    Console.WriteLine(num);
    int numOne = num / 100;
    // int numTwo = num / 10;
    int numThree = num % 10;
    int result = numOne*10+numThree;
    Console.WriteLine(result);



    Console.WriteLine("Введите чило 1: ");
    string strNumOne = Console.ReadLine();
    Console.WriteLine("Введите чило 2: ");
    string strNumTwo = Console.ReadLine();
    int NumOne = Convert.ToInt32(strNumOne);
    int NumTwo = Convert.ToInt32(strNumTwo);
    int krat = NumOne%NumTwo;
    if (krat == 0)
    {
        Console.WriteLine("kratno");
    }

    else
    {
        Console.WriteLine(krat);
    }

     

    Console.WriteLine("Введите чило: ");
    string strNumOne = Console.ReadLine();
    
    int numOne = Convert.ToInt32(strNumOne);
    
    if (numOne % 7 == 0 && numOne % 23 == 0)
    {
        Console.WriteLine("kratno");
    }

    else
    {
        Console.WriteLine("не кратно");
    }

    */
    // //Задача №1. Напишите программу, которая на вход
    // принимает два числа и проверяет, является ли первое
    // число квадратом второго.
    // a = 5, b = 25 -> да
    // a = -4, b = 16 -> нет
    // a = 25, b = 5 -> да
    // a = 8 b = 9 -> нет
    Console.WriteLine("Введите чило 1: ");
    string strNumOne = Console.ReadLine();
    Console.WriteLine("Введите чило 2: ");
    string strNumTwo = Console.ReadLine();
    int numOne = Convert.ToInt32(strNumOne);
    int numTwo = Convert.ToInt32(strNumTwo);

    int kvadrat1 = numOne*numOne;
    int kvadrat2 = numTwo*numTwo;
   
    if (numOne == kvadrat2 || numTwo == kvadrat1)
    {
        Console.WriteLine("yes");
    }

    else
    {
        Console.WriteLine("no");
    }

    }
}