// Методы (функции)
//ВИД 1 Ничего не возвращают и ничего не принимают

// void Method1()
// {
//     System.Console.WriteLine("Автор");
// }
// Method1(); // Вызов метода



//ВИД 2 Что-то возвращают и ничего не принимают

// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method21(msg: "Текст", count: 4);




//ВИД 3 Что-то возвращают и ничего не принимают

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// System.Console.WriteLine(year);



//ВИД 4 Что-то возвращают и что-то принимают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "text");
// System.Console.WriteLine(res);

// Вариант через for

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "text");
// System.Console.WriteLine(res);



// Цикл в цикле (Таблица умножения)

for (int i = 2; i < 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i * j}");
    }
    System.Console.WriteLine();
}