using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Калькулятор");
        Console.WriteLine("-------------------");
        
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Введите оператор (+, -, *, /): ");
        string oper = Console.ReadLine();
        
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        if (oper == "+")
        {
            result = num1 + num2;
        }
        else if (oper == "-")
        {
            result = num1 - num2;
        }
        else if (oper == "*")
        {
            result = num1 * num2;
        }
        else if (oper == "/")
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Ошибка: Делить на ноль нельзя!.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Ошибка: неправильный оператор.");
            return;
        }

        Console.WriteLine($"Результат: {result}");
    }
}
