// ъэббэъбъэбэбъэ
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
Console.WriteLine("Данная программа является калькулятором \n Введите номер операции: : ");
Console.WriteLine("1 - сложение");
Console.WriteLine("2 - вычитание");
Console.WriteLine("3 - умножение");
Console.WriteLine("4 - деление");
Console.WriteLine("5 - возведение первого числа в степень второго");
Console.WriteLine("6 - найти квадратный корень из числа ");
Console.WriteLine("7 - найти 1 процент от числа ");
Console.WriteLine("8 - найти факториал из числа");
Console.WriteLine("9 - выход");
int number = 0;
do
{

    number = Convert.ToInt32(Console.ReadLine());
    if (number == 1)
    {
        Console.WriteLine("Введите 2 числа: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a + b);
        Console.WriteLine("Введите номер операции: ");
    }
    else if (number == 2)
    {
        Console.WriteLine("Введите 2 числа: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a - b);
        Console.WriteLine("Введите номер операции: ");
    }
    else if (number == 3)
    {
        Console.WriteLine("Введите 2 числа: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a * b);
        Console.WriteLine("Введите номер операции: ");
    }
    else if (number == 4)
    {
        Console.WriteLine("Введите 2 числа: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a / b);
        Console.WriteLine("Введите номер операции: ");
    }
    else if (number == 5)
    {
        Console.WriteLine("Введите 2 числа: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Pow(a, b));
        Console.WriteLine("Введите номер операции: ");
    }
    else if (number == 6)
    {
        Console.WriteLine("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(a));
        Console.WriteLine("Введите номер операции: ");
    }
    else if (number == 7)
    {
        Console.WriteLine("Введите 2 числа: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a / 100);
        Console.WriteLine("Введите номер операции: ");
    }
    else if (number == 8)
    {
        Console.WriteLine("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine(factorial);
        Console.WriteLine("Введите номер операции: ");
    }
    else if (number > 9 | number == 0)
        Console.WriteLine("Такой операции нет");
} while (number != 9);