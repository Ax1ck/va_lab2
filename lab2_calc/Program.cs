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
        Console.WriteLine("0. Выход");

        while (true)
        {
            Console.Write("Выберите операцию (введите соответствующее число): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Addition();
                    break;
                case "2":
                    Subtraction();
                    break;
                case "3":
                    Multiplication();
                    break;
                case "4":
                    Division();
                    break;
                case "5":
                    Sin();
                    break;
                case "6":
                    Cos();
                    break;
                case "7":
                    Tan();
                    break;
                case "8":
                    Cot();
                    break;
                case "9":
                    Exp();
                    break;
                case "10":
                    Sqrt();
                    break;
                case "11":
                    Log();
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

    static void Addition()
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат: {num1 + num2}");
    }

    static void Subtraction()
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат: {num1 - num2}");
    }

    static void Multiplication()
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат: {num1 * num2}");
    }

    static void Division()
    {
        Console.Write("Введите делимое: ");
        double dividend = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите делитель: ");
        double divisor = Convert.ToDouble(Console.ReadLine());
        if (divisor == 0)
            Console.WriteLine("Ошибка: деление на ноль!");
        else
            Console.WriteLine($"Результат: {dividend / divisor}");
    }

    static void Sin()
    {
        Console.Write("Введите угол в градусах: ");
        double angle = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат: {Math.Sin(angle * Math.PI / 180)}");
    }

    static void Cos()
    {
        Console.Write("Введите угол в градусах: ");
        double angle = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат: {Math.Cos(angle * Math.PI / 180)}");
    }

    static void Tan()
    {
        Console.Write("Введите угол в градусах: ");
        double angle = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат: {Math.Tan(angle * Math.PI / 180)}");
    }

    static void Cot()
    {
        Console.Write("Введите угол в градусах: ");
        double angle = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат: {1 / Math.Tan(angle * Math.PI / 180)}");
    }

    static void Exp()
    {
        Console.Write("Введите значение для экспоненты: ");
        double value = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат: {Math.Exp(value)}");
    }

    static void Sqrt()
    {
        Console.Write("Введите число: ");
        double number = Convert.ToDouble(Console.ReadLine());
        if (number < 0)
            Console.WriteLine("Ошибка: невозможно извлечь корень из отрицательного числа!");
        else
            Console.WriteLine($"Результат: {Math.Sqrt(number)}");
    }

    static void Log()
    {
        Console.Write("Введите число: ");
        double number = Convert.ToDouble(Console.ReadLine());
        if (number <= 0)
            Console.WriteLine("Ошибка: логарифм отрицательного или нулевого числа не определен!");
        else
            Console.WriteLine($"Результат: {Math.Log(number)}");
    }
}