// Написать программу вычисления функции Аккермана

static int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n, m);
}

Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine(A(n, m));

