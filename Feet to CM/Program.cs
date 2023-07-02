Console.Write("Feet: ");
var feet = double.Parse(Console.ReadLine());
Console.Write("Inches: ");
var inches = double.Parse(Console.ReadLine());
var heightInCM = (inches * 2.54) + (feet * 12 * 2.54);
Console.WriteLine($"CM: {heightInCM}");