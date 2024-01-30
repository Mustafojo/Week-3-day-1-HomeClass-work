List<double> numbers = new List<double>{ 3.5, 2.7, 6.9, 1.2 };
double average = 0;
foreach (var item in numbers)
{
    average += item;
}
average = average / numbers.Count();

Console.WriteLine("The average value of all the elements in the list is: " + average);
