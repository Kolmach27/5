int Length = InputInt("Введите колличество элементов");
int[] array = new int[Length];
Array(array);
Console.WriteLine("Массив: ");
PrintArray(array);
int result = MyArray(array);
System.Console.WriteLine($"Количество чётных чисел в массиве > {result}");

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int MyArray(int[] array)
{
    int count = 0;    
    for (int i = 0; i  < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
return count;
}
void Array(int[] array)
{
    for (int i = 0; i  < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
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