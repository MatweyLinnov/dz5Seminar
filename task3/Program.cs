double[] CreateNumbersArray()
{
    double[] array = new double[6];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100,1000);
    }
    return array;
}

void PrintArray(double[] array, string message)
{
    System.Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

(double, double) Diff(double[] array)
{
    double max = array[0];
    double min = array[0];
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


double[] BaseArray = CreateNumbersArray();
PrintArray(BaseArray, "Базовый массив: ");
(double min, double max) = Diff(BaseArray);
System.Console.WriteLine($"Разница между максимальным {max} и минимальным значение {min} равна {max - min}");