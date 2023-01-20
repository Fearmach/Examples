// СОЗДАЕМ ФУНКЦИЮ, ГДЕ VOID ЭТО ФУНКЦИЯ ...  АРГУМЕНТ COLLECTION, int length = collection.length - ПОЛУЧАЕМ ДЛИННУ МАССИВА. НАХОДИМ ПОЗИЦИЮ ЧИСЛА В МАССИВЕ
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        System.Console.WriteLine(col[pos]);
        pos++;
    }
}

int Indexoff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int poss = Indexoff(array, 3);
System.Console.WriteLine(poss);

