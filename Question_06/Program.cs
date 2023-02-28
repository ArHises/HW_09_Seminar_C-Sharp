// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем.

int SumSubsequence(int n, int first, int second)
{
    if (n == 1) return first + second;
    int save = second;
    second = first + second;
    first = save;
    Console.Write($"{second}, ");
    return SumSubsequence(n - 1, first, second);
}

Console.Write("Enter first:");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Enter second:");
int second = int.Parse(Console.ReadLine()!);

SumSubsequence(10, first, second);