using System.Globalization;

int integer = 5;
int limit = 25;
List<int> multiples = new List<int>();
for (var i = 2; i <= limit; i++)
{
    if (i % integer == 0)
    {
        multiples.Add(i);
    }
}
foreach (int j in multiples)
{
    Console.WriteLine(j);
}
