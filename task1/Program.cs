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

int Even(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return  count;

}


int[] BaseArray = CreateNumbersArray();
PrintArray(BaseArray, "Базовый массив: ");
int EvenArray = Even(BaseArray);
System.Console.WriteLine($"Колличество четных чисел = {EvenArray}");
