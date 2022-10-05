string str = "This is an example!";
char[] charArray = str.ToCharArray();
string reversedstr = string.Empty;

var i = charArray.Length - 1;
while (i >= 0)
{
    reversedstr += charArray[i];
    i--;
}
Console.WriteLine(reversedstr);
