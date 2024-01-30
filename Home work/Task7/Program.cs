List<string> nom = new List<string>(){"Mustafo","Yusuf","Davron"};

nom.RemoveAt(1);

foreach (var item in nom)
{
    System.Console.WriteLine(item);
}