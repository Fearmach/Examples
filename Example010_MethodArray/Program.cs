// See ДЕЛАЕМ МАССИВ С НЕ ОГРАНИЧЕННЫМ ЧИСЛОМ ЦИФР (ПО ЗАДАННОМУ ЧИСЛУ НАХОДИМ ПОД КАКИМ НОМЕРОМ ЭТО ЧИСЛО В МАССИВЕ)

int[] array = { 11, 2, 33, 43, 84, 5, 67, 7, 84 };

int n = array.Length;
int find = 84;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}
