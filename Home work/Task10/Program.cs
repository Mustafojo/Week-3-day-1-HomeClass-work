using System.Globalization;
using System.Security.Cryptography;

List<int> mylist = new List<int>();
var random = new Random();


for (int i = 0; i < random.Next(1, 10); i++)
{
    mylist.Add(random.Next(1,10));
}

foreach (var item in mylist)
{
    System.Console.WriteLine(item);
}