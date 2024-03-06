using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в калькулятор!");
        Console.WriteLine("Доступные операции:");
        Console.WriteLine("1. Сложение (+)");
        Console.WriteLine("2. Вычитание (-)");
        Console.WriteLine("3. Умножение (*)");
        Console.WriteLine("4. Деление (/)");
        Console.WriteLine("5. Синус (sin)");
        Console.WriteLine("6. Косинус (cos)");
        Console.WriteLine("7. Тангенс (tan)");
        Console.WriteLine("8. Катангенс (cot)");
        Console.WriteLine("9. Экспонента (e^x)");
        Console.WriteLine("10. Корень (sqrt)");
        Console.WriteLine("11. Логарифм (log)");
        Console.WriteLine("0. Выход\n\n ");

        while (true)
        {
            Console.Write("Выберите операцию (введите соответствующее число): ");
            string choice = Console.ReadLine();


            double num1, num2, angle, value, number;
            switch (choice)
            {
                case "1":
                    num1 = GetNumber();
                    num2 = GetNumber();
                    Console.WriteLine($"Результат: {num1 + num2}");
                    break;

                case "2":
                    num1 = GetNumber();
                    num2 = GetNumber();
                    Console.WriteLine($"Результат: {num1 - num2}");
                    break;
                case "3":
                    num1 = GetNumber();
                    num2 = GetNumber();
                    Console.WriteLine($"Результат: {num1 * num2}");
                    break;

                case "4":
                    Console.Write("делимое: ");
                    double dividend = GetNumber();
                    Console.Write("Введите делитель: ");
                    double divisor = GetNumber();

                    if (divisor == 0)
                        Console.WriteLine("Ошибка: деление на ноль!");
                    else
                        Console.WriteLine($"Результат: {dividend / divisor}");
                    break;

                case "5":
                    Console.Write("Введите угол в радианах: ");
                    angle = GetNumber();
                    Console.WriteLine($"Результат: { Sin(angle) }");
                    break;

                case "6":
                    Console.Write("Введите угол в радианах: ");
                    angle = GetNumber();
                    Console.WriteLine($"Результат: { Cos(angle) }");
                    break;

                case "7":
                    Console.Write("Введите угол в радианах: ");
                    angle = GetNumber();
                    Console.WriteLine($"Результат: { Tan(angle) }");
                    break;

                case "8":
                    Console.Write("Введите угол в радианах: ");
                    angle = GetNumber();
                    Console.WriteLine($"Результат: {1 / Tan(angle)}");
                    break;

                case "9":
                    Console.Write("Введите значение для экспоненты: ");
                    value = GetNumber();
                    Console.WriteLine($"Результат: {Exp(value)}");
                    break;

                case "10":
                    number = GetNumber();
                    if (number < 0)
                        Console.WriteLine("Ошибка: невозможно извлечь корень из отрицательного числа!");
                    else
                        Console.WriteLine($"Результат: {Sqrt(number)}");
                    break;
                case "11":
                    number = GetNumber();
                    if (number <= 0)
                        Console.WriteLine("Ошибка: логарифм отрицательного или нулевого числа не определен!");
                    else
                        Console.WriteLine($"Результат: {Log(number)}");
                    break;
                case "0":
                    Console.WriteLine("До свидания!");
                    return;
                default:
                    Console.WriteLine("Неверный выбор операции!");
                    break;
            }
        }
    }

    static double GetNumber()
    {
        double num;

        while (true)
        {
            Console.WriteLine("Введите число: ");
            string str = Console.ReadLine();

            try
            {
                num = Convert.ToDouble(str);
            }
            catch(Exception e) 
            {
                Console.Write("Ошибка ввода!\t");
                continue;
            }

            return num;
        }
    }

    static double Sin(double x)
    {
        return x;
    }

    static double Cos(double x)
    {
        return x;
    }

    static double Tan(double x)
    {
        return x;
    }

    static double Cot(double x)
    {
        return x;
    }

    static double Exp(double x)
    {
        return x;
    }

    static double Sqrt(double x)
    {
        return x;
    }

    static double Log(double x)
    {
        return x;
    }
}