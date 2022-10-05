var listOfItems = new List<object>() { 1, 2, "a", "b" };
List<int> result = new List<int>();
foreach (var item in listOfItems)
{
    if (item is int)
    {
        result.Add((int)item);
    }
}
foreach (int j in result)
{
    Console.WriteLine(j);
}
