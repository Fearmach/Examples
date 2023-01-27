// Установить минимум и менять мин числа с мах по порядку

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.WriteLine($"{array[i]}");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minpos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minpos]) minpos = j;
        }
        int temporary = array[i];
        array[i] = array[minpos];
        array[minpos] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
