using System.Diagnostics.CodeAnalysis;

int n = 9;
decimal sum = 0;
if (n >= 2)
{
    Console.WriteLine(sum);
    for (int i = 1; i <= n; i++)
    {
        sum = sum + (1m/(3*i-2));
        Console.WriteLine(sum);
    }
}
string sumstring = String.Format("{0:0.00}", sum);
Console.WriteLine(sumstring);
