﻿Console.Write("Seconds: ");
var seconds = int.Parse(Console.ReadLine());
var days = seconds / 86400;
var hours = seconds / 36000;
seconds = seconds % 3600;
var minutes = seconds / 60;
seconds = seconds % 60;
Console.WriteLine($"Days: {days}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Seconds: {seconds}");