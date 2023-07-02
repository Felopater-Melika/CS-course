Console.WriteLine("what is the radius of the circle?");
var radius = double.Parse(Console.ReadLine());
var area = Math.PI * Math.Pow(radius, 2);
Console.WriteLine($"The area of the circle is {area}");