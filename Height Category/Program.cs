Console.Write("What is your height in inches? ");
var height = Convert.ToInt32(Console.ReadLine()) * 2.54;
if (height < 150)
{
    Console.WriteLine("Dwarf");
}
else if (height < 165)
{
    Console.WriteLine("Average Height");
}
else if (height < 195)
{
    Console.WriteLine("Tall");
}
else
{
    Console.WriteLine("Abnormal Height");
}
