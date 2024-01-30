//1.2.
var fruits = new List<string>(){"seb","banan","apelsin"};

//3.
System.Console.WriteLine(fruits.Count());

//4.
foreach (var item in fruits)
{
    System.Console.WriteLine(item);
}

//5.
fruits.Remove("banan");
foreach (var item in fruits)
{
    System.Console.WriteLine(item);
}

//6.
System.Console.WriteLine(fruits.Find(e => e == "seb"));
//7.
fruits.Clear();

//8.
var list = new List<string>(){"seb","banan","apelsin"};

//9.
list.Insert(0,"grape");

//10.
string du = list[2];
list.RemoveAt(2);
System.Console.WriteLine(du);

//11.
if(list.Count == 0)
{
    System.Console.WriteLine(false);
}

//12.
list.Sort();

//13.
System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
list.Reverse();
foreach (var item in list)
{
    System.Console.WriteLine(item);
}

//14.
var list1 = new List<string>(){"seb","banan","apelsin"};

//15.
for (int i = 0; i < list1.Count; i++)
{
    if(list1[i] == "seb")
    {
        System.Console.WriteLine(i);
    }
}

//16.
list.RemoveAll(e => e.Length > 5);
foreach (var item in list)
{
    System.Console.WriteLine(item);
}

//17.
int cnt = 0;
foreach (var item in list1)
{
    if(item[0] == 'a')
    {
        cnt++;
    }
}
System.Console.WriteLine(cnt);

//18.
System.Console.WriteLine("Hama saday");

//19.
list1.Reverse();

//20.
string www = string.Join(" ",list1);
System.Console.WriteLine(www);