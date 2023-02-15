// Поиск различной информации в папках(дериктории)

string path = "C:\Users\beloy\OneDrive\Рабочий стол\Учеба\С# Семинары, лекции 3.0\Лекции example\Example_001Helloworld";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}

// РЕКУРСИЯ

void CatalogInfo[] (string path, string indent = '')
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalog = catalog.GetDerectories();
    for (int i = 0; i < catalog.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalog[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = @"C:\Users\beloy\OneDrive\Рабочий стол\Учеба\С# Семинары, лекции 3.0\Лекции example\Example_001Helloworld";
CatalogInfo(path);

