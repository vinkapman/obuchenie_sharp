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
 

    Console.WriteLine("Enter number of quter");
    int num=int.Parse(Console.ReadLine());
    
    switch(num)
    {
        case 1:Console.WriteLine("X>0, Y>0");break;
        case 2:Console.WriteLine("X<0, Y>0");break;
        case 3:Console.WriteLine("X<0, Y<0");break;
        case 4:Console.WriteLine("X>0, Y<0");break;
        default:Console.WriteLine("Wrong quoter num");break;
        
    }



// На вход будет подаваться число (сумма вклада). При значении меньше 100, будет начислено 5 %, 
// если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. 
// Отработав, программа должна вывести общую сумму с начисленными процентами. 
// Для решения этой задачи воспользуемся выражением Convert.ToDouble(Console.ReadLine()), 
// которое нам пригодится для получения вводимого с клавиатуры числа.

    Console.WriteLine("Введите сумму вклада: ");
    double sum = Convert.ToDouble(Console.ReadLine());
    double resalt = 0;

        if (sum < 100)
        {
            resalt = sum + sum/100*5;
        }
        else if (sum >= 100 && sum <= 200)
        {
            resalt = sum + sum/100*7;
        }
        else
        {
            resalt = sum + sum/100*10;
        }

    Console.WriteLine(resalt);
*/
    Console.WriteLine("Введите координату Х первой точки");
    int onePointX=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату Y первой точки");
    int onePointY=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату Х второй точки");
    int twoPointX=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату Y второй точки");
    int twoPointY=int.Parse(Console.ReadLine());

    double rast = Math.Pow((onePointX - twoPointX), 2) + Math.Pow((onePointY - twoPointY),2);
    rast = Math.Sqrt(rast);

    Console.WriteLine(rast);






    }
}