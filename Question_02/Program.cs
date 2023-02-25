// Найти сумму элементов от M до N, N и M заданы

int PrintTillN(int N, int M)
{
    if (N == M)
        return N;
    return PrintTillN(N - 1, M) + N;
}

Console.WriteLine("Enter 1st number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter 2nd number: ");
int M = int.Parse(Console.ReadLine()!);

if (M < N)
    System.Console.WriteLine(PrintTillN(N, M));
else
    System.Console.WriteLine(PrintTillN(M, N));;
