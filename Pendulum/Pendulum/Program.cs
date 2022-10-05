int[] values = new int[] { 9, 4, 6, 4, 10, 5 };
Array.Sort(values);
int[] result = new int[values.Length];
if (result.Length %  2 == 1)
{ 
result[(result.Length / 2)] = values[0];
int i = 1;
int j = 1;
while (i <= values.Length / 2)
{
    result[result.Length / 2 + i] = values[j];
    result[result.Length / 2 - i] = values[j + 1];
    i++;
    j = j + 2; 
}
}
else
{
    result[((result.Length - 1) / 2)] = values[0];
    int i = 1;
    int j = 1;
    while (j < values.Length - 1)
    {
        result[(result.Length - 1) / 2 + i] = values[j];
        result[(result.Length - 1) / 2 - i] = values[j + 1];
        i++;
        j = j + 2;
    }
    result[(result.Length - 1) / 2 + i] = values[j];
}
foreach (var item in result)
{
    Console.WriteLine(item);

}


