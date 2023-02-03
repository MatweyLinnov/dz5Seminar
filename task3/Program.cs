int[] CreateNumbersArray()
{
    int[] array = new int[6];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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

(int, int) Diff(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i <array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return(min, max);
}


int[] BaseArray = CreateNumbersArray();
PrintArray(BaseArray, "Базовый массив: ");
(int min, int max) = Diff(BaseArray);
System.Console.WriteLine($"Разница между максимальным {max} и минимальным значение {min} равна {max - min}");