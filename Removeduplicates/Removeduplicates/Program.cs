using System.ComponentModel;

int[] a = {1, 1, 2};
List <int> b = new List<int>();
for (var i = 1; i <= a.Length - 1; i++)
{
    if (a[i] != a[i - 1])
    {
        b.Add(a[i]);
    }
}
foreach (var i in b)
{
    Console.WriteLine(i);
}
