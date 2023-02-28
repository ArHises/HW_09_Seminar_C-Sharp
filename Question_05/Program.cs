// Написать программу возведения числа А в целую степнь B 
// B^A?
int ASquerB(int a, int b)
{
    if(b == 0) return 1;
    return ASquerB(a, b-1) * a;
}
Console.Write("Enter a:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter b:");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine(ASquerB(a,b));