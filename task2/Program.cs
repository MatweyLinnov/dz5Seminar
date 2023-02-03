int[] CreateNumbersArray()
{
    int[] array = new int[6];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 21);
    }
    return array;
}

void PrintArray(int[] array, string message)
{
    System.Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i <array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}


int[] BaseArray = CreateNumbersArray();
PrintArray(BaseArray, "Базовый массив: ");
int SumArray = Sum(BaseArray);
System.Console.WriteLine(SumArray);