Console.Write("Number: ");
var number = int.Parse(Console.ReadLine());
var lastThreeDigits = number % 1000;
number = number - lastThreeDigits >= 500? number - lastThreeDigits + 1000 : number - lastThreeDigits;
number = number < 500 ? number = 1000 : number;
Console.WriteLine($"Nearest Thousand: {number}");