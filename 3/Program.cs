int Length = InputInt("Введите колличество элементов");
double[] array = new double[Length];
MaterialArray(array);
Console.WriteLine("Массив: ");
PrintArray(array);
double min = array[0];
double max = array[0];
Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void Calculat(double[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }

}

void MaterialArray(double[] array)
{  
    for (int i = 0; i  < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}
void Array(int[] array)
{
    for (int i = 0; i  < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i  < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}