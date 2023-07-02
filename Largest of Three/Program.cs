Console.Write("Enter the first number: ");
var firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
var secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
var thirdNumber = Convert.ToInt32(Console.ReadLine());
var largestNumber = firstNumber;
if (secondNumber > largestNumber)
{
    largestNumber = secondNumber;
}
if (thirdNumber > largestNumber)
{
    largestNumber = thirdNumber;
}
Console.WriteLine($"The largest number is: {largestNumber}");