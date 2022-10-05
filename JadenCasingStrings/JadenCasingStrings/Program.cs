using System.Reflection.Metadata.Ecma335;

string phrase = "How can mirrors be real if our eyes aren't real";
List<string> list = new List<string>();
list = phrase.Split(' ').ToList();
string result = "";
foreach (string s in list)
{
    char[] array = s.ToCharArray();
    if (char.IsLower(array[0]))
    {
        array[0] = char.ToUpper(array[0]);
    }
    Console.WriteLine(array);
    if (s == list[0])
    {
        result = string.Concat(array);
    }
    else
    {
        result = result + $" " + string.Concat(array);
    }
}

