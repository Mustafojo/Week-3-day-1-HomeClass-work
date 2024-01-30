List<string> nom = new List<string>(){"Mustafo","Yusuf","Davron"};

var find = nom.FindAll(e => e.Length < 6);

foreach (var item in find)
{
    System.Console.WriteLine(item);
}