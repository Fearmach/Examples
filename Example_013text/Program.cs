// Работа с текстом: Дан текст, в тексте нужно все пробелы заменить на черточки, маленькие буквы к заменить на большие К, а большие С на маленькие с

string text = "- Я думаю, сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text,' ', '-');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText,'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText,'с', 'С');
System.Console.WriteLine(newText);