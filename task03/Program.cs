// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GengerateArray(int size, int leftRange, int rightRange)
{
    int[] TempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        TempArray[i] = rand.Next(leftRange, rightRange); 
    }
    return TempArray;
}

void PrintArray(int[] collection)
{
    System.Console.Write("["+ string.Join(", ",collection)+"]" + " " + "=>" + " ");
} 

void PrintRavers(int[] arr, int i = 0)
{
     if (i < arr.Length)
     {
      PrintRavers(arr, i + 1);
      System.Console.Write(arr[i] + " ");
     }
} 

int size = ReadInt("введите размер массива");

int[] array = GengerateArray(size, 10, 100);

PrintArray(array);

PrintRavers(array);
