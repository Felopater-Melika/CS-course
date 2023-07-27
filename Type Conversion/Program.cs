using System;

public class TypeConversion
{
    public static void Main()
    {
        // Conversion using casting and conversion methods
        byte a = 10;
        short shortFromByte = a; // Implicit casting
        Console.WriteLine(shortFromByte);

        var b = 10;
        var shortFromInt = (short)b; // Explicit casting
        Console.WriteLine(shortFromInt);

        var c = "10.34";
        var doubleFromString = double.Parse(c); // Parse method
        Console.WriteLine(doubleFromString);

        decimal decimalFromString;
        if (decimal.TryParse(c, out decimalFromString)) // TryParse method
            Console.WriteLine(decimalFromString);

        var d = 20.3m;
        var stringFromDecimal = Convert.ToString(d); // Conversion method
        Console.WriteLine(stringFromDecimal);
    }
}