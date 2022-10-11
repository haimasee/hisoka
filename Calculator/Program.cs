// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

char again = 'x';
while (again == 'x')
{
    
    double a;
    double b;
    int y;
    double total;
    char oper; //номер операции
    int fac;

    Console.WriteLine("Введите первое число:");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите оператор:");
    oper = Convert.ToChar(Console.ReadLine());

    if (oper == '1')
    {
        total = a + b;
        Console.WriteLine("Cумма " + a + " и " + b + " = " + total + ".");
    }

    else if (oper == '2')
    {
        total = b - a;
        Console.WriteLine("Разность " + a + " и " + b + " = " + total + ".");
    }

    else if (oper == '3')
    {
        total = a * b;
        Console.WriteLine("Умножение " + a + " на " + b + " = " + total + ".");
    }

    else if (oper == '4')
    {
        total = a / b;
        Console.WriteLine("Деление " + a + " на " + b + " = " + total + ".");
    }

    else if (oper == '5')
    {
        var x = Double.Parse(Console.ReadLine());
        Console.WriteLine("a^b = " + Math.Pow(a, b));
    }

    else if (oper == '6')
    {
 
        total = Convert.ToInt32(Math.Sqrt(a));
        Console.WriteLine("Квадратный корень " + a + " = " + total + ".");
    }

    else if (oper == '7')
    {
        total = a / 100;
        Console.WriteLine("1% от числа " + a + " = " + total + ".");
    }

    else if (oper == '8')
    {
        fac = 1;
        y = 1;
        for (int i = 0; i < a; i++)
        {
            fac *= y;
            y++;
        }
      
        Console.WriteLine("Факториал = " + fac + ".");
    }

    else 
    {
        Console.WriteLine("Такой операции не существует. Прощай!");
    }
    again = Convert.ToChar(Console.ReadLine());
}