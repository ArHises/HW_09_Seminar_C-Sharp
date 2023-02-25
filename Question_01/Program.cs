// Показать натуральные числа от M до N, N и M заданы

Console.Write("Enter 1st number: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Enter 2nd number: ");
int m = int.Parse(Console.ReadLine()!);

void PrintTill(int n, int m)
{
    if (m < n)
    {
        Console.WriteLine(m);
        PrintTill(n, m + 1);
    }
    else if (n < m)
    {
        PrintTill(m, n + 1);
        Console.WriteLine(n);
    }
    else Console.WriteLine("Done");
}
PrintTill(n, m);