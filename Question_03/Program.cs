// Найти сумму цифр числа

int NumberSumTwo(int N)
{
    if (N / 10 == 0) return N;
    return NumberSumTwo(N / 10) + N % 10;
}

Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumberSumTwo(N));
