int countNum = 0; // число чисел больше 0
Console.WriteLine("Введите несколько чисел через запятую: ");
string? textInput = Console.ReadLine();
if (textInput is null)
{
    Console.WriteLine("Необходимо ввести числа");
    return;
}
else
{
    string[] arraySimv = textInput.Split();
    PrintString(textInput);

    countNum = CountNumbersMoreZerro(arraySimv);
    Console.WriteLine($"{countNum} больше нуля");
}


// Функции
int CountNumbersMoreZerro(string[] array)
{
    int count = 0;
    char simv;
    for (int i = 0; i < array.Length; i++)
    {
        if (Char.TryParse(array[i], out simv))
        {
            if (Char.IsDigit(simv))
            {
                if (simv > 0)
                    count++;
            }
        }
    }
    return count;
}
void PrintString(string text)
{
    Console.WriteLine(text);
}
