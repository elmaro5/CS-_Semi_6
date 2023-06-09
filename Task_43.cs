//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double B1 = inputNumber(("Введите b1: "));
double K1 = inputNumber(("Введите k1: "));
double B2 = inputNumber(("Введите b2: "));
double K2 = inputNumber(("Введите k2: "));

double findX()
{
    return (B2 - B1) / (K1 - K2);
}

double findY()
{
    return K1 * findX() + B1;
}

Console.WriteLine($"({findX()}, {findY()})");


int inputNumber(string message)
{
    int number;
    string text;

    while (true)
    {
        Console.Write(message);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
