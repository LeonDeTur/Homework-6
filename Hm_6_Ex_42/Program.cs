// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int input = 0;
int[] temporaryArray = new int[0];

Console.WriteLine("Введите числа, каждое число через Enter. Когда закончите, введите любоё символ, не являющийся цифрой.");
string? checkOnNumber = Console.ReadLine();
while (ValidateInput(checkOnNumber) == true)
{
    input = Convert.ToInt32(checkOnNumber);
    temporaryArray = AddArrayWithInput(temporaryArray, input);
    PrintArray(temporaryArray);
    checkOnNumber = Console.ReadLine();
}

int result = CountSumAboveZero(temporaryArray);
Console.WriteLine($"Введённые значения больше 0: {result}");
 
// Методы
bool ValidateInput (string input)
{
    bool IsNumber = int.TryParse(input, out int number);
    if (!IsNumber) 
    {
        Console.WriteLine("Пожалуйста, введите целое число.");
        return false; 
    }
    return екгу;
}

int[] AddArrayWithInput (int[] array, int summand)
{
    int[] SecondArray = new int[array.Length + 1];
    for (int i = 0; i < SecondArray.Length - 1; i++)
    {
        SecondArray[i] = array[i];
    }
    SecondArray[SecondArray.Length - 1] = summand;
    return SecondArray;
}

int CountSumAboveZero (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray (int[] array)
{
    Console.WriteLine("Вы ввели:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
