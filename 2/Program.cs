int Length = InputInt("Введите колличество элементов");
int[] array = new int[Length];
Array(array);
Console.WriteLine("Массив: ");
PrintArray(array);
int result = SumArray(array);
System.Console.WriteLine($"Сумма нечетных позиций > {result}");

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int SumArray(int[] array)
{
    int sum = 0;    
    for (int i = 0; i  < array.Length; i+= 2)
    {
        sum = sum + array[i];
    }
return sum;
}
void Array(int[] array)
{
    for (int i = 0; i  < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i  < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}