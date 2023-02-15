﻿// СЧИТАЕМ КОЛИЧЕСТВО ДЕЙСТВИЙ(ИТЕРАЦИЙ) В ОБЫЧНОМ МЕТОДЕ И РЕКУРСИИ

decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2); 
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 0; i < n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

//# 1 2 3 4 5 6
//V 1 1 2 3 5 8
System.Console.ReadLine();

DateTime dt = DateTime.Now;
for (int n = 1; n < 20; n++)
{
    System.Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), - 15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

System.Console.WriteLine();
System.Console.ReadLine();

for (int n = 1; n < 20; n++)
{
    System.Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fIte = {fRec.ToString("### ### ###"), - 15}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);





