List<bool> values = new List<bool>{ true, true, true };

bool allTrue = values.Exists(e => e == true);
Console.WriteLine("Are all the values in the list true? " + allTrue);