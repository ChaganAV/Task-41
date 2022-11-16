int countNum = 0; // количество чисел больше 0
Console.WriteLine("Введите несколько чисел через запятую: ");
string? textInput = Console.ReadLine();
if (textInput is null || textInput.Trim().Length == 0)
{
    Console.WriteLine("Необходимо ввести числа");
    return;
}
else
{
    string[] arraySimv = textInput.Split(',');
    countNum = CountNumbersMoreZerro(arraySimv);
    Console.WriteLine($"{countNum} больше нуля");
}


// Функции
int CountNumbersMoreZerro(string[] array)
{
    int count = 0; // количество числе больше 0
    int num = 0; // сюда положим число из массива
    for (int i = 0; i < array.Length; i++)
    {
        if (Int32.TryParse(array[i], out num))
        {
            if (num > 0)
                count++;
        }
    }
    return count;
}
