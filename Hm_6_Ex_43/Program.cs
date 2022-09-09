// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1x + b1 =k2x + b2 
// k1x = k2x + b2 - b1
//  
Console.WriteLine("Введите последовательно через Enter каждые значения координат прямых линий (сначала первые две по отдельности, потом следующий две по отдельности.");

int[] coordinates = WriteInputInArray();
FindAndPrintIntersectionPoint(coordinates);
// Методы
void FindAndPrintIntersectionPoint (int[] array)
{
    int result = (array[2] - array[0]) / (array[1]- array[3]);
    Console.WriteLine($"Точка пресечения заданных прямых равна {result}");
}

int[] WriteInputInArray ()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число");
        string? input = Console.ReadLine();
        ValidateInput(input);
        array[i] =  Convert.ToInt32(input);
    }
    return array;
}

void ValidateInput (string input)
{
    bool IsNumber = int.TryParse(input, out int number);
    if (!IsNumber) 
    {
        Console.WriteLine("Пожалуйста, введите целое число."); 
    }
}
