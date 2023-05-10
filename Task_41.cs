int numsCount = inputNumber(("Введите кол-во символов: "));
if (numsCount <= 0) numsCount = 1;

int[] numStack = new int[numsCount];



for (int i = 0; i < numStack.Length; i++)
{
    arrElAdder(i, inputNumber(($"Введите символ {i + 1}: ")));
}

void arrElAdder(int i, int el)
{
    numStack[i] = el;
}

int count = 0;
foreach (int i in numStack)
{
    if (i > 0) count += 1;
}
Console.WriteLine(count);


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