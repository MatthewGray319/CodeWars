// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
List<int> list = new List<int>();
list.Add(3);
list.Add(2);
list.Add(1);
list.Add(2);
list.Add(0);
List<int> NewList = new List<int>();
for (int i = 0; i <= list.Count - 1; i++)
{
    NewList.Add(list[list.Count - 1 - i]);
}
foreach (int i in NewList)
{
    Console.WriteLine(i);
}
;